// <copyright file="Customer.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data
{
    using System;

    /// <summary>Class representation of a customer.</summary>
    public class Customer
    {
        /// <summary>Gets or sets the UID of the customer.</summary>
        /// <value>The UID.</value>
        public int Uid { get; set; }

        /// <summary>Gets or sets the account number of the customer.</summary>
        /// <value>The account number.</value>
        public string AccountNumber { get; set; }

        /// <summary>Gets or sets the id of the account type the user has.</summary>
        /// <value>The id of the account type.</value>
        public int AccountTypeId { get; set; }

        /// <summary>Gets or sets the date the customer was last updated.</summary>
        /// <value>Date customer was last updated.</value>
        public DateTime? LastUpdated { get; set; }

        /// <summary>Gets or sets the id of the primary shipping address of the customer.</summary>
        /// <value>The id of the primary shipping address.</value>
        public int PrimaryShipToId { get; set; }

        /// <summary>Gets or sets whether the customer is an employee of the group.</summary>
        /// <value>True if employee, false if not.</value>
        public bool Employee { get; set; }

        /// <summary>Gets or sets the company the customer's address may be assigned to.</summary>
        /// <value>The company.</value>
        public string Company { get; set; }

        /// <summary>Gets or sets the customer's title.</summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>Gets or sets the customer's first name.</summary>
        /// <value>The customer's first name.</value>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the customer's last name.</summary>
        /// <value>The customer's last name.</value>
        public string LastName { get; set; }

        /// <summary>Gets or sets the customer's date of birth.</summary>
        /// <value>The date of birth.</value>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>Gets or sets the customer's gender.</summary>
        /// <value>The gender.</value>
        public int Gender { get; set; }

        /// <summary>Gets or sets the first line of the customer's address.</summary>
        /// <value>The first line of the address.</value>
        public string Address { get; set; }

        /// <summary>Gets or sets the second line of the customer's address.</summary>
        /// <value>The second line of the address.</value>
        public string Address2 { get; set; }

        /// <summary>Gets or sets the city of the customer's address.</summary>
        /// <value>The city.</value>
        public string City { get; set; }

        /// <summary>Gets or sets the state value of the customer's address</summary>
        /// <value>The state.</value>
        public string State { get; set; }

        /// <summary>Gets or sets the postcode of the customer's address.</summary>
        /// <value>The postcode.</value>
        public string Postcode { get; set; }

        /// <summary>Gets or sets the country of the customer's address.</summary>
        /// <value>The country.</value>
        public string Country { get; set; }

        /// <summary>Gets or sets the customer's email address.</summary>
        /// <value>The email address.</value>
        public string EmailAddress { get; set; }

        /// <summary>Gets or sets the customer's mobile number.</summary>
        /// <value>The mobile number.</value>
        public string MobileNumber { get; set; }

        /// <summary>Gets or sets the customer's phone number.</summary>
        /// <value>The phone number.</value>
        public string PhoneNumber { get; set; }

        /// <summary>Gets or sets the customer's fax number.</summary>
        /// <value>The fax number.</value>
        public string FaxNumber { get; set; }

        /// <summary>Gets or sets the customer's credit limit.</summary>
        /// <value>The credit limit.</value>
        public double CreditLimit { get; set; }

        /// <summary>Gets or sets the customer's total sale amount.</summary>
        /// <value>The total sale amount.</value>
        public double TotalSales { get; set; }

        /// <summary>Gets or sets the date the customer's account was opened.</summary>
        /// <value>When the account was opened.</value>
        public DateTime? AccountOpened { get; set; }

        /// <summary>Gets or sets the date of the customer's last visit.</summary>
        /// <value>The customer's last visit.</value>
        public DateTime LastVisit { get; set; }

        /// <summary>Gets or sets the total number of times the customer has visited the group.</summary>
        /// <value>The total number of visits.</value>
        public int TotalVisits { get; set; }

        /// <summary>Gets or sets the customer's total savings amount.</summary>
        /// <value>The total savings amount.</value>
        public double TotalSavings { get; set; }

        /// <summary>Gets or sets the current discount the customer may have applied to their transactions.</summary>
        /// <value>The current discount.</value>
        public double CurrentDiscount { get; set; }

        /// <summary>Gets or sets the price level the customer may have applied to their transactions.</summary>
        /// <value>The price level.</value>
        public int PriceLevel { get; set; }

        /// <summary>Gets or sets whether the customer is tax exempt or not.</summary>
        /// <value>True if tax exempt, false if not.</value>
        public bool TaxExempt { get; set; }

        /// <summary>Gets or sets the customer's tax number.</summary>
        /// <value>The tax number.</value>
        public string TaxNumber { get; set; }

        /// <summary>Gets or sets any notes against the customer.</summary>
        /// <value>The notes.</value>
        public string Notes { get; set; }

        /// <summary>Gets or sets the customer's contact preference.</summary>
        /// <value>The contact preference.</value>
        public int ContactPreference { get; set; }

        /// <summary>Gets or sets date of the last email statement sent to the customer.</summary>
        /// <value>The last email statement date.</value>
        public DateTime? LastEmailStatement { get; set; }

        /// <summary>Gets or sets whether the customer has opted into email notifications.</summary>
        /// <value>True if email option in, false if not.</value>
        public bool EmailOptIn { get; set; }

        /// <summary>Gets or sets the date which the customer opted into email notifications.</summary>
        /// <value>The option in date.</value>
        public DateTime? OptInDate { get; set; }
    }
}