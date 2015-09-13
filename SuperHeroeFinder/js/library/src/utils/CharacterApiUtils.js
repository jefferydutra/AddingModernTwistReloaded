var CharacterConstants = require('../constants/CharacterConstants');

var CharacterApiUtils = {
    getCharacters: function(successCallback) {
        $.get(CharacterConstants.ApiEndPoints.CHARACTER_GET)
            .done(function(data) {
                successCallback(data);
            });
    }
};

module.exports = CharacterApiUtils;
