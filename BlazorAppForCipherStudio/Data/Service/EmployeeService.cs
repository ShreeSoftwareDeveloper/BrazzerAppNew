using BlazorAppForCipherStudio.Context;
using BlazorAppForCipherStudio.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppForCipherStudio.Data.Service
{
    public class EmployeeService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public EmployeeService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        //Get
        public async Task<List<Employee>> GetEmployees()
        {
            return await applicationDbContext.Employees.ToListAsync();

        }
        //Add Employee
        public async Task <bool>AddEmployee(Employee employee)
        {
            await applicationDbContext.Employees.AddAsync(employee); ;
            await applicationDbContext.SaveChangesAsync();
            return true;
        }
        //Get By Id
        public async Task<Employee>GetById(int Id)

        {
            Employee employee = await applicationDbContext.Employees.FirstOrDefaultAsync(x => x.Id == Id);
            return employee;
 

        }
        //Update
        public async  Task<bool>UpdateEmployeeDeatils(Employee employee)
        {
            applicationDbContext.Employees.Update(employee);
            await applicationDbContext.SaveChangesAsync();
            return true;
        }
        //Delete
        public async Task<bool> DeleteEmployee(Employee emmployee)
        {
            applicationDbContext.Employees.Remove(emmployee);
            await applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}
