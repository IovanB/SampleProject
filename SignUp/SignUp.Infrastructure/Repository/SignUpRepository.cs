using SignUp.Application.Interfaces;
using SignUp.Domain.Entities;

namespace SignUp.Infrastructure.Repository
{
    public class SignUpRepository : ISignUpRepository
    {
        public bool Add(Employee employee)
        {
            using var context = new Context();
            context.Add(employee);
            context.SaveChanges();

            return true;
        }

        public List<Employee> GetAll()
        {
            using var context = new Context();
            return context.Emplooyees.ToList();
        }

        public bool Remove(Employee employee)
        {
            using var context = new Context();
            context.Remove(employee);
            context.SaveChanges();

            return true;
        }
    }
}
