namespace Pri.Pawpi.Core.Entities
{
    public class Veterinarian : Person
    {
        public List<Specialty> Specialties { get; set; }


        public int PracticeId { get; set; }
        public Practice Practice { get; set; }
    }
}
