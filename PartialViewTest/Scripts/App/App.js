angular
    .module('App', ['ngRoute'])
    .config(['$qProvider', '$routeProvider', function ($qProvider, $routeProvider) {
        $qProvider.errorOnUnhandledRejections(false);
    }]);