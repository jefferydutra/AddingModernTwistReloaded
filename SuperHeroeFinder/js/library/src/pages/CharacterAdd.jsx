var React = require('react');
var TextInput = require('../components/Input.jsx');

var AddCharacter = React.createClass({
    getInitialState() {
        return {
            name: '',
            series: ''
        };
    },
    _handleChange(key, event) {
        var obj = {};
        obj[key] = event.target.value;
        this.setState(obj);
    },
    _nameIsValid() {
        return !!this.state.name;
    },
    _seriesIsValid() {
        return !!this.state.series;
    },
    render() {
        return (
            <div className='container'>
                <h2>Add Character Form</h2>
                Need to fix validation
                <form>
                    <TextInput
                        label='Name:'
                        isValid={this._nameIsValid}
                        handleChange={this._handleChange.bind(null, 'name')}
                        value={this.state.name}/>
                    <TextInput
                        label='# of Series:'
                        isValid={this._seriesIsValid}
                        handleChange={this._handleChange.bind(null, 'series')}
                        value={this.state.series}/>
                </form>
            </div>
        );
    }
});

module.exports = AddCharacter;
