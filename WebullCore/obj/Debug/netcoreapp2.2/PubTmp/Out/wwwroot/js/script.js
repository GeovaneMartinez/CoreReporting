/// <reference path="angular.js" />

//Create the module
//var myApp = angular.module("myModule", []);

//Create the controller and register the controller with the module
//myApp.controller("myController", function ($scope) {

//    var employee = {
//        firstName : "David",
//        lastName : "Hastings",
//        gender : "Male"

//    };

//    $scope.employee = employee;
//    $scope.message = "AngularJS tutorial";
//});



var myApp = angular
    .module("myModule", [])
    .controller("myController", function ($scope) {


        var technologies = [

            { name: "C#", likes: 0, dislikes: 0 },
            { name: "ASP.NET", likes: 0, dislikes: 0 },
            { name: "SQL Server", likes: 0, dislikes: 0 },
            { name: "AngularJS", likes: 0, dislikes: 0 }
        ];

        $scope.technologies = technologies;
        $scope.incrementLikes = function (technology) {
            technology.likes++;
        };
        $scope.incrementDislikes = function (technology) {
            technology.dislikes++;
        };




        var employees = [

            {firstName: "David", lastName: "Hastings", gender: "Male", salary: 55000 },
            {firstName: "Sara", lastName: "Paul", gender: "Female", salary: 68000 },
            {firstName: "Mark", lastName: "Holland", gender: "Male", salary: 57000 },
            {firstName: "Pam", lastName: "Macintosh", gender: "Female", salary: 53000 },
            {firstName: "Todd", lastName: "Barber", gender: "Male", salary: 60000 },
                
        ];

        var employeestwo = [

            { firstName: "David", dateOfBirth: new Date("November 21, 1980") , lastName: "Hastings", gender: "Male", salary: 55000.788 },
            { firstName: "Sara", dateOfBirth: new Date("May 05, 1970"), lastName: "Paul", gender: "Female", salary: 68000 },
            { firstName: "Mark", dateOfBirth: new Date("August 15, 1974"), lastName: "Holland", gender: "Male", salary: 57000 },
            { firstName: "Pam", dateOfBirth: new Date("October 27, 1979"), lastName: "Macintosh", gender: "Female", salary: 53000 },
            { firstName: "Todd", dateOfBirth: new Date("December 30, 1983"), lastName: "Barber", gender: "Male", salary: 60000 },

        ];

        $scope.employeestwo = employeestwo;
        $scope.rowLimit = 3;
        $scope.sortColumn = "firstName";

        var countries = [
            {
                name: "UK",
                cities: [
                    { name: "London" },
                    { name: "Manchester" },
                    { name: "Birmingham" }
                ]

            },
            {
                name: "USA",
                cities: [
                    { name: "Los Angeles" },
                    { name: "Chicago" },
                    { name: "Houston" }
                ]

            },
            {
                name: "India",
                cities: [
                    { name: "Hyderabad" },
                    { name: "Chennai" },
                    { name: "Mumbai" }
                ]

            }



        ];

        $scope.countries = countries;
        var employee = {
            firstName: "David",
            lastName: "Hastings",
            gender: "Male"

        };

        $scope.employees = employees;
        $scope.message = "Hello Angular";
    });

