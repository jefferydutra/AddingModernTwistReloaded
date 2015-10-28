var React = require('react');
var FilterRow = require('../components/FilterRow.jsx');
var Statistics = require('../components/Statistics.jsx');
var DataGrid = require('../components/DataGrid.jsx');
var CharacterActionCreators = require('../actions/CharacterActionCreators');

CharacterActionCreators.loadAll();

var CharacterList = React.createClass({
    render: function() {
        return (
            <div>
                <Statistics/>
                <FilterRow />
                <DataGrid />
            </div>
        );
    }
});

module.exports = CharacterList;
