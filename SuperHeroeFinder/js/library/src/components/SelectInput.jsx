var React = require('react');
var Input = require('react-bootstrap').Input;


function getFormGoupBasedOnValidInput(isValid) {
    return isValid
        ? 'form-group'
        : 'form-group has-error';
}

function getLabel(isValid, label) {
    return isValid
        ? label
        : label + ' (is required)';
}

function getSelectOption(selectArrayItem, selectId, selectText) {
    var key = selectArrayItem[selectId];
    var text = selectArrayItem[selectText];
    return (
        <option key={key} value={key}>{text}</option>
    );
}

var RequiredSelectBox = React.createClass({
    render: function() {
        var isValid = this.props.isValid();
        var options = this.props.options.map(function(option) {
            return getSelectOption(option, this.props.optionValue, this.props.optionText);
        }, this);
        var inputValidationClass = getFormGoupBasedOnValidInput(isValid);
        var label = getLabel(isValid, this.props.label);
        return (
            <div className={inputValidationClass}>
                <Input
                    type="select"
                    label={label}
                    onChange={this.props.onValueChange}
                    defaultValue={this.props.value}>
                    <option value=''>--- Select a {this.props.label}---</option>
                    {options}
                </Input>
            </div>
        );
    }
});

module.exports = {
    Required: RequiredSelectBox
};