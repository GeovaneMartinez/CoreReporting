using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebullCore.Models;

namespace WebullCore.Controllers
{
    public class HomeController : Controller
    {
        public readonly ITransactionsRepository _transactionsRepository;

        public HomeController(ITransactionsRepository transactionsRepository)
        {
            _transactionsRepository = transactionsRepository;
        }

        public IActionResult Index()
        {
            List<Transactions> transactionsList = _transactionsRepository.GetTransactions().ToList();
            List<TradeResults> tradeResults = new List<TradeResults>();
            decimal? total = 0;
            decimal? percentageTotal = 0;

            foreach (var item in transactionsList)
            {
                TradeResults tradeResult = new TradeResults();
                tradeResult.Id = item.Id;
                tradeResult.StartDate = item.StartDate;
                tradeResult.StartPrice = item.StartPrice;
                tradeResult.EndPrice = item.EndPrice;
                tradeResult.EndDate = item.EndDate;
                tradeResult.Symbol = item.Symbol;
                tradeResult.Shares = item.Shares;

                decimal? profitLossPerShare = tradeResult.EndPrice - tradeResult.StartPrice;

                if(!String.IsNullOrWhiteSpace(tradeResult.EndDate))
                {
                    tradeResult.ProfitLoss = Math.Round((decimal)((tradeResult.EndPrice - tradeResult.StartPrice)) * (decimal)tradeResult.Shares, 2);

                    total += tradeResult.ProfitLoss;
                    tradeResult.Percentage = Math.Round((decimal)(profitLossPerShare / tradeResult.StartPrice) * 100, 2);
                    percentageTotal += tradeResult.Percentage;
                }
                

                tradeResults.Add(tradeResult);
            }


            

            ViewBag.Total = total;
            ViewBag.PercentageTotal = percentageTotal;


            int k = 1;
            String jsonChartData = "[0, 0], ";
            decimal runningTotal = 0;

            foreach (var item in tradeResults)
            {
                if (!String.IsNullOrWhiteSpace(item.EndDate))
                {
                    runningTotal = (decimal)(runningTotal + item.ProfitLoss);
                    jsonChartData += "[" + k + ", " + runningTotal + "]";

                    if ((k) != tradeResults.Count)
                    {
                        jsonChartData += ", ";
                    }
                }
                
                k++;
            }

            ViewBag.JsonChartData = jsonChartData;

            return View(tradeResults);
        }

        public IActionResult Percentage()
        {
            List<Transactions> transactionsList = _transactionsRepository.GetTransactions().ToList();
            List<TradeResults> tradeResults = new List<TradeResults>();
            decimal? total = 0;
            decimal? percentageTotal = 0;

            foreach (var item in transactionsList)
            {
                TradeResults tradeResult = new TradeResults();
                tradeResult.Id = item.Id;
                tradeResult.StartDate = item.StartDate;
                tradeResult.StartPrice = item.StartPrice;
                tradeResult.EndPrice = item.EndPrice;
                tradeResult.EndDate = item.EndDate;
                tradeResult.Symbol = item.Symbol;
                tradeResult.Shares = item.Shares;

                decimal? profitLossPerShare = tradeResult.EndPrice - tradeResult.StartPrice;

                if (!String.IsNullOrWhiteSpace(tradeResult.EndDate))
                {
                    tradeResult.ProfitLoss = Math.Round((decimal)((tradeResult.EndPrice - tradeResult.StartPrice)) * (decimal)tradeResult.Shares, 2);

                    total += tradeResult.ProfitLoss;
                    tradeResult.Percentage = Math.Round((decimal)(profitLossPerShare / tradeResult.StartPrice) * 100, 2);
                    percentageTotal += tradeResult.Percentage;
                }


                tradeResults.Add(tradeResult);
            }




            ViewBag.Total = total;
            ViewBag.PercentageTotal = percentageTotal;


            int k = 1;
            String jsonChartData = "[0, 0], ";
            decimal runningTotal = 0;

            foreach (var item in tradeResults)
            {
                if (!String.IsNullOrWhiteSpace(item.EndDate))
                {
                    runningTotal = (decimal)(runningTotal + item.Percentage);
                    jsonChartData += "[" + k + ", " + runningTotal + "]";

                    if ((k) != tradeResults.Count)
                    {
                        jsonChartData += ", ";
                    }
                }

                k++;
            }

            ViewBag.JsonChartData = jsonChartData;

            return View(tradeResults);
        }

        [HttpGet]
        public IActionResult AddTransaction()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddTransaction(Transactions transaction)
        {
            _transactionsRepository.AddTransaction(transaction);
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult EditTransaction(int id)
        {
            Transactions transaction = _transactionsRepository.GetTransactionById(id);
            return View(transaction);
        }

        [HttpPost]
        public ActionResult EditTransaction(Transactions transaction)
        {
            Transactions updatedTransaction =_transactionsRepository.UpdateTransaction(transaction);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Sorting()
        {

            return View();
        }

        public String AngularTest()
        {
            string hello = "helloWorld!";
            return hello;
        }

        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
