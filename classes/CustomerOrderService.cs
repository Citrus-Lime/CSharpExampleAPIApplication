// <copyright file="CustomerOrderService.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Classes
{
    using CitrusLime.CloudPOS.Api.CSharpSampleApplication.Ajax;
    using CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>A service for accessing customer order information.</summary>
    public class CustomerOrderService
    {
        /// <summary>The CustomerOrder URL for the API calls.</summary>
        private const string CUSTOMERORDER_API_URL = "https://cloudposapi.citruslime.com/api/CustomerOrder/";

        /// <summary>Gets all headers.Gets all of the orders but does not include line items.</summary>
        /// <exception cref="Exception">Thrown when the call is not successful.</exception>
        /// <returns>List of Customer Orders.</returns>
        public List<CustomerOrder> GetAllHeaders()
        {
            CallResults results = AJAX.CallAPI(CUSTOMERORDER_API_URL, Constants.enumRESTVerb.GET);

            if(!results.Success)
            {
                throw new Exception($"Error {MethodBase.GetCurrentMethod().Name} - the error is {results.ErrorMessage}");
            }

            List<CustomerOrder> customerOrders = JsonConvert.DeserializeObject<List<CustomerOrder>>(results.Json);

            return customerOrders;
        }

        /// <summary>Gets a customer order based on passed order id.</summary>
        /// <exception cref="Exception">Thrown when the call is not successful.</exception>
        /// <param name="orderId">Id of the order to get.</param>
        /// <returns>The CustomerOrder.</returns>
        public CustomerOrder GetByOrderId(int orderId)
        {
            CallResults results = AJAX.CallAPI($"{CUSTOMERORDER_API_URL}{orderId}", Constants.enumRESTVerb.GET);

            if(!results.Success)
            {
                throw new Exception($"Error {MethodBase.GetCurrentMethod().Name} - the error is {results.ErrorMessage}");
            }

            CustomerOrder order = JsonConvert.DeserializeObject<CustomerOrder>(results.Json);

            return order;
        }

        /// <summary>Creates a new CustomerOrder through the API</summary>
        /// <exception cref="Exception">Thrown when the call is not successful.</exception>
        /// <param name="newOrder">NewCustomerOrder instance to create order from.</param>
        /// <returns>The uid of the newly created CustomerOrder.</returns>
        public int Create(NewCustomerOrder newOrder)
        {
            string json = JsonConvert.SerializeObject(newOrder);

            CallResults results = AJAX.CallAPI(CUSTOMERORDER_API_URL, Constants.enumRESTVerb.POST, json);

            if(!results.Success || !int.TryParse(results.Json, out int orderId))
            {
                throw new Exception($"Error {MethodBase.GetCurrentMethod().Name} - the error is {results.ErrorMessage}");
            }

            return orderId;
        }
    }
}