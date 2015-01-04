define(function(require) {
    var router = require('plugins/router');

    return {
        router: router,
        activate: function() {
            return router.map([
                { route: '', title: 'Home', moduleId: 'home', nav: true }
            ]).buildNavigationModel()
            .mapUnknownRoutes('index', 'not-found')
            .activate();
        }
    };
});