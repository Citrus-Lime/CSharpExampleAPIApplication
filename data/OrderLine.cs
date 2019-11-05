// <copyright file="OrderLines.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data
{
    using System;

    /// <summary>Class representing a customer order line.</summary>
    public class OrderLine
    {
        /// <summary>Gets or sets the UID of the order line.</summary>
        /// <value>The UID.</value>
        public int uid { get; set; }

        /// <summary>Gets or sets the Id of the item associated with the order line.</summary>
        /// <value>The identifier of the item.</value>
        public int ItemId { get; set; }

        /// <summary>Gets or sets the cost of the item in the order line.</summary>
        /// <value>The cost.</value>
        public decimal Cost { get; set; }

        /// <summary>Gets or sets the full price of the items in the order line.</summary>
        /// <value>The full price.</value>
        public decimal FullPrice { get; set; }

        /// <summary>Gets or sets the price of the items in the order line.</summary>
        /// <value>The price.</value>
        public decimal Price { get; set; }

        /// <summary>Gets or sets the quantity of the item in the order line.</summary>
        /// <value>The quantity on order.</value>
        public decimal QuantityOnOrder { get; set; }

        /// <summary>Gets or sets the id of the sales rep associated with the order line.</summary>
        /// <value>The identifier of the sales rep.</value>
        public int SalesRepId { get; set; }

        /// <summary>Gets or sets whether the order line is taxable.</summary>
        /// <value>The taxable.</value>
        public int Taxable { get; set; }

        /// <summary>Gets or sets the description of the order line.</summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>Gets or sets the quantity rtd.</summary>
        /// <value>The quantity rtd.</value>
        public decimal QuantityRTD { get; set; }

        /// <summary>Gets or sets the Date/Time of the last updated.</summary>
        /// <value>The last updated.</value>
        public DateTime LastUpdated { get; set; }

        /// <summary>Gets or sets the comment.</summary>
        /// <value>The comment.</value>
        public string Comment { get; set; }
    }
}
