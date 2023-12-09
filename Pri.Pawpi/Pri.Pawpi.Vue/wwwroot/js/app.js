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
            logoUrl: "",
            veterinarianIds: [],
            customerIds: []
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
            veterinarianIds: [],
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

        //#region General functions
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

        //#endregion General functions

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
        addPractice: async function () {
            const headers = this.getHeaders();

            const url = `${this.baseUrl}/Practice`;

            const newPractice = await axios.post(url, this.practice, headers)
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
                            this.errorMessage = 'Please provide a valid time.';
                        }
                        else if (this.errorMessage.includes('veterinarianid')) {
                            this.errorMessage = 'Please select a valid veterinarian.';
                        }
                    }
                });

            if (newPractice !== undefined) {
                this.hideAddPracticeForm();
                this.success = true;
                this.errorMessage = 'Practice added successfully.';
                
            }
        },

        showAddPracticeForm: function () {
            const url = `${this.baseUrl}/Veterinarian`;
            this.getVeterinarians(url);
            $('#addPracticeForm').modal('show');
        },

        hideAddPracticeForm: function () {
            this.getAllPractices();
            $('#addPracticeForm').modal('hide');
        },

        getPractices: async function (url) {
            this.resetParameters();
            const headers = this.getHeaders();

            this.practices = await axios.get(url)
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

        getAllPractices: async function () {
            this.setNav('Practices');
            const practicesUrl = `${this.baseUrl}/Practice`;

            await this.getPractices(practicesUrl);
        },

        getPracticeCustomers: async function () {
            this.setNav('Customers');

            const practiceId = sessionStorage.getItem('id');
            const customersUrl = `${this.baseUrl}/Practice/${practiceId}/Customers`;

            await this.getCustomers(customersUrl);
        },

        getPracticeVets: async function () {
            this.setNav('Veterinarians');

            const practiceId = sessionStorage.getItem('id');
            const vetsUrl = `${this.baseUrl}/Practice/${practiceId}/Veterinarians`;

            await this.getVeterinarians(vetsUrl);
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
            let searchUrl =  '';

            if (this.searchName.length === 0) {
                if (this.searchAddress.length !== 0) {
                    this.searchPracticeByAddress();
                }
                else {
                    searchUrl = `${this.baseUrl}/Practice`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Practice/searchName/${this.searchName}`;  
            }
            await this.getPractices(searchUrl);
        },

        searchPracticeByAddress: async function () {
            let searchUrl = '';

            if (this.searchAddress.length === 0) {
                if (this.searchName.length !== 0) {
                    this.searchPracticeByName();
                }
                else {
                    searchUrl = `${this.baseUrl}/Practice`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Practice/searchAddress/${this.searchAddress}`;
                
            }
            await this.getPractices(searchUrl);
        },


        //#endregion Practices

        //#region Veterinarians
        getVeterinarians: async function (url) {
            this.resetParameters();
            const headers = this.getHeaders();

            this.veterinarians = await axios.get(url, headers)
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

        getAllVeterinarians: async function () {
            this.setNav('Veterinarians');
            const veterinariansUrl = `${this.baseUrl}/Veterinarian`;

            await this.getVeterinarians(veterinariansUrl);
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
            let searchUrl = '';

            if (this.searchName.length === 0) {
                searchUrl = `${this.baseUrl}/Veterinarian`;
            }
            else {
                searchUrl = `${this.baseUrl}/Veterinarian/searchName/${this.searchName}`;
            }
            await this.getVeterinarians(searchUrl);
        },

        getVetConsultations: async function () {
            this.setNav('Consultations');

            const vetId = sessionStorage.getItem('id');
            const consultationsUrl = `${this.baseUrl}/Veterinarian/${vetId}/Consultations`;

            await this.getConsultations(consultationsUrl);
        },

        getVetSpecialties: async function () {
            this.setNav('Specialties');

            const vetId = sessionStorage.getItem('id');
            const specialtiesUrl = `${this.baseUrl}/Veterinarian/${vetId}/Specialties`;
            await this.getSpecialties(specialtiesUrl);
        },

        getVetPractices: async function () {
            this.setNav('Practices');

            const vetId = sessionStorage.getItem('id');
            const practiceUrl = `${this.baseUrl}/Veterinarian/${vetId}/Practices`;

            await this.getPractices(practiceUrl);
        },


        //#endregion Veterinarians

        //#region Specialty
        addSpecialty: async function () {
            this.resetParameters();
            const headers = this.getHeaders();

            const url = `${this.baseUrl}/Specialty`;

            const newSpecialty = await axios.post(url, this.specialty, headers)
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
                    }
                });

            if (newSpecialty !== undefined) {
                this.hideSpecialtyForm();
                this.success = true;
                this.errorMessage = 'Specialty added successfully.';
            }
        },
        showSpecialtyForm: function () {
            const url = `${this.baseUrl}/Veterinarian`;
            this.getVeterinarians(url);
            $('#addSpecialtyForm').modal('show');
        },

        hideSpecialtyForm: function () {
            this.getAllSpecialties();
            $('#addSpecialtyForm').modal('hide');
        },

        getSpecialties: async function (url) {
            this.resetParameters();

            const headers = this.getHeaders();

            this.specialties = await axios.get(url, headers)
                .then(response => response.data.specialties)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.specialties);
        },

        getAllSpecialties: async function () {
            this.setNav('Specialties');
            const specialtiesUrl = `${this.baseUrl}/Specialty`;

            await this.getSpecialties(specialtiesUrl);
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
            this.getVeterinarians(specialtyVetUrl);
            $('#specialtyInfo').modal('show');
        },

        hideSpecialtyInfo: function () {
            $('#specialtyInfo').modal('hide');
        },

        searchSpecialtyByName: async function () {
            let searchurl = '';

            if (this.searchName.length === 0) {
                searchUrl = `${this.baseUrl}/Specialty`;
            }
            else {
                searchUrl = `${this.baseUrl}/Specialty/searchName/${this.searchName}`;
            }
            await this.getSpecialties(searchUrl);
        },
        //#endregion Specialty

        //#region Pet
        getPets: async function (url) {
            this.resetParameters();

            const headers = this.getHeaders();
            this.pets = await axios.get(url, headers)
                .then(response => response.data.pets)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.pets);
        },

        getAllPets: async function () {
            if (sessionStorage.getItem('role') === 'Customer') {
                await this.getCustomerPets();
            }
            else {
                this.setNav('Pets');
                const petsUrl = `${this.baseUrl}/Pet`;

                await this.getPets(petsUrl);
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
            let searchUrl = '';

            if (this.searchName.length === 0) {
                if (this.searchBreed.length !== 0) {
                    this.searchPetByBreed();
                }
                else if (this.searchAnimalType.length !== 0) {
                    this.searchAnimalType();
                }
                else {
                    searchUrl = `${this.baseUrl}/Pet`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Pet/searchName/${this.searchName}`;
            }

            await this.getPets(searchUrl);
        },

        searchPetByBreed: async function () {
            let searchUrl = '';

            if (this.searchBreed.length === 0) {
                if (this.searchName.length !== 0) {
                    this.searchPetByName();
                }
                else if (this.searchAnimalTypec) {
                    this.searchAnimalType();
                }
                else {
                    searchUrl = `${this.baseUrl}/Pet`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Pet/searchBreed/${this.searchBreed}`;
            }

            await this.getPets(searchUrl);
        },

        searchPetByAnimalType: async function () {
            let searchUrl = '';

            if (this.searchAnimalType.length === 0) {
                if (this.searchNamelength !== 0) {
                    this.searchPetByName();
                }
                else if (this.searchBreedlength !== 0) {
                    this.searchAnimalType();
                }
                else {
                    searchUrl = `${this.baseUrl}/Pet`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Pet/searchAnimalType/${this.searchAnimalType}`;
            }

            await this.getPets(searchUrl);
        },

        //#endregion Pet

        //#region Customer
        getCustomers: async function (url) {
            this.resetParameters();

            const headers = this.getHeaders();
            this.customers = await axios.get(url, headers)
                .then(response => response.data.customers)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.customers);
        },

        getAllCustomers: async function () {
            this.setNav('Customers');
            const customersUrl = `${this.baseUrl}/Customer`;

            await this.getCustomers(customersUrl);
        },

        getCustomerPets: async function () {
            this.setNav('Pets');

            const customerId = sessionStorage.getItem('id');
            const petsUrl = `${this.baseUrl}/Customer/${customerId}/Pets`;

            await this.getPets(petsUrl);
        },

        searchCustomerByName: async function () {
            let searchUrl = '';

            if (this.searchName.length === 0) {
                if (this.searchAddress.length !== 0) {
                    this.searchCustomerByAddress();
                }
                else {
                    searchUrl = `${this.baseUrl}/Customer`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Customer/searchName/${this.searchName}`;
            }
            await this.getCustomers(searchUrl);
        },

        searchCustomerByAddress: async function () {
            let searchUrl = '';

            if (this.searchAddress.length === 0) {
                if (this.searchName.length !== 0) {
                    this.searchCustomerByName();
                }
                else {
                    searchUrl = `${this.baseUrl}/Customer`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Customer/searchAddress/${this.searchAddress}`;

            }
            await this.getCustomers(searchUrl);
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
        getMedicine: async function (url) {
            this.resetParameters();
            const headers = this.getHeaders();

            this.medicine = await axios.get(url, headers)
                .then(response => response.data.medicine)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.medicine);
        },

        getAllMedicine: async function () {
            this.setNav('Medicine');
            const medicineUrl = `${this.baseUrl}/Medication`;

            await this.getMedicine(medicineUrl);
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
            let searchUrl = '';

            if (this.searchName.length === 0) {
                if (this.searchSideEffect.length !== 0) {
                    this.searchMedicationBySideEffect();
                }
                else {
                    searchUrl = `${this.baseUrl}/Medication`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Medication/searchName/${this.searchName}`;
            }
            await this.getMedicine(searchUrl);
        },

        searchMedicationBySideEffect: async function () {
            let searchUrl = '';

            if (this.searchSideEffect.length === 0) {
                if (this.searchName.length !== 0) {
                    this.searchMedicationByName();
                }
                else {
                    searchUrl = `${this.baseUrl}/Medication`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Medication/searchSideEffect/${this.searchSideEffect}`;

            }
            await this.getMedicine(searchUrl);
        },

        //#endregion Medication

        //#region Consultation
        getConsultations: async function (url) {
            this.resetParameters();

            const headers = this.getHeaders();
            this.consultations = await axios.get(url, headers)
                .then(response => response.data.consultations)
                .catch(error => {
                    this.hasError = true;
                    this.errorMessage = error.message;
                })
                .finally(() => { this.loading = false; });

            this.checkSearchResults(this.consultations);
        },

        getAllConsultations: async function () {
            this.setNav('Consultations');
            const consultationsUrl = `${this.baseUrl}/Consultation`;

            await this.getConsultations(consultationsUrl);
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
            let searchUrl = '';

            if (this.searchName.length === 0) {
                if (this.searchDiagnose.length !== 0) {
                    this.searchConsultationByDiagnose();
                }
                else {
                    searchUrl = `${this.baseUrl}/Consultation`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Consultation/searchTitle/${this.searchName}`;
            }
            await this.getConsultations(searchUrl);
        },

        searchConsultationByDiagnose: async function () {
            let searchUrl = '';

            if (this.searchDiagnose.length === 0) {
                if (this.searchName.length !== 0) {
                    this.searchConsultationByName();
                }
                else {
                    searchUrl = `${this.baseUrl}/Consultation`;
                }
            }
            else {
                searchUrl = `${this.baseUrl}/Consultation/searchDiagnose/${this.searchDiagnose}`;

            }
            await this.getConsultations(searchUrl);
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