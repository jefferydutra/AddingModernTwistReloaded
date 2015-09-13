var React = require('react');
var CharacterStore = require('../stores/CharacterStore');

function getCharacterCount() {
    return CharacterStore.getCharacterCount();
}

var Statistics = React.createClass({
    getInitialState: function() {
        return {
            characterCount: getCharacterCount()
        };
    },
    componentWillMount: function() {
        CharacterStore.addChangeListener(this._onChange);
    },

    componentWillUnmount: function() {
        CharacterStore.removeChangeListener(this._onChange);
    },
    _onChange: function() {
        this.setState({characterCount: getCharacterCount()});
    },
    render: function() {
        return (
            <div>
                <div className='label label-success pull-right'>
                    Matching heroes
                    <span className="badge">
                        {this.state.characterCount}
                    </span>
                </div>
            </div>
        );
    }
});

module.exports = Statistics;
