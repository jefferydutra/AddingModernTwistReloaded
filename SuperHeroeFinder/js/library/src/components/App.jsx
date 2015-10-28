var React = require('react');
import { Link } from 'react-router';

const App = React.createClass({
    render: function() {
        return (
            <div>
                <ul className='list-inline pull-right'>
                    <li><Link to='/list'>List</Link></li>
                    <li><Link to='/add'>Add</Link></li>
                </ul>
                <div>
                    <h1>App</h1>
                </div>
                <div>
                    {this.props.children}
                </div>
            </div>
        );
    }
});

module.exports = App;
