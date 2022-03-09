using SignUp.Domain.Entities;

namespace SignUp.Controllers
{
    public class RequestInput
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Occupation Occupation { get; set; }
        public DateTime? EntryDate { get; set; }
    }
}
