'use strict';

var webpack = require('webpack');
var ExtractTextPlugin = require("extract-text-webpack-plugin");
var baseConfig = require('./webpack.config.base');

var config = Object.create(baseConfig);

config.module.loaders[0].loaders.unshift('react-hot');

config.entry = {
    App: [
        'webpack-dev-server/client?http://localhost:3000/',
        'webpack/hot/dev-server',
        config.entry
    ]
};
config.plugins.push(new webpack.HotModuleReplacementPlugin());

module.exports = config;
