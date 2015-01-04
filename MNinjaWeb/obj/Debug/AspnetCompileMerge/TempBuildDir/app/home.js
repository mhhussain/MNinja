define(['durandal/app', 'knockout'], function(app, ko) {
    return {
        name: ko.observable(),
        world: function() {
            app.showMessage('Hello ' + this.name() + '! This is world.', 'The universe speaks.');
        }
    };
});