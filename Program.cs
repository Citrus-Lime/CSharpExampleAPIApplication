// <copyright file="Program.cs" company="CitrusLime Ltd">
// Copyright (c) CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CitrusLime.CloudPOS.Api.CSharpSampleApplication.Classes;
    using CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data;

    /// <summary>
    /// This is an example project to demonstrate functionality of the CitrusLime API
    /// There is a dependency on Newton.JSON. You can install the package through NuGet.
    /// 
    /// Before running, make sure you do some setup in Constants.cs
    /// 1. API_KEY          Replace "YOUR API KEY HERE" with your API key  
    /// 2. CUSTOMER_ID      Replace 0 with a customer id in your CloudPOS group  
    /// 3. APP_NAME         (optional) Replace "My App" with a more memorable name  
    /// 
    /// </summary>
    class Program
    {
        /// <summary>Gets the current time as string.</summary>
        /// <value>The current time as string.</value>
        private static string CurrentTimeAsString
        {
            get
            {
                return $"{DateTime.Now.Year}{DateTime.Now.Month}{DateTime.Now.Day}{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}";
            }
        }

        /// <summary>Main entry-point for this application.</summary>
        /// <param name="args">An array of command-line argument strings.</param>
        static void Main(string[] args)
        {
            CustomerService customerService = new CustomerService();

            CustomerOrderService customerOrderService = new CustomerOrderService();

            Console.WriteLine("Getting all customers. Please wait.");

            List<Customer> customers = customerService.GetAll();

            DisplayInfoForAllCustomers(customers);

            Console.WriteLine($"Getting customer by id of {Constants.CUSTOMER_ID}");

            Customer customer = customerService.GetById(Constants.CUSTOMER_ID);

            DisplayInfoForCustomer(customer);

            Customer newCustomer = CreateNewCustomerAndShowResponse(customerService);

            UpdateCustomerAndShowResponse(customerService, customers.First());

            GetAndDisplayInfoForAllOrders(customerOrderService);

            CreateNewCustomerOrderAndShowResponse(customerOrderService, newCustomer);

            Console.ReadLine();
        }

        /// <summary>Displays information for all customers.</summary>
        /// <param name="customers">A list of Customers.</param>
        private static void DisplayInfoForAllCustomers(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                DisplayInfoForCustomer(customer);
            }
        }

        /// <summary>Displays an information for a signle customer</summary>
        /// <param name="customer">The customer.</param>
        private static void DisplayInfoForCustomer(Customer customer)
        {
            Console.WriteLine($"Name:  {customer.FirstName} {customer.LastName}  Email: {customer.EmailAddress}  ID: {customer.Uid}");
        }

        /// <summary>Creates new customer and shows the response.</summary>
        /// <param name="customerService">The customer service.</param>
        /// <returns>The newly created Customer.</returns>
        private static Customer CreateNewCustomerAndShowResponse(CustomerService customerService)
        {
            Random random = new Random();

            //Set up the new customer locally.
            Customer newCustomer = new Customer()
            {
                AccountNumber = $"{Constants.APP_NAME}{CurrentTimeAsString}", //required must be unique 
                FirstName = "Bilbo",
                LastName = "Baggins", // required  
                EmailAddress = $"bilbo{random.Next(1000000)}@citruslime.com", //not required, but must be unique
                Address = "The Lantern House",
                City = "Ulverston",
                Postcode = "LA12 0AA",
                Country = "GB"
            };

            try
            {
                //Send the customer to the API through the Customer Service to create it on CloudPOS.
                int newCustomerId = customerService.Create(newCustomer);

                Console.WriteLine($"Created Customer ID {newCustomerId}, with email {newCustomer.EmailAddress}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"New Customer Failed - {exception.Message}");
            }

            return newCustomer;
        }

        /// <summary>Updates the customer and shows a response.</summary>
        /// <param name="customerService">The customer service.</param>
        /// <param name="customer">The customer to update.</param>
        private static void UpdateCustomerAndShowResponse(CustomerService customerService, Customer customer)
        {
            customer.Notes += "1234567890";

            if (customerService.Save(customer))
            {
                Console.WriteLine($"Saved {customer.FirstName} {customer.LastName}");
            }
            else
            {
                Console.WriteLine("Save Customer Failed");
            }
        }

        /// <summary>Gets and display information for all orders.</summary>
        /// <param name="customerOrderService">The customer order service.</param>
        private static void GetAndDisplayInfoForAllOrders(CustomerOrderService customerOrderService)
        {
            List<CustomerOrder> orders = customerOrderService.GetAllHeaders();

            foreach (CustomerOrder order in orders)
            {
                string status = order.Closed ? "CLOSED" : "OPEN";

                Console.WriteLine($"Order #{order.Uid} is '{ status }'. Sub total { order.Total.ToString("C") }, " +
                    $"for which a deposit of {order.Deposit.ToString("C")} has been taken in payment.");

                CustomerOrder orderDetail = customerOrderService.GetByOrderId(order.Uid);

                foreach (OrderLine orderLine in orderDetail.OrderLines)
                {
                    Console.WriteLine($"\t {orderLine.Description} \t Quantity Still Outstanding { orderLine.QuantityOnOrder} " +
                        $"\t Quantity Picked Up {orderLine.QuantityRTD}.");
                }
            }
        }

        /// <summary>Creates new customer order and show response.</summary>
        /// <param name="customerOrderService">The customer order service.</param>
        /// <param name="customer">The customer.</param>
        private static void CreateNewCustomerOrderAndShowResponse(CustomerOrderService customerOrderService, Customer customer)
        {
            Console.WriteLine("Getting all items.");
            
            ItemService itemService = new ItemService();

            List<Item> items = itemService.GetAll();

            Console.WriteLine("Getting all stores.");

            StoresService storesService = new StoresService();

            List<Store> stores = storesService.GetAll();

            NewCustomerOrder newOrder = NewCustomerOrderBuilder.Build($"{Constants.APP_NAME}{CurrentTimeAsString}",
                                                                    customer,
                                                                    stores.FirstOrDefault().StoreClientCode,
                                                                    "API CSharp Order Comment");

            newOrder.Items.Add(new CustomerOrderItem()
            {
                Code = items.Last().ItemLookupCode,
                Quantity = 2,
                UnitPrice = 9.99,
            });

            try
            {
                Console.WriteLine("Creating an order.");

                int orderId = customerOrderService.Create(newOrder);

                Console.WriteLine($"New Order Id : {orderId}");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"New Order Failed - {exception.Message}");
            }
        }
    }
}