var continentGenerator = angular.module("continent-generator", ["ui.router", "ngResource"]);

continentGenerator.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise("");

var sp = $stateProvider
    .state("home", {
        url: "",
        views: {
            "navbar": {
                templateUrl: "/Models/Angular/NavBar/Templates/home-nav.html"
            },
            "content-view": {
                templateUrl: "/Models/Angular/ContentView/Templates/home-content.html"
            }
        }
    })
    .state("generate-new", {
        url: "/create",
        views: {
            "navbar": {
                templateUrl: "/Models/Angular/NavBar/Templates/generate-new.html"
            },
            "content-view": {
                templateUrl: "/Models/Angular/ContentView/Templates/home-content.html"
            }
        }
    });
})