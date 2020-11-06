using System;
using System.Data.Entity;
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
            var daoCustomer = new DaoCustomers();
            // act
           Customers seinserto = daoCustomer.Insert(customer);

            //assert
            mockSet.Verify(m => m.Add(It.IsAny<Customers>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());

        }
    }
}
