var React = require('react');

var filterButtonStyle = {
    marginLeft: '15px'
};

var FilterRow = React.createClass({
    _submitForm: function(e) {
        e.preventDefault();
    },

    render: function() {
        return (
            <div clasName='row'>
                <form className='form-inline'>
                    <label>
                        <select
                            defaultValue=''
                            className='form-control input-sm'>
                            <option value='' disabled>Select hero type ..</option>
                            <option value='1'>Hero</option>
                            <option value='3'>Villain</option>
                            <option value='3'>A little bit of both</option>
                        </select>
                    </label>
                    <button
                        style={filterButtonStyle}
                        className='btn btn-primary'
                        onClick={this._submitForm}>
                        Filter
                    </button>
                </form>
            </div>
        );
    }
});

module.exports = FilterRow;
