var CharacterConstants = require('../constants/CharacterConstants');

var CharacterApiUtils = {
    getCharacters(successCallback) {
        $.get(CharacterConstants.ApiEndPoints.CHARACTER_GET)
            .done(function(data) {
                successCallback(data);
            });
    },
    postCharacter(character, successCallback) {
        $.ajax({
            type: 'POST',
            url: CharacterConstants.ApiEndPoints.CHARACTER_COMMAND,
            data: JSON.stringify(character),
            contentType: 'application/json'
        })
        .done(function(createdCharacter) {
            character.id = createdCharacter.id;
            successCallback(character);
        });
    }

};

module.exports = CharacterApiUtils;
