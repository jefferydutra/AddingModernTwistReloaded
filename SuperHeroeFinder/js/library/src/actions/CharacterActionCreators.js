var AppDispatcher = require('../dispatcher/AppDispatcher');
var CharacterApiUtils = require('../utils/CharacterApiUtils');
var CharacterConstants = require('../constants/CharacterConstants');

var CharacterActions = {

    receiveAll: function(characters) {
        AppDispatcher.handleServerAction({
            type: CharacterConstants.ActionTypes.RECEIVE_CHARACTERS,
            characters: characters
        });
    },

    loadAll: function() {
        CharacterApiUtils.getCharacters(CharacterActions.receiveAll);
    },

    addCharacter(character) {
        CharacterApiUtils.postCharacter(character, CharacterActions.receiveCreatedCharacter);
    },

    receiveCreatedCharacter(character) {
        AppDispatcher.handleServerAction({
            type: CharacterConstants.ActionTypes.RECEIVE_CREATED_CHARACTER,
            character: character
        });
    }

};

module.exports = CharacterActions;
