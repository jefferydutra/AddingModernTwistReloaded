var AppDispatcher = require('../dispatcher/AppDispatcher');
var CharacterConstants = require('../constants/CharacterConstants');
import createStore from './CreateStore.js';
var _characters = {};
var CharacterStore = createStore({

    init(characters) {
        characters.forEach(character => _characters[character.id] = character);
    },

    getAll() {
        return _characters;
    },

    getCharacterCount() {
        return _characters.length;
    }

});

AppDispatcher.register(function(payload) {
    var action = payload.action;

    switch (action.type) {
        case CharacterConstants.ActionTypes.RECEIVE_CHARACTERS:
            CharacterStore.init(action.characters);
            CharacterStore.emitChange();
            break;
    }

});

module.exports = CharacterStore;

