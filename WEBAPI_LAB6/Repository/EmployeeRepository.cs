using WEBAPI_LAB6.Models;

namespace WEBAPI_LAB6.UnitOfWorks
{
    public class EmployeeRepository
    {
        public CompanyContext DB { get; set; }
        public EmployeeRepository(CompanyContext db)
        {
            DB = db;
        }

        public List<Employee> SelectAll()
        {
            return DB.Employees.ToList();
        }

        public Employee SelectById(int id) 
        { 
            return DB.Employees.FirstOrDefault(n => n.Id == id);
        }

        public void Add(Employee emp)
        {
            DB.Employees.Add(emp);
            DB.SaveChanges();
        }
    }
}
