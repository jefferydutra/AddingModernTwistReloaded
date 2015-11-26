var ApiConstants = require('./ApiConstants');
var keymirror = require('keymirror');

module.exports = {
    ApiEndPoints: {
        CHARACTER_GET: ApiConstants.API_ROOT + '/Character'
    },
    ActionTypes: keymirror({
        RECEIVE_CHARACTERS: null
    })
};
