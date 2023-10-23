using Pri.Pawpi.Api.Dtos.Consultation.Response;
using Pri.Pawpi.Api.Dtos.Customer.Response;
using Pri.Pawpi.Api.Dtos.Medication.Response;
using Pri.Pawpi.Api.Dtos.Pet.Response;
using Pri.Pawpi.Api.Dtos.Practice.Response;
using Pri.Pawpi.Api.Dtos.Specialty.Response;
using Pri.Pawpi.Api.Dtos.Veterinarian.Response;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Api.Extensions
{
    public static class DtoMapperExtensionMethod
    {
        #region veterinarian dto mapper
        public static VeterinarianGetAllDto MapDto(this IEnumerable<Veterinarian> vets)
        {
            return new VeterinarianGetAllDto
            {
                Veterinarians = vets.Select(v => v.MapDto())
            };
        }

        public static VeterinarianGetDto MapDto(this Veterinarian vet)
        {
            return new VeterinarianGetDto
            {
                Id = vet.Id,
                FirstName = vet.FirstName,
                LastName = vet.LastName,
                Birth = vet.Birth.Date,
                Address = vet.Address,
                City = vet.City,
                Email = vet.Email,
                Phone = vet.Phone,
                Postal = vet.Postal,
                Specialties = vet.Specialties.MapBaseDto(),
                Practices = vet.Practices.MapBaseDto(),
                Consultations = vet.Consultations.MapBaseDto()
            };
        }

        public static VeterinarianSearchDto MapDto(this IEnumerable<Veterinarian> vets, string name)
        {
            return new VeterinarianSearchDto
            {
                SearchInfo = $"{vets.Count()} Results were found for {name}",
                Veterinarians = vets.Select(v => v.MapDto())
            };
        }

        public static IEnumerable<VeterinarianBaseDto> MapBaseDto(this IEnumerable<Veterinarian> vets)
        {
            return vets.Select(v => v.MapBaseDto());
        }

        public static VeterinarianBaseDto MapBaseDto(this Veterinarian vet)
        {
            return new VeterinarianBaseDto
            {
                Id = vet.Id,
                FirstName = vet.FirstName,
                LastName = vet.LastName,
                Email = vet.Email
            };
        }
        #endregion

        #region customer dto mapper
        public static CustomerGetAllDto MapDto(this IEnumerable<Customer> customers)
        {
            return new CustomerGetAllDto
            {
                Customers = customers.Select(c => c.MapDto())
            };
        }

        public static CustomerGetDto MapDto(this Customer customer)
        {
            return new CustomerGetDto
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Birth = customer.Birth.Date,
                Address = customer.Address,
                City = customer.City,
                Email = customer.Email,
                Phone = customer.Phone,
                Postal = customer.Postal,
                Pets = customer.Pets.MapBaseDto(),
                Practice = customer.Practice.MapBaseDto()
            };
        }

        public static CustomerSearchDto MapDto(this IEnumerable<Customer> customers, string name)
        {
            return new CustomerSearchDto
            {
                SearchInfo = $"{customers.Count()} Results were found for {name}",
                Customers = customers.Select(c => c.MapDto())
            };
        }

        public static IEnumerable<CustomerBaseDto> MapBaseDto(this IEnumerable<Customer> customers)
        {
            return customers.Select(c => c.MapBaseDto());
        }

        public static CustomerBaseDto MapBaseDto(this Customer customer)
        {
            return new CustomerBaseDto
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email
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

        public static IEnumerable<SpecialtyBaseDto> MapBaseDto(this IEnumerable<Specialty> specs)
        {
            return specs.Select(s => s.MapBaseDto());
        }

        public static SpecialtyBaseDto MapBaseDto(this Specialty spec)
        {
            return new SpecialtyBaseDto
            {
                Id = spec.Id,
                Name = spec.Name,
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
                Customer= pet.Customer.MapBaseDto(),
                LastConsultation = pet.Consultations.MapBaseDto().LastOrDefault(),
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
        public static PracticeGetAllDto MapDto(this IEnumerable<Practice> practices)
        {
            return new PracticeGetAllDto
            {
                Practices = practices.Select(c => c.MapDto())
            };
        }

        public static PracticeGetDto MapDto(this Practice practice)
        {
            return new PracticeGetDto
            {
                Id = practice.Id,
                Name = practice.Name,
                Address = practice.Address,
                City = practice.City,
                Email = practice.Email,
                Phone = practice.Phone,
                Postal = practice.Postal,
                OpenTime = practice.OpenTime,
                CloseTime = practice.CloseTime,
                LogoUrl = practice.Logo,
                Veterinarians = practice.Veterinarians.MapBaseDto()
            };
        }

        public static PracticeSearchDto MapDto(this IEnumerable<Practice> practices, string name)
        {
            return new PracticeSearchDto
            {
                SearchInfo = $"{practices.Count()} Results were found for {name}",
                Practices = practices.Select(c => c.MapDto())
            };
        }

        public static IEnumerable<PracticeBaseDto> MapBaseDto(this IEnumerable<Practice> practices)
        {
            return practices.Select(c => c.MapBaseDto());
        }

        public static PracticeBaseDto MapBaseDto(this Practice practice)
        {
            return new PracticeBaseDto
            {
                Id = practice.Id,
                Name = practice.Name,
                Address = practice.Address,
                City = practice.City,
                OpenTime = practice.OpenTime,
                CloseTime = practice.CloseTime,
            };
        }
        #endregion

        #region consultation dto mapper
        public static ConsultationGetAllDto MapDto(this IEnumerable<Consultation> cons)
        {
            return new ConsultationGetAllDto
            {
                Consultations = cons.Select(c => c.MapDto())
            };
        }

        public static ConsultationGetDto MapDto(this Consultation con)
        {
            return new ConsultationGetDto
            {
                Id = con.Id,
                Title = con.Title,
                Diagnosis = con.Diagnosis,
                Treatment = con.Treatment,
                Notes = con.Notes,
                DateOfConsultation = con.DateOfConsultation.Date,
                VeterinarianName = con.Veterinarian.FirstName + " " + con.Veterinarian.LastName,
                PetName = con.Pet.Name
            };
        }

        public static ConsultationSearchDto MapDto(this IEnumerable<Consultation> cons, string name)
        {
            return new ConsultationSearchDto
            {
                SearchInfo = $"{cons.Count()} Results were found for {name}",
                Consultations = cons.Select(c => c.MapDto())
            };
        }

        public static IEnumerable<ConsultationBaseDto> MapBaseDto(this IEnumerable<Consultation> cons)
        {
            return cons.Select(c => c.MapBaseDto());
        }

        public static ConsultationBaseDto MapBaseDto(this Consultation con)
        {
            return new ConsultationBaseDto
            {
                Id = con.Id,
                Title = con.Title,
                DateOfConsultation = con.DateOfConsultation,
            };
        }
        #endregion
    }
}
