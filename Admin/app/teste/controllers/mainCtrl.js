
// create the controller and inject Angular's $scope
scotchApp.controller('mainController', function ($location) {
    var vm = this;

    // create a message to display in our view
    vm.message = 'HOME';

    vm.click = function () {
        $location.path('/about')
    }
});

scotchApp.controller('aboutController', function ($location) {

    var vm = this;

    vm.message = 'About';

    vm.click = function () {        
        $location.path('/')
    }
});

//scotchApp.controller('contactController', function ($scope) {
//    $scope.message = 'Contact us! JK. This is just a demo.';
//});