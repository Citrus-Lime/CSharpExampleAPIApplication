// <copyright file="Store.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data
{
    /// <summary>Class representing a store.</summary>
    public class Store
    {
        /// <summary>Gets or sets the UID of the store.</summary>
        /// <value>The UID.</value>
        public int Uid { get; set; }

        /// <summary>Gets or sets the name of the store.</summary>
        /// <value>The name of the store.</value>
        public string Store_Name { get; set; }

        /// <summary>Gets or sets the street 1 value of the store address.</summary>
        /// <value>The street 1 value.</value>
        public string Street1 { get; set; }

        /// <summary>Gets or sets the street 2 value of the store address.</summary>
        /// <value>The street 2 value.</value>
        public string Street2 { get; set; }

        /// <summary>Gets or sets the city of the store address.</summary>
        /// <value>The city.</value>
        public string City { get; set; }

        /// <summary>Gets or sets the state of the store address.</summary>
        /// <value>The state.</value>
        public string State { get; set; }

        /// <summary>Gets or sets the country of the store address.</summary>
        /// <value>The country.</value>
        public string Country { get; set; }

        /// <summary>Gets or sets the postcode of the store address.</summary>
        /// <value>The postcode.</value>
        public string Postcode { get; set; }

        /// <summary>Gets or sets the vat number.</summary>
        /// <value>The vat number.</value>
        public string VAT_Number { get; set; }

        /// <summary>Gets or sets the company number.</summary>
        /// <value>The company number.</value>
        public string Company_Number { get; set; }

        /// <summary>Gets or sets the phone number for the store.</summary>
        /// <value>The phone number.</value>
        public string Phone_Number { get; set; }

        /// <summary>Gets or sets the customer services email for the store.</summary>
        /// <value>The customer services email.</value>
        public string Customer_Services_Email { get; set; }

        /// <summary>Gets or sets the filename of the logo file.</summary>
        /// <value>The filename of the logo file.</value>
        public string Logo_FileName { get; set; }

        /// <summary>Gets or sets the comment for the first A4 receipt comment.</summary>
        /// <value>First A4 Receipt comment.</value>
        public string A4ReceiptComment1 { get; set; }

        /// <summary>Gets or sets the comment for the second A4 receipt comment.</summary>
        /// <value>Second A4 Receipt comment.</value>
        public string A4ReceiptComment2 { get; set; }

        /// <summary>Gets or sets the comment for the third A4 receipt comment.</summary>
        /// <value>Third A4 Receipt comment.</value>
        public string A4ReceiptComment3 { get; set; }

        /// <summary>Gets or sets the title for the first A4 receipt comment.</summary>
        /// <value>First A4 Receipt title.</value>
        public string A4ReceiptCommentTitle1 { get; set; }

        /// <summary>Gets or sets the title for the second A4 receipt comment.</summary>
        /// <value>Second A4 Receipt title.</value>
        public string A4ReceiptCommentTitle2 { get; set; }

        /// <summary>Gets or sets the title for the third A4 receipt comment.</summary>
        /// <value>Third A4 Receipt title.</value>
        public string A4ReceiptCommentTitle3 { get; set; }

        /// <summary>Gets or sets the web address.</summary>
        /// <value>The web address.</value>
        public string WebAddress { get; set; }

        /// <summary>Gets or sets the google map link.</summary>
        /// <value>The google map link.</value>
        public string GoogleMapLink { get; set; }

        /// <summary>Gets or sets whether Amazon intergration is enabled.</summary>
        /// <value>True if Amazon intergration enabled, false if not.</value>
        public bool AmazonIntergrationEnabled { get; set; }

        /// <summary>Gets or sets whether Ebay intergration is enabled.</summary>
        /// <value>True if Ebay intergration enabled, false if not.</value>
        public bool eBayIntergrationEnabled { get; set; }

        /// <summary>Gets or sets the client reference.</summary>
        /// <value>The client reference.</value>
        public int ClientRef { get; set; }

        /// <summary>Gets or sets the store client code.</summary>
        /// <value>The store client code.</value>
        public string StoreClientCode { get; set; }

    }
}
