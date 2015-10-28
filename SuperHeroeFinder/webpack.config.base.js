'use strict';

var webpack = require('webpack');
var ExtractTextPlugin = require("extract-text-webpack-plugin");
var path = require('path');
var config = require('./webpack.config.base');


module.exports = {
    entry: './js/library/src/components/main.jsx',
    output: {
        filename: 'App.js',
        pathInfo: true,
        path: path.join(__dirname, 'dist'), //
        publicPath: 'http://localhost:3000/' // Required for webpack-dev-server
    },
    module: {
        loaders: [
            {
                test: /\.jsx?$/,
                exclude: [/(node_modules)/],
                loaders: ['babel?stage=0&optional=runtime']
            }

        ],
        preLoaders: [
            {
                test: /(\.js$|\.jsx$)/,
                exclude: [/(node_modules)/],
                loader: 'eslint-loader'
            }
        ]
    },

    plugins: [
        new webpack.NoErrorsPlugin(),
        new webpack.optimize.DedupePlugin()
    ],

    externals: {
        // require("jquery") is external and available
        //  on the global var jQuery
        "jquery": "jQuery"
    }
};
