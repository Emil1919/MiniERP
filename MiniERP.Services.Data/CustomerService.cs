using Microsoft.EntityFrameworkCore;
using Mini_ERP.Data;
using MiniERP.Data.Models;
using MiniERP.Services.Data.Interfaces;
using MiniERP.Web.ViewModels;


namespace MiniERP.Services.Data
{
    // This class is used to create, edit and delete customers.
    /// <summary>
    /// This class is used to create, edit and delete customers
    /// </summary>
  
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

        public  Task<bool> Delete(int id)
        {
            Customer customer =  dbContext.Customers.FirstOrDefault(x => x.Id == id);
            if (dbContext.Invoices.Where(x=>x.CustomerId==id).Any()|| dbContext.Orders.Where(x => x.CustomersId == id).Any())
            {
				return Task.FromResult(false);
			}
            dbContext.Customers.Remove(customer);
            dbContext.SaveChanges();
			return Task.FromResult(true);
		}

        public Task<bool> Edit(CustomerViewModel input)
        {
            Customer customer = dbContext.Customers.FirstOrDefault(x => x.Id == input.Id);
            customer.Name = input.Name;
            customer.City = input.City;
            customer.Address = input.Address;
            customer.Manager = input.Manager;
            customer.PhoneNumber = input.PhoneNumber;
            customer.VatNumber = input.VatNumber;
            
            

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
                VatNumber = x.VatNumber,
                TotalTurnover = x.TotalTurnover
                

            }).ToListAsync();
            return customers;
        }

        public  Task<CustomerViewModel> GetById(int id)
        {
           Customer customer = dbContext.Customers.FirstOrDefault(x => x.Id == id);
			CustomerViewModel customerViewModel = new CustomerViewModel
            {
				Id = customer.Id,
				Name = customer.Name,
				City = customer.City,
				Address = customer.Address,
				Manager = customer.Manager,
				PhoneNumber = customer.PhoneNumber,
				VatNumber = customer.VatNumber,
				TotalTurnover = customer.TotalTurnover
			};
			return Task.FromResult(customerViewModel);
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
