<template>
    <div>
        <div id="search-bar">
            <input type="text" v-model.trim="searchKeyword" @input="autoSearch" placeholder="输入搜索内容"
                   autocomplete="off" autocapitalize="off">
        </div>
        <ul>
            <li v-for="item in result" :key="item">{{item}}</li>
        </ul>
    </div>
</template>

<script>
    //import axios from "axios";

    export default {
        name: 'Home',
        data() {
            return {
                searchKeyword: '',
                result: []
            }
        },
        methods: {
            clearTimer() {
                if (this.timer) {
                    clearTimeout(this.timer)
                }
            },
            autoSearch(event) {
                this.clearTimer()
                console.log(event.timeStamp)
                this.timer = setTimeout(() => {
                    console.log(event.timeStamp)
                    /*
                    axios.get('https://www.runoob.com/try/ajax/json_demo.json')
                        .then(response => (console.log(response)))
                        .catch(
                            function (error) {
                                console.log('error!' + error)
                            }
                        )
                        */
                    this.changeResult()
                }, 1000)
            },
            changeResult() {
                this.result = []
                this.result = this.searchKeyword.split(' ')
            }
        }
    }
</script>

<style scoped>
    #search-bar {
        margin-top: 30px;
    }
</style>