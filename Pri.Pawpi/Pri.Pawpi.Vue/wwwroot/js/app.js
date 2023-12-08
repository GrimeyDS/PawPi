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
        isLoggedIn: false,
        loginVisible: false,
        isVet: false,
        isPractice: false,
        isCustomer: false,

        loginDto: {
            username: '',
            password: ''
        },

        registerCustomerDto: {
            firstName: '',
            lastName: '',
            birth: '',
            address: '',
            city: '',
            email: '',
            phone: '',
            postal: '',
            petIds: [],
            practiceId: [],
            password: '',
            repeatPassword: ''
        },

        registerVetDto: {
            firstName: '',
            lastName: '',
            birth: '',
            address: '',
            city: '',
            email: '',
            phone: '',
            postal: '',
            consultationIds: [],
            specialtyIds: [],
            practiceIds: [],
            image: null,
            password: '',
            repeatPassword: ''
        },

        loading: false,
        hasError: false,
        success: false,
        hasInputError: false,
        errorMessage: '',

        baseUrl: 'https://localhost:7031/api',

        searchName: '',
        searchAddress: '',
        searchBreed: '',
        searchAnimalType: '',
        searchSideEffect: '',
        searchDiagnose: '',
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

        pets: null,
        pet: {
            name: '',
            callName: '',
            breed: '',
            color: '',
            animalType: '',
            weight: '',
            imageUrl: null,
            pedigreeUrl: null,
            customer: null,
            lastConsultation: null
        },

        customers: null,
        customer: {
            firstName: '',
            lastName: '',
            birth: '',
            address: '',
            city: '',
            email: '',
            phone: '',
            postal: '',
            pets: [],
            practice: null
        },

        consultations: null,
        consultation: {
            title: '',
            diagnosis: '',
            dateOfConsultation: '',
            treatment: '',
            notes: '',
            veterinarianName: '',
            petName: '',
            imageUrl: null,
            documentUrl: null
        },

        medicine: null,
        medication: {
            name: '',
            notes: '',
            sideEffects: '',
            pets: []
        },
    },

    created: function () {
        if (sessionStorage.getItem('token') !== null) {
            this.isLoggedIn = true;
        }
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
                case 'Medicine':
                    this.medicationsVisible = true;
                    break;
                default:
                    this.homeVisible = true;
                    break;
            }
        },

        setHome: function () {
            this.setNav('');
            this.hasError = false;
            this.loading = false;
        },

        resetParameters: function () {
            this.hasError = false;
            this.hasInputError = false;
            this.loading = true;
            this.searchResults = true;
            this.errorMessage = '';
            this.success = false;
        },

        checkSearchResults: function (results) {
            if (results.length < 1)
                this.searchResults = false;
        },



        //#region Identity
        login: async function () {
            this.resetParameters();

            const loginUrl = `${this.baseUrl}/Account/Login`;
            const token = await axios.post(loginUrl, this.loginDto)
                .then(response => response.data.token)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = "Please provide a correct username and password.";
                });

            if (token !== undefined) {
                sessionStorage.setItem('token', token);
                const headers = this.getHeaders();

                const userRole = await axios.get(`${this.baseUrl}/Account/GetRole`, headers).then(response => response.data).catch(error => { this.hasError = true; this.errorMessage = "Role not found" });
                const userId = await axios.get(`${this.baseUrl}/Account/GetId`, headers).then(response => response.data).catch(error => { this.hasError = true; this.errorMessage = "Id not found" });
                sessionStorage.setItem('role', userRole);
                sessionStorage.setItem('id', userId);

                if (userRole === 'Admin') {
                    this.isPractice = true;
                    this.isVet = true;
                    this.isCustomer = true;
                }
                else if (userRole === 'Veterinarian') {
                    this.isVet = true;
                }
                else if (userRole === 'Practice') {
                    this.isPractice = true;
                }
                else {
                    this.isCustomer = true;
                }

                this.isLoggedIn = true;
                this.loginVisible = false;

                this.loginDto.username = '';
                this.loginDto.password = '';
            }
            

            this.loading = false;
        },

        logout: function () {
            sessionStorage.removeItem('token');
            sessionStorage.removeItem('id');
            sessionStorage.removeItem('role');
            this.isLoggedIn = false;
            this.isVet = false;
            this.isPractice = false;
            this.isCustomer = false;
            this.setHome();
        },

        registration: async function (url, dto) {
            const headers = this.getHeaders();

            const token = await axios.post(url, dto, headers)
                    .then(response => response.data)
                    .catch(error => {
                        this.hasInputError = true;
                        const errors = error.response.data.errors;
                        if (errors === undefined) {
                            this.errorMessage = error.response.data[0].description;
                        }
                        else {
                            for (const [key, value] of Object.entries(errors)) {
                                this.errorMessage += `${key}: ${value} \n`;
                            }

                            if (this.errorMessage.includes('System.DateTime')) {
                                this.errorMessage = 'Please provide a valid date of birth in the past.';
                            }
                            else if (this.errorMessage.includes('practiceId')) {
                                this.errorMessage = 'Please select a practice.';
                            }
                        }
                    });

            if (token !== undefined) {
                this.hideRegisterForm();
                this.success = true;
                this.errorMessage = 'Registration successful! Please login.';
                this.setHome();
            }
        },

        registerCustomer: async function () {
            this.resetParameters();

            const registerUrl = `${this.baseUrl}/Account/RegisterCustomer`;
            await this.registration(registerUrl, this.registerCustomerDto);
        },

        registerVeterinarian: async function () {
            this.resetParameters();

            const registerUrl = `${this.baseUrl}/Account/RegisterVeterinarian`;
            await this.registration(registerUrl, this.registerVetDto);
        },

        getHeaders: function () {
            const headers = {
                'headers': {
                    'Authorization': `Bearer ${sessionStorage.getItem('token')}`
                }
            };
            return headers;
        },

        showRegisterForm: async function () {
            this.resetParameters();
            this.loading = true;

            const practicesUrl = `${this.baseUrl}/Practice`;
            this.practices = await axios.get(practicesUrl)
                .then(response => response.data.practices)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            if (this.isPractice) {
                const specialtiesUrl = `${this.baseUrl}/Specialty`;
                this.specialties = await axios.get(specialtiesUrl)
                    .then(response => response.data.specialties)
                    .catch(error => {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    })
                    .finally(() => { this.loading = false; });

                $('#registerVetForm').modal('show');
            }
            else {
                $('#registerCustomerForm').modal('show');
            }

        },

        hideRegisterForm: function () {
            this.hasError = false;
            this.errorMessage = '';
            this.loading = false;
            if (this.isPractice) {
                $('#registerVetForm').modal('hide');
            }
            else {
                $('#registerCustomerForm').modal('hide');
            }
        },

        getProfile: function () {
            const role = sessionStorage.getItem('role');
            const id = sessionStorage.getItem('id');

            if (role === 'Customer') {
                this.showCustomerInfo(id);
            }
            else if (role == 'Veterinarian') {
                this.showVeterinarianInfo(id);
            }
            else if (role == 'Practice') {
                this.showPracticeInfo(id);
            }
            else {
                this.hasError = true;
                this.errorMessage = role;
            }
        },

        //#endregion Identity

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

        getPracticeCustomers: async function () {
            this.setNav('Customers');
            this.resetParameters();

            const practiceId = sessionStorage.getItem('id');
            const headers = this.getHeaders();

            const customersUrl = `${this.baseUrl}/Practice/${practiceId}/Customers`;
            this.customers = await axios.get(customersUrl, headers)
                .then(response => response.data.customers)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.response.data;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.customers);
        },

        getPracticeVets: async function () {
            this.setNav('Veterinarians');
            this.resetParameters();

            const practiceId = sessionStorage.getItem('id');
            const headers = this.getHeaders();

            const vetsUrl = `${this.baseUrl}/Practice/${practiceId}/Veterinarians`;
            this.veterinarians = await axios.get(vetsUrl, headers)
                .then(response => response.data.veterinarians)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.response.data;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.veterinarians);
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

        getVetConsultations: async function () {
            this.setNav('Consultations');
            this.resetParameters();

            const vetId = sessionStorage.getItem('id');
            const headers = this.getHeaders();

            const consultationsUrl = `${this.baseUrl}/Veterinarian/${vetId}/Consultations`;
            this.consultations = await axios.get(consultationsUrl, headers)
                .then(response => response.data.consultations)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.response.data;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.consultations);
        },

        getVetSpecialties: async function () {
            this.setNav('Specialties');
            this.resetParameters();

            const vetId = sessionStorage.getItem('id');
            const headers = this.getHeaders();

            const specialtiesUrl = `${this.baseUrl}/Veterinarian/${vetId}/Specialties`;
            this.specialties = await axios.get(specialtiesUrl, headers)
                .then(response => response.data.specialties)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.response.data;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.specialties);
        },

        getVetPractices: async function () {
            this.setNav('Practices');
            this.resetParameters();

            const vetId = sessionStorage.getItem('id');
            const headers = this.getHeaders();

            const practiceUrl = `${this.baseUrl}/Veterinarian/${vetId}/Practices`;
            this.practices = await axios.get(practiceUrl, headers)
                .then(response => response.data.practices)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.response.data;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.practices);
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

        //#region Pet
        getPets: async function () {
            if (sessionStorage.getItem('role') === 'Customer') {
                this.getCustomerPets();
            }
            else {
                this.setNav('Pets');
                this.resetParameters();

                const headers = this.getHeaders();
                const petsUrl = `${this.baseUrl}/Pet`;
                this.pets = await axios.get(petsUrl, headers)
                    .then(response => response.data.pets)
                    .catch(error => {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    })
                    .finally(() => { this.loading = false; });

                this.checkSearchResults(this.pets);
            }
        },

        showPetInfo: async function (id) {
            this.resetParameters();

            const headers = this.getHeaders();
            const petUrl = `${this.baseUrl}/Pet/${id}`;
            this.pet = await axios.get(petUrl, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.customer = this.pet.customer;
            this.consultation = this.pet.lastConsultation;
            $('#petInfo').modal('show');
        },

        hidePetInfo: function () {
            $('#petInfo').modal('hide');
        },

        searchPetByName: async function () {
            this.resetParameters();

            if (this.searchName.length === 0) {
                if (this.searchBreed.length !== 0 ) {
                    this.searchPetByBreed();
                }
                else if (this.searchAnimalType.length !== 0) {
                    this.searchAnimalType();
                }
                else {
                    this.getPets();
                }
            }

            const headers = this.getHeaders();
            const searchUrl = `${this.baseUrl}/Pet/searchName/${this.searchName}`;
            this.pets = await axios.get(searchUrl, headers)
                .then(response => response.data.pets)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.pets);
        },

        searchPetByBreed: async function () {
            this.resetParameters();

            if (this.searchBreed.length === 0) {
                if (this.searchName.length !== 0) {
                    this.searchPetByName();
                }
                else if (this.searchAnimalTypec) {
                    this.searchAnimalType();
                }
                else {
                    this.getPets();
                }
            }

            const headers = this.getHeaders();
            const searchUrl = `${this.baseUrl}/Pet/searchBreed/${this.searchBreed}`;
            this.pets = await axios.get(searchUrl, headers)
                .then(response => response.data.pets)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.pets);
        },

        searchPetByAnimalType: async function () {
            this.resetParameters();

            if (this.searchAnimalType.length === 0) {
                if (this.searchNamelength !== 0) {
                    this.searchPetByName();
                }
                else if (this.searchBreedlength !== 0) {
                    this.searchAnimalType();
                }
                else {
                    this.getPets();
                }
            }

            const headers = this.getHeaders();
            const searchUrl = `${this.baseUrl}/Pet/searchAnimalType/${this.searchAnimalType}`;
            this.pets = await axios.get(searchUrl, headers)
                .then(response => response.data.pets)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.pets);
        },

        //#endregion Pet

        //#region Customer
        getCustomers: async function () {
            this.setNav('Customers');
            this.resetParameters();

            const headers = this.getHeaders();
            const customersUrl = `${this.baseUrl}/Customer`;
            this.customers = await axios.get(customersUrl, headers)
                .then(response => response.data.customers)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.customers);
        },

        getCustomerPets: async function () {
            this.setNav('Pets');
            this.resetParameters();

            const customerId = sessionStorage.getItem('id');
            const headers = this.getHeaders();

            const petsUrl = `${this.baseUrl}/Customer/${customerId}/Pets`;
            this.pets = await axios.get(petsUrl, headers)
                .then(response => response.data.pets)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.response.data;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.pets);
        },

        searchCustomerByName: async function () {
            this.resetParameters();

            if (this.searchName == null || this.searchName == '') {
                if (this.searchAddress == null || this.searchAddress == '') {
                    this.getCustomers();
                }
                else {
                    this.searchCustomerByAddress();
                }
            }

            const headers = this.getHeaders();
            const searchUrl = `${this.baseUrl}/Customer/searchName/${this.searchName}`;
            this.customers = await axios.get(searchUrl, headers)
                .then(response => response.data.customers)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.customers);
        },

        searchCustomerByAddress: async function () {
            this.resetParameters();

            if (this.searchAddress == null || this.searchAddress == '') {
                if (this.searchName == null || this.searchName == '') {
                    this.getCustomers();
                }
                else {
                    this.searchCustomerByName();
                }
            }

            const headers = this.getHeaders();
            const searchUrl = `${this.baseUrl}/Customer/searchAddress/${this.searchAddress}`;
            this.customers = await axios.get(searchUrl, headers)
                .then(response => response.data.customers)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.customers);
        },

        showCustomerInfo: async function (id) {
            this.resetParameters();

            const headers = this.getHeaders();

            const customerUrl = `${this.baseUrl}/Customer/${id}`;
            this.customer = await axios.get(customerUrl, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.practice = this.customer.practice;
            $('#customerInfo').modal('show');
        },

        hideCustomerInfo: function () {
            $('#customerInfo').modal('hide');
        },

        //#endregion Customer

        //#region Medication
        getMedicine: async function () {
            this.setNav('Medicine');
            this.resetParameters();

            const headers = this.getHeaders();

            const medicineUrl = `${this.baseUrl}/Medication`;
            this.medicine = await axios.get(medicineUrl, headers)
                .then(response => response.data.medicine)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.medicine);
        },

        showMedicationInfo: async function (id) {
            this.resetParameters();

            const headers = this.getHeaders();
            const medicationUrl = `${this.baseUrl}/Medication/${id}`;
            this.medication = await axios.get(medicationUrl, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });
            $('#medicationInfo').modal('show');
        },

        hideMedicationInfo: function () {
            $('#medicationInfo').modal('hide');
        },

        searchMedicationByName: async function () {
            this.resetParameters();

            if (this.searchName == null || this.searchName == '') {
                if (this.searchSideEffect == null || this.searchSideEffect == '') {
                    this.getMedicine();
                }
                else {
                    this.searchMedicationBySideEffect();
                }
            }

            const headers = this.getHeaders();
            const searchUrl = `${this.baseUrl}/Medication/searchName/${this.searchName}`;
            this.medicine = await axios.get(searchUrl, headers)
                .then(response => response.data.medicine)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.medicine);
        },

        searchMedicationBySideEffect: async function () {
            this.resetParameters();

            if (this.searchSideEffect == null || this.searchSideEffect == '') {
                if (this.searchName == null || this.searchName == '') {
                    this.getMedicine();
                }
                else {
                    this.searchMedicationByName();
                }
            }

            const headers = this.getHeaders();
            const searchUrl = `${this.baseUrl}/Medication/searchSideEffect/${this.searchSideEffect}`;
            this.medicine = await axios.get(searchUrl, headers)
                .then(response => response.data.medicine)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.medicine);
        },

        //#endregion Medication

        //#region Consultation
        getConsultations: async function () {
            this.setNav('Consultations');
            this.resetParameters();

            const headers = this.getHeaders();
            const consulationsUrl = `${this.baseUrl}/Consultation`;
            this.consultations = await axios.get(consulationsUrl, headers)
                .then(response => response.data.consultations)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.consultations);
        },

        showConsultationInfo: async function (id) {
            this.resetParameters();

            const headers = this.getHeaders();
            const consultationUrl = `${this.baseUrl}/Consultation/${id}`;
            this.consultation = await axios.get(consultationUrl, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });
            $('#consultationInfo').modal('show');
        },

        hideConsultationInfo: function () {
            $('#consultationInfo').modal('hide');
        },

        searchConsultationByName: async function () {
            this.resetParameters();

            if (this.searchName == null || this.searchName == '') {
                if (this.searchDiagnose == null || this.searchDiagnose == '') {
                    this.getConsultations();
                }
                else {
                    this.searchConsultationByDiagnose();
                }
            }

            const headers = this.getHeaders();
            const searchUrl = `${this.baseUrl}/Consultation/searchTitle/${this.searchName}`;
            this.consultations = await axios.get(searchUrl, headers)
                .then(response => response.data.consultations)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.consultations);
        },

        searchConsultationByDiagnose: async function () {
            this.resetParameters();

            if (this.searchDiagnose == null || this.searchDiagnose == '') {
                if (this.searchName == null || this.searchName == '') {
                    this.getConsultations();
                }
                else {
                    this.searchConsulationByName();
                }
            }

            const headers = this.getHeaders();
            const searchUrl = `${this.baseUrl}/Consultation/searchDiagnose/${this.searchDiagnose}`;
            this.consultations = await axios.get(searchUrl, headers)
                .then(response => response.data.consultations)
                .catch(error => {
                    if (!error.message.includes("405")) {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    }
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.consultations);
        },

        //#endregion Consultation
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