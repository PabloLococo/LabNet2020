using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Entities;

namespace Ejercicio_3
{
    class Consola
    {
        static void Main(string[] args)
        {
            Customers_Logic customers_logic = new Customers_Logic();

            try
            {
                Console.WriteLine("Ingrese un nuevo Cliente");
                Console.WriteLine("Identificador de Compania");
                var idCustomer = Console.ReadLine();
                Console.WriteLine("Nombre de Compania");
                var nombreCompania = Console.ReadLine();
                Console.WriteLine("Nombre de Contacto");
                var nombreContacto = Console.ReadLine();
                Console.WriteLine("Ingrese Dirección");
                var dirreción = Console.ReadLine();
                customers_logic.AddNewCustomer(new Customers { CustomerID = idCustomer, CompanyName = nombreCompania, ContactName = nombreContacto, Address = dirreción });
                var listCustomers = customers_logic.ListCustomers();
                foreach (Customers customers in listCustomers)
                {
                    Console.WriteLine(customers.CustomerID + " " + customers.CompanyName + " " + customers.ContactName + " " + customers.Address);
                }
                Console.WriteLine("Buscar por ID");
                var customerPorId = customers_logic.Customer(Console.ReadLine());
                Console.WriteLine(customerPorId.CustomerID + " " + customerPorId.ContactName + " " + customerPorId.CompanyName);


                Products_Logic products_Logic = new Products_Logic();
                Console.WriteLine("Modificar Producto");
                Console.WriteLine("Ingrese Identificador de Producto");
                var product = products_Logic.Product(int.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese un nuevo Precio");
                decimal nuevoPrecio = decimal.Parse(Console.ReadLine());
                product.UnitPrice = nuevoPrecio;
                products_Logic.UpdateProduct(product);
                var list_Productos = products_Logic.ListofProducts();
                //Console.WriteLine("Eliminar Producto");   Tecnicamente funciona pero como no implemente Cascade Delete siempre va a tirar sqlexeption
                //Console.WriteLine("Ingrese Identificador de Producto");
                //product = products_Logic.Product(int.Parse(Console.ReadLine()));
                //products_Logic.DeleteProduct(product);
                foreach (Products products in list_Productos)
                {
                    Console.WriteLine(products.ProductID + " " + products.ProductName + " " + products.UnitPrice);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            Console.ReadLine();
        }
    }
}
