let app = new Vue({
    el: '#app',
        data: {
            pageTitle: '',
            homeVisible: true,
            practicesVisible: false,
            veterinariansVisible: false,
            customersVisible: false,
            petsVisible: false,
            consultationsVisible: false,
            specialtiesVisible: false,
            medicationsVisible: false,
            isLoading: false,

            baseUrl: 'https://localhost:7031/api',

            practices: null,
    },

        

    methods: {
        setNav: function (navItem) {
            this.homeVisible = false;
            this.practicesVisible = false;
            this.veterinariansVisible = false;
            this.customersVisible = false;
            this.petsVisible = false;
            this.consultationsVisible = false;
            this.specialtiesVisible = false;
            this.medicationsVisible = false;

            switch (navItem) {
                case 'Practices':
                    this.practicesVisible = true;
                    break;
                case 'Veterinarians':
                    this.veterinariansVisible = true;
                    break;
                case 'Customers':
                    this.customersVisible = true;
                    break;
                case 'Pets':
                    this.petsVisible = true;
                    break;
                case 'Consultations':
                    this.consultationsVisible = true;
                    break;
                case 'Specialities':
                    this.specialtiesVisible = true;
                    break;
                case 'Medications':
                    this.medicationsVisible = true;
                    break;
                default:
                    this.homeVisible = true;
                    break;
            }
        },

        setHome: function () {
            this.setNav('');
            this.pageTitle = 'Home';
        },

        getPractices: async function () {
            this.setNav('Practices');
            this.pageTitle = 'Practices';

            isLoading = true;

            const practicesUrl = `${this.baseUrl}/Practice`;
            this.practices = await axios.get(practicesUrl)
                .then(response => response.data.practices)
                .catch(error => console.log(error))
                .finally(() => { this.isLoading = false; });

            console.log(this.practices);
        },
    },

    filters: {
        formatTime(value) {
            return value.substring(11,16);
        }
    }
});