// <copyright file="CustomerOrderItem.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data
{
    /// <summary>Class representing an item in a customer order.</summary>
    public class CustomerOrderItem
    {
        /// <summary>Gets or sets the description of the item.</summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>Gets or sets the price per unit of the item.</summary>
        /// <value>The unitprice.</value>
        public double UnitPrice { get; set; }

        /// <summary>Gets or sets the item's unique Item Lookup Code.</summary>
        /// <value>The code.</value>
        public string Code { get; set; }

        /// <summary>Gets or sets the quantity of the item in the order.</summary>
        /// <value>The quantity.</value>
        public int Quantity { get; set; }

        /// <summary>Gets or sets any comment on the item.</summary>
        /// <value>The comment.</value>
        public string Comment { get; set; }
    }
}