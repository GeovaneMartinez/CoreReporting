#pragma checksum "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f91aca778120b0e342f89029226ae7bd0c7c375e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\_ViewImports.cshtml"
using WebullCore;

#line default
#line hidden
#line 2 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\_ViewImports.cshtml"
using WebullCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f91aca778120b0e342f89029226ae7bd0c7c375e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad61bdaae5e561824397dd63c86f033006a8855", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebullCore.Models.TradeResults>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Percentage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTransaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTransaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/LineChart.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 18, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
            EndContext();
            BeginContext(113, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f91aca778120b0e342f89029226ae7bd0c7c375e5848", async() => {
                BeginContext(172, 20, true);
                WriteLiteral("Angular Ajax Example");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(196, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(206, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f91aca778120b0e342f89029226ae7bd0c7c375e7532", async() => {
                BeginContext(271, 16, true);
                WriteLiteral("Percentage Chart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(291, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(301, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f91aca778120b0e342f89029226ae7bd0c7c375e9212", async() => {
                BeginContext(354, 15, true);
                WriteLiteral("Add Transaction");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(373, 416, true);
            WriteLiteral(@"

<table>
    <tr>
        <th style=""width: 80px;"">Symbol</th>
        <th style=""width: 125px;"">StartDate</th>
        <th style=""width: 125px;"">StartPrice</th>
        <th style=""width: 80px;"">Shares</th>
        <th style=""width: 125px;"">EndDate</th>
        <th style=""width: 80px;"">EndPrice</th>
        <th style=""width: 50px;"">Percentage</th>
        <th style=""width: 60px;"">P\L</th>
    </tr>
");
            EndContext();
#line 25 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(830, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(852, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f91aca778120b0e342f89029226ae7bd0c7c375e11509", async() => {
                BeginContext(931, 11, false);
#line 28 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
                                                                                     Write(item.Symbol);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
                                                                    WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(946, 41, true);
            WriteLiteral("</td>\r\n        <td style=\"width: 125px;\">");
            EndContext();
            BeginContext(988, 14, false);
#line 29 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
                             Write(item.StartDate);

#line default
#line hidden
            EndContext();
            BeginContext(1002, 41, true);
            WriteLiteral("</td>\r\n        <td style=\"width: 125px;\">");
            EndContext();
            BeginContext(1044, 15, false);
#line 30 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
                             Write(item.StartPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1059, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1079, 11, false);
#line 31 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
       Write(item.Shares);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1110, 12, false);
#line 32 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
       Write(item.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(1122, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1142, 13, false);
#line 33 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
       Write(item.EndPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1155, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1175, 15, false);
#line 34 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
       Write(item.Percentage);

#line default
#line hidden
            EndContext();
            BeginContext(1190, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1210, 32, false);
#line 35 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
       Write(item.ProfitLoss.ToString("0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 18, true);
            WriteLiteral("</td>\r\n    </tr>\r\n");
            EndContext();
#line 37 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1267, 258, true);
            WriteLiteral(@"    <tr>
        <td style=""width: 100px;""></td>
        <td style=""width: 100px;""></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td style=""padding: 0px 25px 0px 0px;""><span style=""border-top: 1px solid black;"">");
            EndContext();
            BeginContext(1526, 40, false);
#line 45 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
                                                                                     Write(ViewBag.PercentageTotal.ToString("0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 97, true);
            WriteLiteral("<span>%</span></span></td>\r\n        <td><span style=\"border-top: 1px solid black;\"><span>$</span>");
            EndContext();
            BeginContext(1664, 30, false);
#line 46 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
                                                                Write(ViewBag.Total.ToString("0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 41, true);
            WriteLiteral("</span></td>\r\n    </tr>\r\n</table>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(1735, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f91aca778120b0e342f89029226ae7bd0c7c375e18212", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1776, 420, true);
            WriteLiteral(@"
<div id=""chart_div""></div>

<br />
<br />

<script type=""text/javascript"">

    google.charts.load('current', { packages: ['corechart', 'line'] });
    google.charts.setOnLoadCallback(drawBasic);

    function drawBasic() {

        var data = new google.visualization.DataTable();
        data.addColumn('number', 'X');
        data.addColumn('number', 'Cash');

        data.addRows([

            ");
            EndContext();
            BeginContext(2197, 21, false);
#line 71 "C:\Program Files\aspnetmvc\WebullCore\WebullCore\Views\Home\Index.cshtml"
       Write(ViewBag.JsonChartData);

#line default
#line hidden
            EndContext();
            BeginContext(2218, 361, true);
            WriteLiteral(@"

        ]);

        var options = {
            hAxis: {
                title: 'Num of Trades'
            },
            vAxis: {
                title: 'Equity'
            }
        };

        var chart = new google.visualization.LineChart(document.getElementById('chart_div'));

        chart.draw(data, options);
    }


</script>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebullCore.Models.TradeResults>> Html { get; private set; }
    }
}
#pragma warning restore 1591