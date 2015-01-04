requirejs.config({
    paths: {
        'text': '../Scripts/text',
        'durandal': '../Scripts/durandal',
        'plugins': '../Scripts/durandal/plugins',
        'transitions': '../Scripts/durandal/transitions',
        'knockout': '../Scripts/knockout/knockout-3.1.0',
        'jquery': '../Scripts/jquery/jquery-1.10.2'
    }
});

//define('jquery', jquery);
//define('knockout', ko);

define(['durandal/system', 'durandal/app'],
function (system, app) {
    //var system = require('durandal/system'),
    //    app = require('durandal/app');

    system.debug(true);

    app.title = 'MNinja1.0';

    app.configurePlugins({
        router: true,
        dialog: true
    });

    app.start().then(function() {
        app.setRoot('shell');
    });
});