var React = require('react');
var TextInput = require('../components/Input.jsx');
var Button = require('react-bootstrap').Button;
var CharacterActionCreators = require('../actions/CharacterActionCreators');


var AddCharacter = React.createClass({
    getInitialState() {
        return {
            name: '',
            series: '',
            comics: '',
            profilePage: ''
        };
    },
    _handleChange(key, event)   {
        var obj = {};
        obj[key] = event.target.value;
        this.setState(obj);
    },
    _saveCharacter() {
        const character = {
            name: this.state.name,
            numberOfComics: this.state.comics,
            numberOfSeries: this.state.series,
            profilePage: this.state.profilePage
        };

        CharacterActionCreators.addCharacter(character);
    },
    _hasValue(value) {
        return !!value;
    },
    render() {
        return (
            <div className='container'>
                <h2>Add Character Form</h2>
                Need to add more in
                <form>
                    <TextInput
                        label='Name:'
                        isValid={this._hasValue.bind(null, this.state.name)}
                        handleChange={this._handleChange.bind(null, 'name')}
                        value={this.state.name}/>
                    <TextInput
                        label='# of Comics:'
                        isValid={this._hasValue.bind(null, this.state.comics)}
                        handleChange={this._handleChange.bind(null, 'comics')}
                        value={this.state.comics}/>
                    <TextInput
                        label='# of Series:'
                        isValid={this._hasValue.bind(null, this.state.series)}
                        handleChange={this._handleChange.bind(null, 'series')}
                        value={this.state.series}/>
                    <TextInput
                        label='Profile Page:'
                        isValid={this._hasValue.bind(null, this.state.profilePage)}
                        handleChange={this._handleChange.bind(null, 'profilePage')}
                        value={this.state.profilePage}/>

                    <Button onClick={this._saveCharacter}>
                        Save
                    </Button>
                </form>
            </div>
        );
    }
});

module.exports = AddCharacter;
