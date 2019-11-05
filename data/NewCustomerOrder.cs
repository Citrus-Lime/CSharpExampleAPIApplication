// <copyright file="NewCustomerOrder.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data
{
    using System.Collections.Generic;

    /// <summary>Class representing a new customer order.</summary>
    public class NewCustomerOrder
    {
        /// <summary>Gets or sets the addresses associated with the customer order.</summary>
        /// <value>The addresses.</value>
        public List<CustomerOrderAddress> Addresses { get; set; }
            = new List<CustomerOrderAddress>();

        /// <summary>Gets or sets the items in the customer order.</summary>
        /// <value>The items.</value>
        public List<CustomerOrderItem> Items { get; set; }
            = new List<CustomerOrderItem>();

        /// <summary>Gets or sets the id of the customer order.</summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

        /// <summary>Gets or sets the tender type of the customer order.</summary>
        /// <value>The tendertype.</value>
        public string TenderType { get; set; }

        /// <summary>Gets or sets any comments on the customer order.</summary>
        /// <value>The comment.</value>
        public string Comment { get; set; }

        /// <summary>Gets or sets the shipping charge of the customer order.</summary>
        /// <value>The shippingcharge.</value>
        public int ShippingCharge { get; set; }

        /// <summary>Gets or sets whether the order has premium shipping</summary>
        /// <value>True if premiumshipping, false if not.</value>
        public bool PremiumShipping { get; set; }

        /// <summary>Gets or sets the channel type of the customer order.</summary>
        /// <value>The channeltype.</value>
        public string ChannelType { get; set; }

        /// <summary>Gets or sets the id of the third party transaction.</summary>
        /// <value>The id of the third party transaction.</value>
        public string ThirdPartyTransactionID { get; set; }

        /// <summary>Gets or sets the id of the third party order</summary>
        /// <value>The id of the third party order.</value>
        public string ThirdPartyOrderId { get; set; }

        /// <summary>Gets or sets the store client code for the customer order.</summary>
        /// <value>The store client code.</value>
        public string StoreClientCode { get; set; }
    }
}