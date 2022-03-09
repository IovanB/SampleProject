using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;

namespace SignUp.Infrastructure.Repository
{
    public class SignUpRepository : ISignUpRepository
    {
        public void Add(Employee employee)
        {
            using var context = new Context();
            context.Add(employee);
            context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            using var context = new Context();
            return context.Emplooyees.ToList();
        }

        public void Remove(Employee employee)
        {
            using var context = new Context();
            context.Remove(employee);
            context.SaveChanges();
        }
    }
}
