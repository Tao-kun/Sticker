<template>
    <div>
        <nav class="navbar navbar-expand-sm" role="navigation">
            <div class="container-fluid nav-wrapper">
                <div class="navbar-header">
                    <a href="#" data-target="slide-out" class="sidenav-trigger"><i class="material-icons">menu</i></a>
                    <a href="#" class="brand-logo">Sticker</a>
                </div>
                <div>
                    <ul class="nav navbar-nav right hide-on-med-and-down">
                        <li v-for="head in heads" :key="head">
                            <router-link :to=head.url>{{head.text}}</router-link>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>

        <MobileSidebar :heads="heads"></MobileSidebar>
    </div>
</template>

<script>
    import MobileSidebar from "./MobileSidebar";

    export default {
        name: "Headline",
        components: {MobileSidebar},
        data() {
            return {
                heads: [
                    {text: 'Home', url: '/'},
                    {text: 'Login', url: '/login'}
                ]
            }
        }
    }
</script>

<style scoped>
    nav {
        margin-top: 0;
        background-color: #3661d1;
    }

    .brand-logo {
        position: relative;
    }

    li {
        margin-left: 15px;
    }
</style>