using Pri.Pawpi.Api.Dtos.Consultation;
using Pri.Pawpi.Api.Dtos.Customer;
using Pri.Pawpi.Api.Dtos.Medication.Response;
using Pri.Pawpi.Api.Dtos.Pet;
using Pri.Pawpi.Api.Dtos.Pet.Response;
using Pri.Pawpi.Api.Dtos.Practice;
using Pri.Pawpi.Api.Dtos.Specialty.Response;
using Pri.Pawpi.Api.Dtos.Veterinarian;
using Pri.Pawpi.Core.Entities;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Pri.Pawpi.Api.Extensions
{
    public static class DtoMapperExtensionMethod
    {
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
                //Specialties = vet.Specialties.MapDto()
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
                //Pets = customer.Pets.MapPetsDto()
            };
        }
        #endregion

        #region specialty dto mapper
        public static SpecialtyGetAllDto MapDto(this IEnumerable<Specialty> specs)
        {
            return new SpecialtyGetAllDto
            {
                Specialties = specs.Select(s => s.MapDto())
            };
        }

        public static SpecialtyGetDto MapDto(this Specialty spec)
        {
            return new SpecialtyGetDto
            {
                Id = spec.Id,
                Name = spec.Name,
                Description = spec.Description,
            };
        }

        public static SpecialtySearchByNameDto MapDto(this IEnumerable<Specialty> specs, string name)
        {
            return new SpecialtySearchByNameDto
            {
                SearchInfo = $"{specs.Count()} Results were found for {name}",
                Specialties = specs.Select(s => s.MapDto())
            };
        }
        #endregion

        #region medication dto mapper
        public static MedicationGetAllDto MapDto(this IEnumerable<Medication> meds)
        {
            return new MedicationGetAllDto
            {
                Medicine = meds.Select(m => m.MapDto())
            };
        }

        public static MedicationGetDto MapDto(this Medication med)
        {
            return new MedicationGetDto
            {
                Id = med.Id,
                Name = med.Name,
                Notes = med.Notes,
                SideEffects = med.SideEffects,
                Pets = med.Pets.MapBaseDto()
            };
        }

        public static MedicationSearchDto MapDto(this IEnumerable<Medication> meds, string name)
        {
            return new MedicationSearchDto
            {
                SearchInfo = $"{meds.Count()} Results were found for {name}",
                Medicine = meds.Select(m => m.MapDto())
            };
        }

        #endregion

        #region pet dto mapper
        public static PetGetAllDto MapDto(this IEnumerable<Pet> pets)
        {
            return new PetGetAllDto
            {
                Pets = pets.Select(p => p.MapDto())
            };
        }

        public static PetGetDto MapDto(this Pet pet)
        {
            return new PetGetDto
            {
                Id = pet.Id,
                Name = pet.Name,
                CallName = pet.CallName,
                Breed = pet.Breed,
                Color = pet.Color,
                AnimalType = pet.AnimalType,
                Weight = (double)pet.Weight,
            };
        }

        public static PetSearchDto MapDto(this IEnumerable<Pet> pets, string name)
        {
            return new PetSearchDto
            {
                SearchInfo = $"{pets.Count()} Results were found for {name}",
                Pets = pets.Select(p => p.MapDto())
            };
        }

        public static IEnumerable<PetBaseDto> MapBaseDto(this IEnumerable<Pet> pets)
        {
            return pets.Select(p => p.MapBaseDto());
        }

        public static PetBaseDto MapBaseDto(this Pet pet)
        {
            return new PetBaseDto
            {
                Id = pet.Id,
                Name = pet.Name,
                AnimalType = pet.AnimalType,
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
