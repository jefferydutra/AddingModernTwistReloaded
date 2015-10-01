'use strict';

var webpack = require('webpack');
var ExtractTextPlugin = require("extract-text-webpack-plugin");
var baseConfig = require('./webpack.config.base');

var config = Object.create(baseConfig);

config.plugins.push(new webpack.optimze.OccurenceOrderPlugin(),);

config.plugins.push(new webpack.DefinePlugin({
    'process.env.NODE_ENV': JSON.stringify('production')
}));

config.plugins.push(new webpack.optimize.UglifyJsPlugin({
    compressor: {
        screw_ie8: false,
        warnings: false
    }
}));

module.exports = config;
