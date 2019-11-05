// <copyright file="CustomerOrder.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data
{
    using System;
    using System.Collections.Generic;

    /// <summary>Class representing a customer order.</summary>
    public class CustomerOrder
    {
        /// <summary>Gets or sets the UID.</summary>
        /// <value>The UID.</value>
        public int Uid { get; set; }

        /// <summary>Gets or sets the client reference.</summary>
        /// <value>The client reference.</value>
        public int ClientRef { get; set; }

        /// <summary>Gets or sets a whether the order is closed or not.</summary>
        /// <value>True if closed, false if not.</value>
        public bool Closed { get; set; }

        /// <summary>Gets or sets the date the order was created.</summary>
        /// <value>The date created.</value>
        public DateTime DateCreated { get; set; }

        /// <summary>Gets or sets the order type represented as an int</summary>
        /// <value>The type represented as an int.</value>
        public int Type { get; set; }

        /// <summary>Gets or sets any comments the order may have</summary>
        /// <value>The comments.</value>
        public string Comment { get; set; }

        /// <summary>Gets or sets the ID of the customer related to the order.</summary>
        /// <value>The identifier of the customer.</value>
        public int CustomerId { get; set; }

        /// <summary>Gets or sets the id of the customer the order should ship to.</summary>
        /// <value>The identifier of the ship to.</value>
        public int ShipToId { get; set; }

        /// <summary>Gets or sets the deposit that may be on the order.</summary>
        /// <value>The deposit.</value>
        public decimal Deposit { get; set; }

        /// <summary>Gets or sets the tax for the order.</summary>
        /// <value>The tax.</value>
        public decimal Tax { get; set; }

        /// <summary>Gets or sets total amount of the order.</summary>
        /// <value>The total.</value>
        public decimal Total { get; set; }

        /// <summary>Gets or sets when the order was last updated.</summary>
        /// <value>The last updated.</value>
        public DateTime LastUpdated { get; set; }

        /// <summary>Gets or sets the due date of the order.</summary>
        /// <value>The due date.</value>
        public DateTime DueDate { get; set; }

        /// <summary>Gets or sets whether the order is taxable or not.</summary>
        /// <value>True if taxable, false if not.</value>
        public bool Taxable { get; set; }

        /// <summary>Gets or sets the Id of the sales rep associated with the order.</summary>
        /// <value>The identifier of the sales rep.</value>
        public int SalesRepId { get; set; }

        /// <summary>Gets or sets any reference number associated with the order.</summary>
        /// <value>The reference number.</value>
        public string ReferenceNumber { get; set; }

        /// <summary>Gets or sets the shipping charge on order.</summary>
        /// <value>The shipping charge on order.</value>
        public double ShippingChargeOnOrder { get; set; }

        /// <summary>Gets or sets the channel type for the order.</summary>
        /// <value>The type of the channel.</value>
        public int ChannelType { get; set; }

        /// <summary>Gets or sets whether the order has been checked in.</summary>
        /// <value>True if checked in, false if not.</value>
        public bool CheckedIn { get; set; }

        /// <summary>Gets or sets the name of the customer.</summary>
        /// <value>The name of the customer.</value>
        public string CustomerName { get; set; }

        /// <summary>Gets or sets a collection of order lines for the order.</summary>
        /// <value>The order lines.</value>
        public List<OrderLine> OrderLines { get; set; }
            = new List<OrderLine>();
    }
}