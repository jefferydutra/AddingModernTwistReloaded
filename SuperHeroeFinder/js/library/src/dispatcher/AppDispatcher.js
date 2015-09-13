var Dispatcher = require('flux').Dispatcher;
var assign = require('object-assign');
var PayloadSources = require('../constants/PayloadSources');

function throwExceptionIfActionNotSpecified(action) {
    if (!action.type) {
        throw new Error('Action type was not provided');
    }
}

var AppDispatcher = assign(new Dispatcher(), {
    handleServerAction: function(action) {
        throwExceptionIfActionNotSpecified(action);
        this.dispatch({
            source: PayloadSources.SERVER_ACTION,
            action: action
        });
    },

    handleViewAction: function(action) {
        throwExceptionIfActionNotSpecified(action);
        this.dispatch({
            source: PayloadSources.VIEW_ACTION,
            action: action
        });
    }
});

module.exports = AppDispatcher;
