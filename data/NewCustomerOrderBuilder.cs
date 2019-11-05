// <copyright file="NewCustomerOrderBuilder.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data
{
    /// <summary>A new customer order builder.</summary>
    public class NewCustomerOrderBuilder
    {
        /// <summary>Builds a new customer order.</summary>
        /// <param name="uniqueReference">The unique reference of the order.</param>
        /// <param name="customerToUse">The customer to use.</param>
        /// <param name="storeCode">The store code.</param>
        /// <param name="comment">The comment for the order.</param>
        /// <returns>A CustomerOrder.</returns>
        public static NewCustomerOrder Build(string uniqueReference, Customer customerToUse,
                                             string storeCode, string comment)
        {
            NewCustomerOrder newOrder = new NewCustomerOrder()
            {
                Id = uniqueReference,
                ChannelType = "None",
                StoreClientCode = storeCode,
                Comment = comment,
                PremiumShipping = false
            };

            newOrder.Addresses.Add(CustomerOrderAddressBuilder.GenerateBillingAddressFromCustomer(customerToUse));
            newOrder.Addresses.Add(CustomerOrderAddressBuilder.GenerateShippingAddressFromCustomer(customerToUse));

            return newOrder;
        }
    }
}