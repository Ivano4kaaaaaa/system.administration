﻿using admin.DAL.Entities;
using admin.DAL.IRepository;
using admin.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace systemadministration.BLL.Services
{
    public class TroupeeServices
    {
        private readonly ITroupeRepository _troupeRepository;
        public TroupeeServices(ITroupeRepository troupeRepository)
        {
            _troupeRepository = troupeRepository;
        }
        public TroupeeServices(){}
        public async Task<IEnumerable<Troupe>> GetAllTroupeAsync()
        {
            return await _troupeRepository.GetAllTroupeAsync();
        }

        public  async Task AddTroupeAsync(Troupe tr)
        {
            await _troupeRepository.AddTroupeAsync(tr);
        }

        public async Task DeleteTroupeAsync(Troupe tr)
        {
            await _troupeRepository.DeleteTroupeAsync(tr);
        }

        public async Task UpdateTroupeAsync(int id)
        {
            var troupe = await _troupeRepository.GetTroupeByIdAsync(id);
            if (troupe != null)
            {
                await _troupeRepository.UpdateTroupeAsync(troupe);
            }
            else
            {
                throw new Exception("Трупу  оновлено");
            }
        }
        public async Task<Troupe> GetTroupeByIdAsync(int id)
        {
            return await _troupeRepository.GetTroupeByIdAsync(id);
        }

        public async Task DeleteTroupeAsync(int id)
        {
            var troupe = await _troupeRepository.GetTroupeByIdAsync(id);
            if (troupe != null)
            {
                await _troupeRepository.UpdateTroupeAsync(troupe);
            }
            else
            {
                throw new Exception("Трупу не знайдено");
            }
        }
    }
}
//using admin.DAL.Entities;
//using admin.DAL.IRepository;
//using admin.DAL.Entities;
//using admin.DAL.IRepository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace systemadministration.BLL.Services
//{
//    public class EmployeessServices
//    {
//        private readonly IEmployeesRepository _employeesRepository;

//        public EmployeessServices(IEmployeesRepository employeesRepository)
//        {
//            _employeesRepository = employeesRepository;
//        }


//        public async Task AddEmployeesAsync(Employees empl)
//        {
//            await _employeesRepository.AddEmployeesAsync(empl);
//        }

//        public async Task<IEnumerable<Employees>> GetAllEmployeesAsync()
//        {
//            return await _employeesRepository.GetAllEmployeesAsync();
//        }
//        public async Task<Employees> GetEmployeesByIdAsync(int id)
//        {
//            return await _employeesRepository.GetEmployessAsync(id);
//        }
//        public async Task UpdateEmployeesAsync(int id)
//        {
//            var employee = await _employeesRepository.GetEmploeyesAsync(id);
//            if (employee != null)
//            {
//                await _employeesRepository.UpdateEmployessAsync(employee);
//            }
//            else
//            {
//                throw new Exception("Працівника оновлено");
//            }
//        }

//        public async Task DeleteEmployeesAsync(int id)
//        {
//            var employee = await _employeesRepository.GetEmploeyesAsync(id);
//            if (employee != null)
//            {
//                await _employeesRepository.DeleteEmployeesAsync(employee);
//            }
//            else
//            {
//                throw new Exception("Працівника не знайдено");
//            }
//        }