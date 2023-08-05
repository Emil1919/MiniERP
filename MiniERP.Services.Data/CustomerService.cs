using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Data.Models;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Services.Data
{
  
    public class CustomerService : ICustomerService
    {
         private readonly MiniERP_DbContext dbContext;
        public CustomerService(MiniERP_DbContext dbContext)
        {
            this.dbContext = dbContext;
            
        }
        public Task<bool> Create(CustomerViewModel input)
        {
            Customer customer = new Customer
            {
                Name = input.Name,
                City = input.City,
                Address = input.Address,
                Manager = input.Manager,
                PhoneNumber = input.PhoneNumber,
                VatNumber = input.VatNumber

            };
            dbContext.Customers.Add(customer);
            dbContext.SaveChanges();
            return Task.FromResult(true);
        }

        public async Task<bool> Delete(int id)
        {
            Customer customer = await dbContext.Customers.FirstOrDefaultAsync(x => x.Id == id);

            dbContext.Customers.Remove(customer);
            dbContext.SaveChanges();
            return true;
        }

        public Task<bool> Edit(CustomerViewModel input)
        {
            Customer customer = dbContext.Customers.FirstOrDefaultAsync(x => x.Id == input.Id).Result;
            customer.Name = input.Name;
            customer.City = input.City;
            customer.Address = input.Address;
            customer.Manager = input.Manager;
            customer.PhoneNumber = input.PhoneNumber;
            dbContext.Customers.Update(customer);
            dbContext.SaveChanges();
            return Task.FromResult(true);

        }

        public async Task<ICollection<CustomerViewModel>> GetAll()
        {
            ICollection<CustomerViewModel> customers =  await dbContext.Customers.Select(x => new CustomerViewModel
            {
                Id = x.Id,
                Name = x.Name,
                City = x.City,
                Address = x.Address,
                Manager = x.Manager,
                PhoneNumber = x.PhoneNumber,
                VatNumber = x.VatNumber

            }).ToListAsync();
            return customers;
        }

        public async Task<CustomerViewModel> GetById(int id)
        {
           return await dbContext.Customers.Select(x => new CustomerViewModel
           {
                Id = x.Id,
                Name = x.Name,
                City = x.City,
                Address = x.Address,
                Manager = x.Manager,
                PhoneNumber = x.PhoneNumber,
                VatNumber = x.VatNumber

            }).FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<bool> IsExist(int id)
        {
            if (dbContext.Customers.Any(x => x.Id == id))
            {
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }
    }
}
