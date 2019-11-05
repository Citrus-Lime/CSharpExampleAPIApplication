// <copyright file="CustomerOrderAddressBuilder.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data
{
    /// <summary>A customer order address builder.</summary>
    public class CustomerOrderAddressBuilder
    {
        /// <summary>Generates a billing address from a customer.</summary>
        /// <param name="customerToUse">The customer to use.</param>
        /// <returns>The billing address for the customer.</returns>
        public static CustomerOrderAddress GenerateBillingAddressFromCustomer(Customer customerToUse)
        {
            CustomerOrderAddress orderAddress = MapAddressFromCustomer(customerToUse, "BILL");

            return orderAddress;
        }

        /// <summary>Generates a shipping address from a customer.</summary>
        /// <param name="customerToUse">The customer to use.</param>
        /// <returns>The shipping address for the customer.</returns>
        public static CustomerOrderAddress GenerateShippingAddressFromCustomer(Customer customerToUse)
        {
            CustomerOrderAddress orderAddress = MapAddressFromCustomer(customerToUse, "SHIP");

            return orderAddress;
        }

        /// <summary>Map an address from a customer to a customer order address.</summary>
        /// <param name="customerToMapFrom">The customer to map from.</param>
        /// <param name="addressType">A string to process.</param>
        /// <returns>A string.</returns>
        private static CustomerOrderAddress MapAddressFromCustomer(Customer customerToMapFrom, string addressType)
        {
            CustomerOrderAddress orderAddress = new CustomerOrderAddress()
            {
                Company = customerToMapFrom.Company,
                FirstName = customerToMapFrom.FirstName,
                LastName = customerToMapFrom.LastName,
                Address1 = customerToMapFrom.Address,
                Address2 = customerToMapFrom.Address2,
                City = customerToMapFrom.City,
                State = customerToMapFrom.State,
                Country = customerToMapFrom.Country,
                Postcode = customerToMapFrom.Postcode,
                Phone = customerToMapFrom.PhoneNumber,
                Email = customerToMapFrom.EmailAddress,
                Type = addressType,
            };

            return orderAddress;
        }
    }
}