var app = angular.module("app", []);

app.controller("empCtrl", function ($http, $scope) {

    $scope.getEmployees = function (criteria) {
        $http.get("/Employee").then(function (data) { $scope.employees = data.data }, function (error) { });
    }

    $scope.showDetails = function (employee) {
        $scope.currentEmployee = employee;
    }

});






