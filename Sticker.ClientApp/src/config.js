const isProduction = process.env.NODE_ENV === 'production';

export default {
    backend: {
        address: isProduction ? 'http://127.0.0.1:5000/api' : '/api'
    }
}