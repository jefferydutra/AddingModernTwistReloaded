'use strict';

var webpack = require('webpack');

module.exports = {
    entry: './js/library/src/components/main.jsx',
    output: {
        filename: 'dist/app.js'
    },
    module: {
        loaders: [
            {
                test: /\.jsx?$/,
                exclude: [/(node_modules)/],
                loader: 'babel-loader'
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
    externals: {
        // require("jquery") is external and available
        //  on the global var jQuery
        "jquery": "jQuery",
        "jquery-ui": "jquery-ui",
        "i18n": "i18n",
        "Handsontable": "Handsontable"
    }
};