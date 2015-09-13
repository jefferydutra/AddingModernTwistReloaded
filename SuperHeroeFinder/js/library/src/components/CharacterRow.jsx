var React = require('react');
// ToDo:Add Icon Component

var paddingRight = {
    paddingRight: '10px'
};

var CharacterRow = React.createClass({
    render: function() {
        return (
            <tr>
                <td>
                    <span
                        className='glyphicon glyphicon-user'
                        style={paddingRight}>
                    </span>

                    {this.props.character.name}
                </td>
                <td>{this.props.character.numberOfComics}</td>
                <td>{this.props.character.numberOfSeries}</td>
                <td>
                    <a
                        href={this.props.character.profilePage}
                        target='_blank'>
                        Bio Page
                    </a>
                </td>
            </tr>
        );
    }
});

module.exports = CharacterRow;
