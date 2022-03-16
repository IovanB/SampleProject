using SignUp.Domain.Validator;

namespace SignUp.Domain.Entities
{
    public class Employee : Entity
    {
        public string Name { get; set; }    
        public int Age { get; set; }    
        public Occupation Occupation { get; set; }    
        public DateTime? EntryDate { get; set; }
        public string Email { get; set; }

        public Employee(Guid id, string name, int age, Occupation occupation, DateTime? entryDate, string email)
        {
            Id = id;
            Name = name;
            Age = age;
            Occupation = occupation;
            EntryDate = entryDate;
            Email = email;

            Validate(this, new EmployeeValidator());
        }
    }
}
