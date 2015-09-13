var React = require('react');
var App = require('./App.jsx');

window.legacy = {};
window.legacy.loadApp = function(domId) {
    var container = document.getElementById(domId);
    React.render(<App />, container);

};
