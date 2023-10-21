
namespace Pri.Pawpi.Core.Services
{
    internal static class Constants
    {
        // Unknown error messages
        internal const string UnknownVeterinarianMessage = "Unknown veterinarian!";
        internal const string UnknownPetMessage = "Unknown pet!";
        internal const string UnknownConsultationMessage = "Unknown consultation!";
        internal const string UnknownPracticeMessage = "Unknown practice!";
        internal const string UnknownCustomerMessage = "Unknown customer!";
        internal const string UnknownSpecialtyMessage = "Unknown specialty!";
        internal const string UnknownMedicineMessage = "Unknown medicine!";

        // Input error messages
        internal const string NoVeterinarianMessage = "Please provide a veterinarian";
        internal const string NoPetMessage = "Please provide a practice";
        internal const string NoConsultationMessage = "Please provide a consultation";
        internal const string NoPracticeMessage = "Please provide a practice";
        internal const string NoCustomerMessage = "Please provide a customer";
        internal const string NoSpecialtyMessage = "Please provide a specialty";
        internal const string NoMedicineMessage = "Please provide a medicine";

        // Other error messages
        internal const string FutureDateMessage = "Dates cannot be in the future";
        internal const string NameExistsMessage = "Name already exists";

        // DB error messages
        internal const string DBUpdateMessage = "Something went wrong while updating";
        internal const string DBCreateMessage = "Something went wrong while adding";
    }
}
