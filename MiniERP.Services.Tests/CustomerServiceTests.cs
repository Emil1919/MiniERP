using Microsoft.EntityFrameworkCore.Storage;
using MiniERP.Data.Models;
using MiniERP.Services.Data;
using Moq;


namespace MiniERP.Services.Tests
{
	[TestFixture]
	public class CustomerServiceTests
	{
		[Test]
		public void GetCustomerById_ValidId_ReturnsCustomer()
		{
			// Arrange
			var mockDatabase = new Mock<IDatabase>();
			mockDatabase.Setup(db => db.GetCustomerById(1))
				.Returns(new Customer { Id = 1, Name = "Nero 2000" });

			var customerService = new CustomerService(mockDatabase.Object);

			// Act
			var customer = customerService.GetCustomerById(1);

			// Assert
			Assert.NotNull(customer);
			Assert.AreEqual(1, customer.Id);
			Assert.AreEqual("Nero 2000", customer.Name);
		}
	}
}







