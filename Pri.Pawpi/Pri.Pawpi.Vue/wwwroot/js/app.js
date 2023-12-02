let practices = new Vue({
    el: '#practices',
        data: {
            pageTitle: 'Practices!',
            practicesVisible: false,
    },



        methods: {
            getPractices: function () {
                this.practicesVisible = !this.practicesVisible;
                }
        }
});