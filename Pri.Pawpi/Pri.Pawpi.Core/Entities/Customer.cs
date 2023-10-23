using System.ComponentModel.DataAnnotations.Schema;

namespace Pri.Pawpi.Core.Entities
{
    public class Customer : Person
    {
        public ICollection<Pet> Pets { get; set; }

        public int PracticeId { get; set; }
        public Practice Practice { get; set; }
    }
}
