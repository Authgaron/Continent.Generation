angular.module("continent-generator")
    .directive("continentGeneratorValueInput", function () {
        return {
            templateUrl: "/Models/Angular/NavBar/Templates/value-input.html",
            restrict: "E",
            scope: true,
            link: function(scope, elem, attrs) {   
            }
        }
    });