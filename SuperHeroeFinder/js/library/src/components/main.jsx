var React = require('react');
var App = require('./App.jsx');
import CharacterActionCreators from '../actions/CharacterActionCreators.js';
import CharacterAdd from '../pages/CharacterAdd.jsx';
import CharacterList from '../pages/CharacterList.jsx';
import {render} from 'react-dom';
import { Router, Route} from 'react-router';

CharacterActionCreators.loadAll();

var container = document.getElementById('placeHolder');

render((
           <Router>
               <Route path="/" component={App}>
                   <Route path="add" component={CharacterAdd} />
                   <Route path="list" component={CharacterList} />
               </Route>
           </Router>
       ), container);
