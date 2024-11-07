using system.administration.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemadministration.BLL.Services
{
    public class EmployeessServices
    {
        public EmployeessServices()
        {
        }
        private static List<Employees> employees = new List<Employees>();
        public Task<List<Employees>> GetEmployeesAsync()
        {
            
            return Task.FromResult(employees);
            //throw new NotImplementedException();
        }

        public Task<Employees> GetEmployeesByIdAsync(int id)
        {
            var employee = employees.Find(e => e.id == id); // Пошук працівника за ID
            return Task.FromResult(employee);
        }

        public Task AddEmployeesAsync(Employees employee)
        {
            employees.Add(employee); 
            return Task.CompletedTask;
        }

        public Task UpdateEmployeesAsync(Employees employee)
        {
            var existingEmployee = employees.Find(e => e.id == employee.id);
            if (existingEmployee != null)
            {
                existingEmployee.surname = employee.surname;
                existingEmployee.name = employee.name;
                existingEmployee.patronymic = employee.patronymic;
                existingEmployee.year_of_birth = employee.year_of_birth;
                existingEmployee.year_of_admission = employee.year_of_admission;
                existingEmployee.length_of_service = employee.length_of_service;
                existingEmployee.position = employee.position;
                existingEmployee.gender = employee.gender;
                existingEmployee.address = employee.address;
                existingEmployee.city = employee.city;
                existingEmployee.phone_number = employee.phone_number;
            }
            return Task.CompletedTask;
        }

        public Task DeleteEmployeesAsync(Employees employee)
        {
            employees.Remove(employee); // Видаляє працівника
            return Task.CompletedTask;
        }
    }
}
    

