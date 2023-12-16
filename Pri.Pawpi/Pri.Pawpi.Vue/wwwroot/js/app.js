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
        isUpdate: false,
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
            id: '',
            name: '',
            address: '',
            city: '',
            email: '',
            phone: '',
            postal: '',
            openTime: '',
            closeTime: '',
            logoUrl: null,
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
            consultationIds: [],
            specialtyIds: [],
            practiceIds: [],
            specialties: [],
            practices: []
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
            image: null,
            pedigree: null,
            consultationIds: [],
            medicationIds: [],
            customerId: null,
            lastConsultation: null,
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
            petIds: [],
            practiceId: null
        },

        consultations: null,
        consultation: {
            title: '',
            diagnosis: '',
            dateOfConsultation: '',
            treatment: '',
            notes: '',
            image: null,
            document: null,
            veterinarianId: null,
            petId: null
        },

        medicine: null,
        medication: {
            name: '',
            notes: '',
            sideEffects: '',
            dosage: '',
            frequency: '',
            petIds: []
        },
    },

    created: function () {
        if (sessionStorage.getItem('token') !== null) {
            this.isLoggedIn = true;
        }
    },

    methods: {

        handlePracticeFileChange(event) {
            this.practice.logoUrl = event.target.files[0];
        },

        handleVetFileChange(event) {
            this.veterinarian.imageUrl = event.target.files[0];
        },

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

        resetRegisterCustomerDtoObject: function () {
            this.registerCustomerDto.firstName = '';
            this.registerCustomerDto.lastName = '';
            this.registerCustomerDto.birth = '';
            this.registerCustomerDto.address = '';
            this.registerCustomerDto.city = '';
            this.registerCustomerDto.email = '';
            this.registerCustomerDto.phone = '';
            this.registerCustomerDto.postal = '';
            this.registerCustomerDto.petIds = [];
            this.registerCustomerDto.practiceId = null;
            this.registerCustomerDto.password = '';
            this.registerCustomerDto.repeatPassword = '';
        },

        resetRegisterVetDtoObject: function () {
            this.registerVetDto.firstName = '';
            this.registerVetDto.lastName = '';
            this.registerVetDto.birth = '';
            this.registerVetDto.address = '';
            this.registerVetDto.city = '';
            this.registerVetDto.email = '';
            this.registerVetDto.phone = '';
            this.registerVetDto.postal = '';
            this.registerVetDto.consultationIds = [];
            this.registerVetDto.specialtyIds = [];
            this.registerVetDto.practiceIds = [];
            this.registerVetDto.image = null;
            this.registerVetDto.password = '';
            this.registerVetDto.repeatPassword = '';
        },

        resetPracticeObject: function () {
            this.practice.name = '';
            this.practice.address = '';
            this.practice.city = '';
            this.practice.email = '';
            this.practice.phone = '';
            this.practice.postal = '';
            this.practice.openTime = '';
            this.practice.closeTime = '';
            this.practice.logoUrl = null;
            this.practice.veterinarianIds = [];
            this.practice.customerIds = [];
        },

        resetVetObject: function () {
            this.veterinarian.firstName = '';
            this.veterinarian.lastName = '';
            this.veterinarian.birth = '';
            this.veterinarian.address = '';
            this.veterinarian.city = '';
            this.veterinarian.email = '';
            this.veterinarian.phone = '';
            this.veterinarian.postal = '';
            this.veterinarian.imageUrl = null;
            this.veterinarian.consultationIds = [];
            this.veterinarian.specialtyIds = [];
            this.veterinarian.practiceIds = [];
        },

        resetSpecialtyObjects: function () {
            this.specialty.name = '';
            this.specialty.description = '';
            this.specialty.veterinarianIds = [];
        },

        resetPetObject: function () {
            this.pet.name = '';
            this.pet.callName = '';
            this.pet.breed = '';
            this.pet.color = '';
            this.pet.animalType = '';
            this.pet.weight = '';
            this.pet.image = null;
            this.pet.pedigree = null;
            this.pet.consultationIds = [];
            this.pet.medicationIds = [];
            this.pet.customerId = null;
        },

        resetCustomerObject: function () {
            this.customer.firstName = '';
            this.customer.lastName = '';
            this.customer.birth = '';
            this.customer.address = '';
            this.customer.city = '';
            this.customer.email = '';
            this.customer.phone = '';
            this.customer.postal = '';
            this.customer.petIds = [];
            this.customer.practiceId = null;
        },

        resetConsultationObject: function () {
            this.consultation.title = '';
            this.consultation.diagnosis = '';
            this.consultation.dateOfConsultation = '';
            this.consultation.treatment = '';
            this.consultation.notes = '';
            this.consultation.image = null;
            this.consultation.document = null;
            this.consultation.veterinarianId = null;
            this.consultation.petId = null;
        },

        resetMedicationObject: function () {
            this.medication.name = '';
            this.medication.notes = '';
            this.medication.sideEffects = '';
            this.medication.dosage = '';
            this.medication.frequency = '';
            this.medication.petIds = [];
        },

        deleteItem: async function (url) {
            if (confirm('are you sure?')) {
                this.resetParameters();

                const headers = this.getHeaders();

                const deleteItem = await axios.delete(url, headers)
                    .then(response => response.data)
                    .catch(error => {
                        this.hasError = true;
                        this.errorMessage = error.message;
                    })
                    .finally(() => { this.loading = false; });
            }
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
                    if (url.includes('Veterinarian')) {
                        if (this.registerVetDto.practiceIds.length === 0) {
                            this.errorMessage += 'Please select a valid practice. \n';
                        }
                        if (this.registerVetDto.specialtyIds.length === 0) {
                            this.errorMessage += 'Please select a valid specialty. \n';
                        }
                    }
                    if (errors === undefined) {
                        this.errorMessage += error.response.data[0];
                    }
                    else {
                        for (const [key, value] of Object.entries(errors)) {
                            this.errorMessage += `\n ${key}: ${value}`;
                        }
                        if (this.errorMessage.includes('System.DateTime')) {
                            this.errorMessage = 'Please provide a valid birthday.';
                        }
                        if (url.includes('Customer')) {
                            if (this.registerCustomerDto.practiceId == 0) {
                                this.errorMessage = 'Please select a valid practice. \n';
                            }
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

        getFormHeaders: function () {
            const headers = {
                'headers': {
                    'Content-Type': 'multipart/form-data',
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
                this.resetRegisterVetDtoObject();
                $('#registerVetForm').modal('hide');
            }
            else {
                this.resetRegisterCustomerDtoObject();
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
        updatePractice: async function () {
            this.resetParameters();
            const headers = this.getFormHeaders();

            const url = `${this.baseUrl}/Practice`;

            let formData = this.getPracticeFormData();

            const updatedPractice = await axios.put(url, formData, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasInputError = true;
                    const errors = error.response.data.errors;
                    if (this.practice.veterinarianIds.length === 0) {
                        this.errorMessage += 'Please select a valid veterinarian. \n';
                    }
                    if (errors === undefined) {
                        this.errorMessage += error.response.data[0];
                    }
                    else {
                        for (const [key, value] of Object.entries(errors)) {
                            this.errorMessage += `\n ${key}: ${value}`;
                        }
                        if (this.errorMessage.includes('System.DateTime')) {
                            this.errorMessage = 'Please provide a valid time.';
                        }
                    }
                });

            if (updatedPractice !== undefined) {
                await this.getAllPractices();
                this.hideAddPracticeForm();
                this.isUpdate = false;
                this.success = true;
                this.errorMessage = 'Practice updated successfully.';
                this.hidePracticeInfo();
            }
        },

        getPracticeFormData: function () {
            let formData = new FormData();

            formData.append('id', this.practice.id);
            formData.append('name', this.practice.name);
            formData.append('address', this.practice.address);
            formData.append('city', this.practice.city);
            formData.append('email', this.practice.email);
            formData.append('phone', this.practice.phone);
            formData.append('postal', this.practice.postal);
            formData.append('openTime', this.practice.openTime);
            formData.append('closeTime', this.practice.closeTime);
            formData.append('logo', this.practice.logoUrl);
            this.practice.veterinarianIds.forEach(v => { formData.append('veterinarianIds', v); });
            

            return formData;
        },

        showUpdatePracticeForm: async function () {
            this.isUpdate = true;
            this.showAddPracticeForm();
        },

        deletePractice: async function (id) {
            const url = `${this.baseUrl}/Practice/${id}`;
            await this.deleteItem(url);

            if (this.hasError) {
                await this.getAllPractices();
                this.errorMessage = 'Practice not deleted.';
                this.hasError = true;
            }
            else {
                await this.getAllPractices();
                this.success = true;
                this.errorMessage = 'Practice deleted successfully.';
            }

            this.hidePracticeInfo();
        },

        addPractice: async function () {
            this.resetParameters();
            const headers = this.getFormHeaders();

            const url = `${this.baseUrl}/Practice`;

            let formData = this.getPracticeFormData();

            const newPractice = await axios.post(url, formData, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasInputError = true;
                    const errors = error.response.data.errors;
                    if (this.practice.veterinarianIds.length === 0) {
                        this.errorMessage += 'Please select a valid veterinarian. \n';
                    }
                    if (errors === undefined) {
                        this.errorMessage += error.response.data[0];
                    }
                    else {
                        for (const [key, value] of Object.entries(errors)) {
                            this.errorMessage += `\n ${key}: ${value}`;
                        }
                        if (this.errorMessage.includes('System.DateTime')) {
                            this.errorMessage = 'Please provide a valid time.';
                        }
                    }
                });

            if (newPractice !== undefined) {
                await this.getAllPractices();
                this.hideAddPracticeForm();
                this.success = true;
                this.errorMessage = 'Practice added successfully.';
            }
        },

        showAddPracticeForm: async function () {
            const url = `${this.baseUrl}/Veterinarian`;
            await this.getVeterinarians(url);
            $('#addPracticeForm').modal('show');
        },

        hideAddPracticeForm: function () {
            this.hidePracticeInfo();
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
            this.resetPracticeObject();
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
        getVetFormData: function () {
            let formData = new FormData();

            formData.append('id', this.veterinarian.id);
            formData.append('firstName', this.veterinarian.firstName);
            formData.append('lastName', this.veterinarian.lastName);
            formData.append('birth', this.veterinarian.birth);
            formData.append('address', this.veterinarian.address);
            formData.append('city', this.veterinarian.city);
            formData.append('email', this.veterinarian.email);
            formData.append('phone', this.veterinarian.phone);
            formData.append('postal', this.veterinarian.postal);
            formData.append('image', this.veterinarian.imageUrl);

            this.veterinarian.specialties.forEach(s => { formData.append('specialtyIds', s); })
            this.veterinarian.practices.forEach(p => { formData.append('practiceIds', p); })

            return formData;
        },

        updateVeterinarian: async function () {
            this.resetParameters();
            const headers = this.getFormHeaders();

            const url = `${this.baseUrl}/Veterinarian`;

            let formData = this.getVetFormData();

            const updatedVet = await axios.put(url, formData, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasInputError = true;
                    const errors = error.response.data.errors;
                    if (this.veterinarian.practiceIds.length === 0) {
                        this.errorMessage += 'Please select a valid practice. \n';
                    }
                    if (this.veterinarian.specialtyIds.length === 0) {
                        this.errorMessage += 'Please select a valid specialty. \n';
                    }
                    if (errors === undefined) {
                        this.errorMessage += error.response.data[0]
                    }
                    else {
                        for (const [key, value] of Object.entries(errors)) {
                            this.errorMessage += `\n ${key}: ${value}`;
                        }
                        if (this.errorMessage.includes('System.DateTime')) {
                            this.errorMessage = 'Please provide a valid birthday.';
                        }
                    }
                });

            if (updatedVet !== undefined) {
                await this.getAllVeterinarians();
                this.hideVeterinarianForm();
                this.isUpdate = false;
                this.success = true;
                this.errorMessage = 'Veterinarian updated successfully.';
                this.hideVeterinarianInfo();
            }
        },

        showUpdateVeterinarianForm: async function () {
            this.isUpdate = true;
            this.showVeterinarianForm();
        },

        deleteVeterinarian: async function (id) {
            const url = `${this.baseUrl}/Veterinarian/${id}`;
            await this.deleteItem(url);

            if (this.hasError) {
                await this.getAllVeterinarians();
                this.errorMessage = 'Veterinarian not deleted.';
                this.hasError = true;
            }
            else {
                await this.getAllVeterinarians();
                this.success = true;
                this.errorMessage = 'Veterinarian deleted successfully.';
            }

            this.hideVeterinarianInfo();
        },

        addVeterinarian: async function () {
            this.resetParameters();
            const headers = this.getFormHeaders();

            const url = `${this.baseUrl}/Veterinarian`;

            let formData = this.getVetFormData();

            const newVeterinarian = await axios.post(url, formData, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasInputError = true;
                    const errors = error.response.data.errors;
                    if (this.veterinarian.practiceIds.length === 0) {
                        this.errorMessage += 'Please select a valid practice. \n';
                    }
                    if (this.veterinarian.specialtyIds.length === 0) {
                        this.errorMessage += 'Please select a valid specialty. \n';
                    }
                    if (errors === undefined) {
                        this.errorMessage += error.response.data[0]
                    }
                    else {
                        for (const [key, value] of Object.entries(errors)) {
                            this.errorMessage += `\n ${key}: ${value}`;
                        }
                        if (this.errorMessage.includes('System.DateTime')) {
                            this.errorMessage = 'Please provide a valid birthday.';
                        }
                    }
                });

            if (newVeterinarian !== undefined) {
                await this.getAllVeterinarians();
                this.hideVeterinarianForm();
                this.success = true;
                this.errorMessage = 'Veterinarian added successfully.';
            }
        },

        showVeterinarianForm: async function () {
            const specialtyUrl = `${this.baseUrl}/Specialty`;
            const practiceUrl = `${this.baseUrl}/Practice`;
            await this.getSpecialties(specialtyUrl);
            await this.getPractices(practiceUrl);
            $('#addVeterinarianForm').modal('show');
        },

        hideVeterinarianForm: function () {
            this.hideVeterinarianInfo();
            $('#addVeterinarianForm').modal('hide');
        },

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
            this.resetVetObject();
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


        deleteSpecialty: async function (id) {
            const url = `${this.baseUrl}/Specialty/${id}`;
            await this.deleteItem(url);

            if (this.hasError) {
                await this.getAllSpecialties();
                this.errorMessage = 'Specialty not deleted.';
                this.hasError = true;
            }
            else {
                await this.getAllSpecialties();
                this.success = true;
                this.errorMessage = 'Specialty deleted successfully.';
            }

            this.hideSpecialtyInfo();
        },

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
                        this.errorMessage = error.response.data[0];
                    }
                    else {
                        for (const [key, value] of Object.entries(errors)) {
                            this.errorMessage += `${key}: ${value} \n`;
                        }
                    }
                });

            if (newSpecialty !== undefined) {
                await this.getAllSpecialties();
                this.hideSpecialtyForm();
                this.success = true;
                this.errorMessage = 'Specialty added successfully.';
            }
        },

        showSpecialtyForm: async function () {
            const url = `${this.baseUrl}/Veterinarian`;
            await this.getVeterinarians(url);
            $('#addSpecialtyForm').modal('show');
        },

        hideSpecialtyForm: function () {
            this.resetSpecialtyObjects();
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
            this.resetSpecialtyObjects();
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
        deletePet: async function (id) {
            const url = `${this.baseUrl}/Pet/${id}`;
            await this.deleteItem(url);

            if (this.hasError) {
                await this.getAllPets();
                this.errorMessage = 'Pet not deleted.';
                this.hasError = true;
            }
            else {
                await this.getAllPets();
                this.success = true;
                this.errorMessage = 'Pet deleted successfully.';
            }

            this.hidePetInfo();
        },

        addPet: async function () {
            this.resetParameters();
            const headers = this.getHeaders();

            const url = `${this.baseUrl}/Pet`;

            const newPet = await axios.post(url, this.pet, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasInputError = true;
                    const errors = error.response.data.errors;
                    if (errors === undefined) {
                        this.errorMessage = error.response.data[0];
                    }
                    else {
                        for (const [key, value] of Object.entries(errors)) {
                            this.errorMessage += `${key}: ${value} \n`;
                        }
                        if (this.errorMessage.includes('weight')) {
                            this.errorMessage = 'Please provide a valid weight.';
                        }
                        else if (this.errorMessage.includes('customerId')) {
                            this.errorMessage = 'Please select a valid customer.';
                        }
                    }
                });

            if (newPet !== undefined) {
                await this.getAllPets();
                this.hidePetForm();
                this.success = true;
                this.errorMessage = 'Pet added successfully.';
            }
        },

        showPetForm: async function () {
            const customerUrls = `${this.baseUrl}/Customer`;
            await this.getCustomers(customerUrls);
            $('#addPetForm').modal('show');
        },

        hidePetForm: function () {
            this.resetPetObject();
            $('#addPetForm').modal('hide');
        },

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

            if (this.pet.lastConsultation !== null) {
                this.consultation = this.pet.lastConsultation;
            }
            else {
                this.consultation.title = "no consultation yet";
                this.consultation.dateOfConsultation = "";
            }
            
            $('#petInfo').modal('show');
        },

        hidePetInfo: function () {
            this.resetPetObject();
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
        deleteCustomer: async function (id) {
            const url = `${this.baseUrl}/Customer/${id}`;
            await this.deleteItem(url);

            if (this.hasError) {
                await this.getAllCustomers();
                this.errorMessage = 'Customer not deleted.';
                this.hasError = true;
            }
            else {
                await this.getAllCustomers();
                this.success = true;
                this.errorMessage = 'Customer deleted successfully.';
            }

            this.hideCustomerInfo();
        },

        addCustomer: async function () {
            this.resetParameters();
            const headers = this.getHeaders();

            const url = `${this.baseUrl}/Customer`;

            const newCustomer = await axios.post(url, this.customer, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasInputError = true;
                    const errors = error.response.data.errors;
                    if (errors === undefined) {
                        this.errorMessage = error.response.data[0];
                    }
                    else {
                        for (const [key, value] of Object.entries(errors)) {
                            this.errorMessage += `\n${key}: ${value}`;
                        }

                        if (this.errorMessage.includes('System.DateTime')) {
                            this.errorMessage = 'Please provide a valid birthday.';
                        }
                        else if (this.errorMessage.includes('practiceId')) {
                            this.errorMessage = 'Please select a valid practice.';
                        }
                    }
                });

            if (newCustomer !== undefined) {
                await this.getAllCustomers();
                this.hideCustomerForm();
                this.success = true;
                this.errorMessage = 'Customer added successfully.';
            }
        },

        showCustomerForm: async function () {
            const practiceUrl = `${this.baseUrl}/Practice`;
            await this.getPractices(practiceUrl);
            $('#addCustomerForm').modal('show');
        },

        hideCustomerForm: function () {
            this.resetCustomerObject();
            $('#addCustomerForm').modal('hide');
        },

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
            this.resetCustomerObject();
            $('#customerInfo').modal('hide');
        },

        //#endregion Customer

        //#region Medication
        deleteMedication: async function (id) {
            const url = `${this.baseUrl}/Medication/${id}`;
            await this.deleteItem(url);

            if (this.hasError) {
                await this.getAllMedicine();
                this.errorMessage = 'Medication not deleted.';
                this.hasError = true;
            }
            else {
                await this.getAllMedicine();
                this.success = true;
                this.errorMessage = 'Medication deleted successfully.';
            }

            this.hideMedicationInfo();
        },

        addMedication: async function () {
            this.resetParameters();
            const headers = this.getHeaders();

            const url = `${this.baseUrl}/Medication`;

            const newMedication = await axios.post(url, this.medication, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasInputError = true;
                    const errors = error.response.data.errors;
                    if (errors === undefined) {
                        this.errorMessage = error.response.data[0];
                    }
                    else {
                        for (const [key, value] of Object.entries(errors)) {
                            this.errorMessage += `${key}: ${value} \n`;
                        }
                    }
                });

            if (newMedication !== undefined) {
                await this.getAllMedicine();
                this.hideMedicationForm();
                this.success = true;
                this.errorMessage = 'Medication added successfully.';
            }
        },

        showMedicationForm: function () {
            $('#addMedicationForm').modal('show');
        },

        hideMedicationForm: function () {
            this.resetMedicationObject();
            $('#addMedicationForm').modal('hide');
        },

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
            this.resetMedicationObject();
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
        deleteConsultation: async function (id) {
            const url = `${this.baseUrl}/Consultation/${id}`;
            await this.deleteItem(url);

            if (this.hasError) {
                await this.getAllConsultations();
                this.errorMessage = 'Consultation not deleted.';
                this.hasError = true;
            }
            else {
                await this.getAllConsultations();
                this.success = true;
                this.errorMessage = 'Consultation deleted successfully.';
            }

            this.hideConsultationInfo();
        },

        addConsultation: async function () {
            this.resetParameters();
            const headers = this.getHeaders();

            const url = `${this.baseUrl}/Consultation`;

            const newConsultation = await axios.post(url, this.consultation, headers)
                .then(response => response.data)
                .catch(error => {
                    this.hasInputError = true;
                    const errors = error.response.data.errors;
                    if (errors === undefined) {
                        this.errorMessage = error.response.data[0];
                    }
                    else {
                        for (const [key, value] of Object.entries(errors)) {
                            this.errorMessage += `${key}: ${value} \n`;
                        }

                        if (this.errorMessage.includes('System.DateTime')) {
                            this.errorMessage = 'Please provide a valid date.';
                        }
                        else if (this.errorMessage.includes('veterinarianId')) {
                            this.errorMessage = 'Please select a valid veterinarian.';
                        }
                        else if (this.errorMessage.includes('petId')) {
                            this.errorMessage = 'Please select a valid pet.';
                        }
                    }
                });

            if (newConsultation !== undefined) {
                await this.getAllConsultations();
                this.hideConsultationForm();
                this.success = true;
                this.errorMessage = 'Consultation added successfully.';
            }
        },

        showConsultationForm: async function () {
            const vetUrl = `${this.baseUrl}/Veterinarian`;
            const petUrl = `${this.baseUrl}/Pet`;
            await this.getVeterinarians(vetUrl);
            await this.getPets(petUrl);
            this.consultation.title = '';
            $('#addConsultationForm').modal('show');
        },

        hideConsultationForm: function () {
            this.resetConsultationObject();
            $('#addConsultationForm').modal('hide');
        },

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
            this.resetConsultationObject();
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