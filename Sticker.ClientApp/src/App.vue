<template>
    <div id="app">
        <Headline/>
        <div class="main-container">
            <router-view/>
        </div>
    </div>
</template>

<script>
    import Headline from "@/components/Headline";

    export default {
        name: 'App',
        components: {
            Headline,
        }
    }
</script>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
    }

    .main-container {
        max-width: 80%;
        margin-left: 10%;
        margin-right: 10%;
        text-align: center;
    }
</style>
