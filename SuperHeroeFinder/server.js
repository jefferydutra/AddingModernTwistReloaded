var webpack = require('webpack');
var WebpackDevServer = require('webpack-dev-server');
var config = require('./webpack.config.development');

new WebpackDevServer(webpack(config), {
    publicPath: 'http://localhost:3000/',

    inline: true,
    hot: true,
    port: 3000,

    contentBase: './dist',

    stats: {
        colors: true
    },

    historyApiFallback: true,
    headers: {
        'Access-Control-Allow-Origin': 'http://localhost:50744',
        'Access-Control-Allow-Headers': 'X-Requested-With'
    }
}).listen(3000, 'localhost', function (err, result) {
              if (err) {
                  console.log(err);
              }

              console.log('Listening at localhost:3000');
          });