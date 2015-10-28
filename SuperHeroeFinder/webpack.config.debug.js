'use strict';

var webpack = require('webpack');
var ExtractTextPlugin = require("extract-text-webpack-plugin");
var baseConfig = require('./webpack.config.base');

var config = Object.create(baseConfig);


module.exports = config;
