var React = require('react');

function errorItem(error) {
    return (
        <li>{error.property}: {error.message}</li>
    );
}

var ErrorAlert = React.createClass({
    render: function() {
        if (!this.props.errorMessages || this.props.errorMessages.length === 0) {
            return null;
        }
        var errorMessage = this.props.errorMessages.map(errorItem);
        return (
            <div className="alert alert-danger" role="alert">
                <ul>
                    {errorMessage}
                </ul>
            </div>
        );
    }
});

module.exports = ErrorAlert;