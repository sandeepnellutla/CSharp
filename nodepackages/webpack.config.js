var path = require('path');
var webpack = require ('webpack');
var ExtractTextPlugin = require("extract-text-webpack-plugin");
var OptimizeCssAssetsPlugin = require('optimize-css-assets-webpack-plugin');
var HtmlWebpackPlugin = require('html-webpack-plugin');
var CleanWebpackPlugin = require('clean-webpack-plugin');

module.exports = {
    entry:[
            './node_modules/jquery/dist/jquery.js',
            './src/file3.js'
          ],
    output:{
        path:path.resolve(__dirname,'dist'),
        filename:'bundle.js',
        publicPath:'/dist'
    },
    module:{
        rules:[
            {
                test:/\.css$/,
                use:ExtractTextPlugin.extract({
                    fallback: "style-loader",
                    use: "css-loader"
                })
            }
        ]
    },
    plugins: [
        new ExtractTextPlugin({
            filename: "style.min.css",
            allChunks: true,
            publicPath:'/dist'
        }),
        new OptimizeCssAssetsPlugin(),
        new webpack.optimize.UglifyJsPlugin({
            title: 'Output Management'
        }),
        new CleanWebpackPlugin(['dist']),
        new webpack.ProvidePlugin({
            $:'jquery',
            jQuery:'jquery'
        })
    ]
}