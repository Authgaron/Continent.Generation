angular.module("continent-generator")
    .directive("continentGeneratorCoreNav", function () {
        return {
            templateUrl: "/Models/Angular/NavBar/Templates/core-nav.html",
            restrict: "E",
            scope: true
        }
    });