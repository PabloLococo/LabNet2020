using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAO;
using Entities;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ResourceAcceess;

namespace Test
{
    [TestClass]
    public class NordwindQuerryText
    {
        [TestMethod]
        public void InsertCustomer_Exitoso()
        {
            // arrange
            var mockSet = new Mock<DbSet<Customers>>();
            var mockContext = new Mock<NordwindContext>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);


            Customers customer = new Customers();
            customer.CustomerID = "XXXXX";
            customer.CompanyName = "QWEEQ";
            customer.ContactName = "SDADASD";
            var daoCustomer = new DaoCustomers(mockContext.Object);
            // act
            Customers seinserto = daoCustomer.Insert(customer);

            //assert
            mockSet.Verify(m => m.Add(It.IsAny<Customers>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

        }
        [TestMethod]
        public void DeleteCustomer_Exitoso()
        {
            Customers customer = new Customers();
            customer.CustomerID = "AAAAA";

            var mockSet = new Mock<DbSet<Customers>>();
            var mockContext = new Mock<NordwindContext>();

            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);
            mockSet.Setup(m => m.Customer).Returns(customer);

            var daoCustomer = new DaoCustomers(mockContext.Object);
            daoCustomer.Delete(customer);
            mockSet.Verify(m => m.Remove(It.IsAny<Customers>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void ListProducto_Exitoso()
        {
            var data = new List<Products>

          {
             new Products {ProductID = 100 , UnitPrice = 200 },
             new Products {ProductID = 101 , UnitPrice = 500 },
             new Products {ProductID = 102 , UnitPrice = 900 },
             new Products {ProductID = 103 , UnitPrice = 400 }
          }.AsQueryable();

            var mockset = new Mock<DbSet<Products>>();
            mockset.As<IQueryable<Products>>().Setup(m => m.Provider).Returns(data.Provider);
            mockset.As<IQueryable<Products>>().Setup(m => m.Expression).Returns(data.Expression);
            mockset.As<IQueryable<Products>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockset.As<IQueryable<Products>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<NordwindContext>();
            mockContext.Setup(c => c.Products).Returns(mockset.Object);

            var daoProduct = new DaoProducts(mockContext.Object);
            List<Products> listProducts = daoProduct.GetAll();
            Assert.AreEqual(4, listProducts.Count);
            Assert.AreEqual(100, listProducts[0].ProductID);
            Assert.AreEqual(200, listProducts[0].UnitPrice);
            Assert.AreEqual(101, listProducts[1].ProductID);
            Assert.AreEqual(500, listProducts[1].UnitPrice);
        }
    }
}
