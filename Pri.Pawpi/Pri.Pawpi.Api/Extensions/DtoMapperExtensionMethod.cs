using Pri.Pawpi.Api.Dtos.Consultation;
using Pri.Pawpi.Api.Dtos.Customer;
using Pri.Pawpi.Api.Dtos.Medication;
using Pri.Pawpi.Api.Dtos.Pet;
using Pri.Pawpi.Api.Dtos.Practice;
using Pri.Pawpi.Api.Dtos.Specialty;
using Pri.Pawpi.Api.Dtos.Veterinarian;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Api.Extensions
{
    public static class DtoMapperExtensionMethod
    {
        //public static IEnumerable<T> MapDtos<T>(this ResultModel<T> resultModel)
        //{
        //    var items = resultModel.Items;
        //    string itemName = items.GetType().Name;

        //    IEnumerable<T> result = new List<T>();

        //    return result;
        //}

        #region veterinarian dto mapper
        public static IEnumerable<VeterinarianResponseDto> MapVeterinariansDto(this IEnumerable<Veterinarian> vets)
        {
            return vets.Select(v => v.MapVeterinarianDto());
        }

        public static VeterinarianResponseDto MapVeterinarianDto(this Veterinarian vet)
        {
            return new VeterinarianResponseDto
            {
                Id = vet.Id,
                FirstName = vet.FirstName,
                LastName = vet.LastName,
                Birth = vet.Birth,
                Address = vet.Address,
                City = vet.City,
                Email = vet.Email,
                Phone = vet.Phone,
                Postal = vet.Postal,
                Specialties = vet.Specialties.MapSpecialtiesDto(),
            };
        }
        #endregion

        #region customer dto mapper
        public static IEnumerable<CustomerResponseDto> MapCustomersDto(this IEnumerable<Customer> customers)
        {
            return customers.Select(c => c.MapCustomerDto());
        }

        public static CustomerResponseDto MapCustomerDto(this Customer customer)
        {
            return new CustomerResponseDto
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Birth = customer.Birth,
                Address = customer.Address,
                City = customer.City,
                Email = customer.Email,
                Phone = customer.Phone,
                Postal = customer.Postal,
                Pets = customer.Pets.MapPetsDto()
            };
        }
        #endregion

        #region specialty dto mapper
        public static IEnumerable<SpecialtyResponseDto> MapSpecialtiesDto(this IEnumerable<Specialty> specs)
        {
            return specs.Select(s => s.MapSpecialtyDto());
        }

        public static SpecialtyResponseDto MapSpecialtyDto(this Specialty spec)
        {
            return new SpecialtyResponseDto
            {
                Id = spec.Id,
                Name = spec.Name,
                Description = spec.Description,
            };
        }
        #endregion

        #region medication dto mapper
        public static IEnumerable<MedicationResponseDto> MapMedicineDto(this IEnumerable<Medication> meds)
        {
            return meds.Select(m => m.MapMedicationDto());
        }

        public static MedicationResponseDto MapMedicationDto(this Medication med)
        {
            return new MedicationResponseDto
            {
                Id = med.Id,
                Name = med.Name,
                Notes = med.Notes,
                SideEffects = med.SideEffects
            };
        }
        #endregion

        #region pet dto mapper
        public static IEnumerable<PetResponseDto> MapPetsDto(this IEnumerable<Pet> pets)
        {
            return pets.Select(p => p.MapPetDto());
        }

        public static PetResponseDto MapPetDto(this Pet pet)
        {
            return new PetResponseDto
            {
                Id = pet.Id,
                Name = pet.Name,
                CallName = pet.CallName,
                Breed = pet.Breed,
                Color = pet.Color,
                AnimalType = pet.AnimalType,
                Weight = (double)pet.Weight,
                Consultations = pet.Consultations.MapConsultationsDto()
            };
        }
        #endregion

        #region practice dto mapper
        public static IEnumerable<PracticeResponseDto> MapPracticesDto(this IEnumerable<Practice> practices)
        {
            return practices.Select(p => p.MapPracticeDto());
        }

        public static PracticeResponseDto MapPracticeDto(this Practice practice)
        {
            return new PracticeResponseDto
            {
                Name = practice.Name,
                Address = practice.Address,
                City = practice.City,
                Email = practice.Email,
                Phone = practice.Phone,
                Postal = practice.Postal,
                OpenTime = practice.OpenTime,
                CloseTime = practice.CloseTime,
                Veterinarians = practice.Veterinarians.MapVeterinariansDto(),
                Customers = practice.Customers.MapCustomersDto()
            };
        }
        #endregion

        #region consultation dto mapper
        public static IEnumerable<ConsultationResponseDto> MapConsultationsDto(this IEnumerable<Consultation> consultations)
        {
            return consultations.Select(c => c.MapConsultationDto());
        }

        public static ConsultationResponseDto MapConsultationDto(this Consultation consultation)
        {
            return new ConsultationResponseDto
            {
                Title = consultation.Title,
                Diagnosis = consultation.Diagnosis,
                Treatment = consultation.Treatment,
                Notes = consultation.Notes,
                DateOfConsultation = consultation.DateOfConsultation,
            };
        }
        #endregion
    }
}
