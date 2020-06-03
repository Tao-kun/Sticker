<template>
    <ul class="sidenav" id="slide-out">
        <li v-for="head in heads" :key="head" class="sidenav-close">
            <router-link :to=head.url>{{head.text}}</router-link>
        </li>
    </ul>
</template>

<script>
    import M from "materialize-css";

    export default {
        name: "MobileSidebar",
        mounted() {
            M.AutoInit()
        },
        props: ['heads']
    }
</script>

<style scoped>

</style>