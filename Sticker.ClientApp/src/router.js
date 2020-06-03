import Vue from "vue";
import Router from "vue-router";

Vue.use(Router)

const Home = () => import('@/views/Home/Home.vue')
const Login = () => import('@/views/Login/Login.vue')
const NotFound = () => import('@/views/NotFound/NotFound.vue')

const router = new Router({
    mode: 'history',
    routes: [{
        path: 'home',
        name: 'Home',
        redirect: '/'
    }, {
        path: '/login',
        name: 'Login',
        component: Login
    }, {
        path: '/',
        name: 'Index',
        component: Home
    }, {
        // 所有未知路由返回NotFound
        path: '*',
        name: 'NotFound',
        component: NotFound
    }]
})

export default router