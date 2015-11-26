var React = require('react');
var Input = require('react-bootstrap').Input;

const TextInput = React.createClass({
    propTypes: {
        isValid: React.PropTypes.func,
        label: React.PropTypes.string,
        value: React.PropTypes.any.isRequired,
        errorMessage: React.PropTypes.string
    },
    getDefaultProps() {
        return {
            isValid: function() {
                return true;
            }
        };
    },

    validationState() {
        if (this.props.isValid()) return 'success';
        return 'error';
    },

    render() {
        return (
            <Input
                type="text"
                placeholder="Enter text"
                value={this.props.value}
                onChange={this.props.handleChange}
                label={this.props.label}
                help={this.props.errorMessage}
                bsStyle={this.validationState()}
                hasFeedback
                ref="input"
                groupClassName="group-class"
                labelClassName="label-class"/>
        );
    }
});

module.exports = TextInput;
