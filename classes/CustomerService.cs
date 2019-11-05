// <copyright file="CustomerService.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Classes
{
    using CitrusLime.CloudPOS.Api.CSharpSampleApplication.Ajax;
    using CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>A service for accessing customers information.</summary>
    public class CustomerService
    {
        /// <summary>The CustomerOrder URL for the API calls.</summary>
        private const string CUSTOMER_API_URL = "https://cloudposapi.citruslime.com/api/Customer/";

        /// <summary>Saves the passed Customer through the API</summary>
        /// <exception cref="Exception">Thrown when the call is not successful.</exception>
        /// <param name="customerToSave">The Customer to save.</param>
        /// <returns>True if it succeeds, false if it fails.</returns>
        public bool Save(Customer customerToSave)
        {
            string json = JsonConvert.SerializeObject(customerToSave);

            CallResults results = AJAX.CallAPI(CUSTOMER_API_URL, Constants.enumRESTVerb.PUT, json);

            if (!results.Success)
            {
                throw new Exception($"Error {System.Reflection.MethodBase.GetCurrentMethod().Name} - the error is {results.ErrorMessage}");
            }

            return results.Success;
        }

        /// <summary>Creates a new Customer through the API</summary>
        /// <exception cref="Exception">Thrown when the call is not successful.</exception>
        /// <param name="newCustomer">The new Customer to create.</param>
        /// <returns>The new Customer Id.</returns>
        public int Create(Customer newCustomer)
        {
            string json = JsonConvert.SerializeObject(newCustomer);

            CallResults results = AJAX.CallAPI(CUSTOMER_API_URL, Constants.enumRESTVerb.POST, json);

            if (!results.Success || !int.TryParse(results.Json, out int customerId))
            {
                throw new Exception($"Error {System.Reflection.MethodBase.GetCurrentMethod().Name} - the error is {results.ErrorMessage}");
            }

            return customerId;
        }

        /// <summary>Gets all of the customers for the group.</summary>
        /// <exception cref="Exception">Thrown when the call is not successful.</exception>
        /// <returns>A collection of all Customers for the group.</returns>
        public List<Customer> GetAll()
        {
            CallResults results = AJAX.CallAPI(CUSTOMER_API_URL, Constants.enumRESTVerb.GET);

            if (!results.Success)
            {
                throw new Exception($"Error {System.Reflection.MethodBase.GetCurrentMethod().Name} - the error is {results.ErrorMessage}");
            }

            List<Customer> customers = JsonConvert.DeserializeObject<List<Customer>>(results.Json);

            return customers;
        }

        /// <summary>Gets a Customer through the API based on the passed email address.</summary>
        /// <exception cref="Exception">Thrown when the call is not successful.</exception>
        /// <param name="email">The email of the customer to get.</param>
        /// <returns>The Customer.</returns>
        public Customer GetByEmail(string email)
        {
            //Email needs to be formatted correctly for the call to work. Replace @ with
            // %40 and add a trailing '/'.
            string formattedEmail = $"{email.Replace("@", "%40")}/";

            CallResults results = AJAX.CallAPI($"{CUSTOMER_API_URL}{formattedEmail}", Constants.enumRESTVerb.GET);

            if (!results.Success)
            {
                throw new Exception($"Error {System.Reflection.MethodBase.GetCurrentMethod().Name} - the error is {results.ErrorMessage}");
            }

            Customer customer = JsonConvert.DeserializeObject<Customer>(results.Json);

            return customer;
        }

        /// <summary>Gets a Customer through the API based on the passed id.</summary>
        /// <exception cref="Exception">Thrown when the call is not successful.</exception>
        /// <param name="id">The id of the customer to get.</param>
        /// <returns>The Customer.</returns>
        public Customer GetById(int id)
        {
            CallResults results = AJAX.CallAPI($"{CUSTOMER_API_URL}{id}", Constants.enumRESTVerb.GET);

            if (!results.Success)
            {
                throw new Exception($"Error {System.Reflection.MethodBase.GetCurrentMethod().Name} - the error is {results.ErrorMessage}");
            }

            Customer customer = JsonConvert.DeserializeObject<Customer>(results.Json);

            return customer;
        }
    }
}