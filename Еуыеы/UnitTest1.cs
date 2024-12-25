using Agency.WebApp.Controllers;
using Agency.WebApp.Data;
using Agency.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        public class OrdersControllerTests
        {
            private ApplicationDbContext GetDatabaseContext()
            {
                var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: "TestDatabase")
                    .Options;

                var dbContext = new ApplicationDbContext(options);

                // Add initial test data
                dbContext.orders.AddRange(new List<Order>
                {
                    new Order {id = 1, id_client = "67d463a1-9015-4322-899c-c0facba33678", discription = "Order 1"},
                    new Order {id = 2, id_client = "67d463a1-9015-4322-899c-c0facba33678", discription = "Order 2"},
                    new Order {id = 3, id_client = "67d463a1-9015-4322-899c-c0facba33678", discription = "Order 3"},
                });

                dbContext.SaveChanges();
                return dbContext;
            }

          

            [Test]
            public async Task Details_ExistingId_ReturnsViewWithOrder()
            {
                // Arrange
                var context = GetDatabaseContext();
                var controller = new OrdersController(context);

                // Act
                var result = await controller.Details(1) as ViewResult;

                // Assert
                Assert.NotNull(result);
                Assert.IsInstanceOf<Order>(result.Model);

                var order = (Order)result.Model;
                Assert.AreEqual(1, order.id);
            }

            [Test]
            public async Task Create_ValidOrder_RedirectsToIndex()
            {
                // Arrange
                var context = GetDatabaseContext();
                var controller = new OrdersController(context);
                var order = new Order { id_client = "67d463a1-9015-4322-899c-c0facba33678", discription = "Order 4" };

                // Act
                var result = await controller.Create(order) as RedirectToActionResult;

                // Assert
                Assert.NotNull(result);
                Assert.AreEqual("Index", result.ActionName);
                Assert.AreEqual(4, context.orders.Count()); // Corrected count
            }

            [Test]
            public async Task Delete_ExistingId_ReturnsViewWithOrder()
            {
                // Arrange
                var context = GetDatabaseContext();
                var controller = new OrdersController(context);

                // Act
                var result = await controller.Delete(1) as ViewResult;

                // Assert
                Assert.NotNull(result);
                Assert.IsInstanceOf<Order>(result.Model);

                var order = (Order)result.Model;
                Assert.AreEqual(1, order.id);
            }

            [Test]
            public async Task DeleteConfirmed_ExistingOrder_RedirectsToIndex()
            {
                // Arrange
                var context = GetDatabaseContext();
                var controller = new OrdersController(context);

                // Act
                var result = await controller.DeleteConfirmed(1) as RedirectToActionResult;

// Assert
                Assert.NotNull(result);
                Assert.AreEqual("Index", result.ActionName);
                Assert.AreEqual(2, context.orders.Count()); // Corrected count after deletion
            }
        }
    }
}