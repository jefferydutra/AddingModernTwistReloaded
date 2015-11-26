var ApiConstants = require('./ApiConstants');
var keymirror = require('keymirror');

module.exports = {
    ApiEndPoints: {
        CHARACTER_GET: ApiConstants.API_ROOT + '/Character',
        CHARACTER_COMMAND: ApiConstants.API_ROOT + '/CharacterCommand'
    },
    ActionTypes: keymirror({
        RECEIVE_CHARACTERS: null,
        RECEIVE_CREATED_CHARACTER: null
    })
};
