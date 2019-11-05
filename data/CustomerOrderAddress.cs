// <copyright file="CustomerOrderAddress.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data
{
    /// <summary>Class representing an address associated with a customer order.</summary>
    public class CustomerOrderAddress
    {
        /// <summary>Gets or sets the type of the address.</summary>
        /// <value>The type.</value>
        public string Type { get; set; }

        /// <summary>Gets or sets the first name of the customer the address belongs to.</summary>
        /// <value>The first name.</value>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the last name of the customer the address belongs to.</summary>
        /// <value>The last name.</value>
        public string LastName { get; set; }

        /// <summary>Gets or sets the first line of the address.</summary>
        /// <value>The address 1.</value>
        public string Address1 { get; set; }

        /// <summary>Gets or sets the second line of the address.</summary>
        /// <value>The address 2.</value>
        public string Address2 { get; set; }

        /// <summary>Gets or sets the city of the address.</summary>
        /// <value>The city.</value>
        public string City { get; set; }

        /// <summary>Gets or sets the state of the address.</summary>
        /// <value>The state.</value>
        public string State { get; set; }

        /// <summary>Gets or sets the postcode of the address.</summary>
        /// <value>The postcode.</value>
        public string Postcode { get; set; }

        /// <summary>Gets or sets the country of the address.</summary>
        /// <value>The country.</value>
        public string Country { get; set; }

        /// <summary>Gets or sets the phone number associated with the address.</summary>
        /// <value>The phone number.</value>
        public string Phone { get; set; }

        /// <summary>Gets or sets the email address associated with the address.</summary>
        /// <value>The email address.</value>
        public string Email { get; set; }

        /// <summary>Gets or sets the company associated with the address.</summary>
        /// <value>The company.</value>
        public string Company { get; set; }
    }
}
