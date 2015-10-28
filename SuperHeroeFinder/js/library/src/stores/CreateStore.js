var _ = require('lodash');
var EventEmitter = require('events').EventEmitter;
var assign = require('object-assign');

var CHANGE_EVENT = 'change';

var createStore = function(spec) {
    var store = assign({
        emitChange: function() {
            this.emit(CHANGE_EVENT);
        },

        addChangeListener: function(callback) {
            this.on(CHANGE_EVENT, callback);
        },

        removeChangeListener: function(callback) {
            this.removeListener(CHANGE_EVENT, callback);
        }
    }, spec, EventEmitter.prototype);

    _.forEach(store, function(val, key) {
        if (_.isFunction(val)) {
            store[key] = store[key].bind(store);
        }
    });

    store.setMaxListeners(0);
    return store;
};

module.exports = createStore;
