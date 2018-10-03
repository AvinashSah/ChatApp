/// <reference path="../angular.js" />

(function () {
    angular.module('chatApp', []);

    $(function () {
        $.connection.hub.logging = true;
        $.connection.hub.start();
    });

    $.connection.hub.error(function (err) {
        console.log('An error occurred: ' + err);
    });

    angular.module('chatApp').value('chat', $.connection.chat)
        .value('toastr', toastr);


})();