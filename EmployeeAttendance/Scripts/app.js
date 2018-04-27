var app = angular.module("app", []);

app.controller("empCtrl", function ($http, $scope) {

    $scope.getEmployees = function (criteria) {
        $http.get("/Employee").then(function (data) { $scope.employees = data.data }, function (error) { });
    }

    $scope.showDetails = function (employee) {
        $scope.currentEmployee = employee;
    }

});

app.filter("DateParser", function () {
    var re = /\/Date\(([0-9]*)\)\//;
    return function (x) {
        var m = x.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    };
});






