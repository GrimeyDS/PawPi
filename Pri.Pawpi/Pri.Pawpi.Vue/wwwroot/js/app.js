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
        loading: false,
        hasError: false,
        errorMessage: '',

        baseUrl: 'https://localhost:7031/api',

        searchName: '',
        searchAddress: '',
        searchResults: false,

        practices: null,
        practice: {
            name: '',
            address: '',
            city: '',
            email: '',
            phone: '',
            postal: '',
            openTime: '',
            closeTime: '',
            logoUrl: null,
            veterinarians: []
        },

        veterinarians: null,
        veterinarian: {
            firstName: '',
            lastName: '',
            birth: '',
            address: '',
            city: '',
            email: '',
            phone: '',
            postal: '',
            imageUrl: null,
            practices: [],
            specialties: []
        },

        specialties: null,
        specialty: {
            name: '',
            description: '',
            veterinarians: [],
        },
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

            this.pageTitle = navItem;

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
                case 'Specialties':
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

        resetParameters: function () {
            this.hasError = false;
            this.loading = true;
            this.searchResults = true;
        },

        checkSearchResults: function (results) {
            if (results.length < 1)
                this.searchResults = false;
        },

        //#region Practices
        getPractices: async function () {
            this.setNav('Practices');
            this.resetParameters();

            const practicesUrl = `${this.baseUrl}/Practice`;
            this.practices = await axios.get(practicesUrl)
                .then(response => response.data.practices)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.practices);
        },

        showPracticeInfo: async function (id) {
            this.resetParameters();

            const practiceUrl = `${this.baseUrl}/Practice/${id}`;
            this.practice = await axios.get(practiceUrl)
                .then(response => response.data)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });
            $('#practiceInfo').modal('show');
        },

        hidePracticeInfo: function () {
            $('#practiceInfo').modal('hide');
        },

        searchPracticeByName: async function () {
            this.resetParameters();

            if (this.searchName == null || this.searchName == '') {
                if (this.searchAddress == null || this.searchAddress == '') {
                    this.getPractices();
                }
                else {
                    this.searchPracticeByAddress();
                }
            }

            const searchUrl = `${this.baseUrl}/Practice/searchName/${this.searchName}`;
            this.practices = await axios.get(searchUrl)
                .then(response => response.data.practices)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }      
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.practices);
        },

        searchPracticeByAddress: async function () {
            this.resetParameters();

            if (this.searchAddress == null || this.searchAddress == '') {
                if (this.searchName == null || this.searchName == '') {
                    this.getPractices();
                }
                else {
                    this.searchPracticeByName();
                }
            }

            const searchUrl = `${this.baseUrl}/Practice/searchAddress/${this.searchAddress}`;
            this.practices = await axios.get(searchUrl)
                .then(response => response.data.practices)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }      
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.practices);
        },
        //#endregion Practices

        //#region Veterinarians
        getVeterinarians: async function () {
            this.setNav('Veterinarians');
            this.resetParameters();

            const veterinariansUrl = `${this.baseUrl}/Veterinarian`;
            this.veterinarians = await axios.get(veterinariansUrl)
                .then(response => response.data.veterinarians)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.veterinarians);
        },

        showVeterinarianInfo: async function (id) {
            this.resetParameters();

            const vetUrl = `${this.baseUrl}/Veterinarian/${id}`;
            this.veterinarian = await axios.get(vetUrl)
                .then(response => response.data)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });
            $('#veterinarianInfo').modal('show');
        },

        hideVeterinarianInfo: function () {
            $('#veterinarianInfo').modal('hide');
        },

        searchVeterinarianByName: async function () {
            this.resetParameters();

            if (this.searchName == null || this.searchName == '') {
                this.getVeterinarians();
            }

            const searchUrl = `${this.baseUrl}/Veterinarian/searchName/${this.searchName}`;
            this.veterinarians = await axios.get(searchUrl)
                .then(response => response.data.veterinarians)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }      
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.veterinarians);
        },

        //#endregion Veterinarians

        //#region Specialty
        getSpecialties: async function () {
            this.setNav('Specialties');
            this.resetParameters();

            const specialtiesUrl = `${this.baseUrl}/Specialty`;
            this.specialties = await axios.get(specialtiesUrl)
                .then(response => response.data.specialties)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.specialties);
        },

        showSpecialtyInfo: async function (id) {
            this.resetParameters();

            const specialtyUrl = `${this.baseUrl}/Specialty/${id}`;
            this.specialty = await axios.get(specialtyUrl)
                .then(response => response.data)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })

            const specialtyVetUrl = `${this.baseUrl}/Specialty/${id}/Veterinarians`;
            this.veterinarians = await axios.get(specialtyVetUrl)
                .then(response => response.data.veterinarians)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });
            $('#specialtyInfo').modal('show');
        },

        hideSpecialtyInfo: function () {
            $('#specialtyInfo').modal('hide');
        },

        searchSpecialtyByName: async function () {
            this.resetParameters();

            if (this.searchName == null || this.searchName == '') {
                this.getSpecialties();
            }

            const searchUrl = `${this.baseUrl}/Specialty/searchName/${this.searchName}`;
            this.specialties = await axios.get(searchUrl)
                .then(response => response.data.specialties)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }           
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.specialties);
        },
        //#endregion Specialty


    },

    filters: {
        formatTime(value) {
            if (value == null)
                return value;
            return value.substring(11,16);
        },

        formatDate(value) {
            if (value == null)
                return value;
            return value.substring(0, 10);
        }
    }
});