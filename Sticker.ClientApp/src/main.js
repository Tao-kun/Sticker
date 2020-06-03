import Vue from 'vue'

import Material from "materialize-css"

import App from '@/App.vue'
import router from "@/router";

Vue.use(Material)

Vue.config.productionTip = false

new Vue({
    router,
    render: h => h(App),
}).$mount('#app')