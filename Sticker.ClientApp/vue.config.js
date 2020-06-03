module.exports = {
    chainWebpack: config => {
        config
            .plugin('html')
            .tap(args => {
                args[0].title= 'Sticker Client App'
                return args
            })
    }
}