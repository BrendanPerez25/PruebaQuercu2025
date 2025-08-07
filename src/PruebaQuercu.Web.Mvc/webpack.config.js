const path = require('path');

module.exports = {
    entry: './wwwroot/scripts/main.js',
    output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, 'wwwroot/dist'),
    },
    mode: 'development'
};
