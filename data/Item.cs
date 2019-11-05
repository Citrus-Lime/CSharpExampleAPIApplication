// <copyright file="Item.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data
{
    using System;

    /// <summary>Class representation of an item.</summary>
    public class Item
    {
        /// <summary>Gets or sets the UID of the item.</summary>
        /// <value>The UID.</value>
        public int Uid { get; set; }

        /// <summary>Gets or sets the item's lookup code.</summary>
        /// <value>The item lookup code.</value>
        public string ItemLookupCode { get; set; }

        /// <summary>Gets or sets the description of the item.</summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>Gets or sets the barcode description for the item.</summary>
        /// <value>Information barcode description.</value>
        public string BarcodeDescription { get; set; }

        /// <summary>Gets or sets whether the item isn't discountable.</summary>
        /// <value>True if item not discountable, false if not.</value>
        public bool ItemNotDiscountable { get; set; }

        /// <summary>Gets or sets the Date/Time the item was last updated.</summary>
        /// <value>When the item was last updated.</value>
        public DateTime LastUpdated { get; set; }

        /// <summary>Gets or sets any notes on the item.</summary>
        /// <value>The notes.</value>
        public string Notes { get; set; }

        /// <summary>Gets or sets the Department id for the item.</summary>
        /// <value>The department id.</value>
        public int DepartmentId { get; set; }

        /// <summary>Gets or sets the Category id for the item.</summary>
        /// <value>The category id.</value>
        public int CategoryId { get; set; }

        /// <summary>Gets or sets the brand id for the item.</summary>
        /// <value>The brand id.</value>
        public int? Brand { get; set; }

        /// <summary>Gets or sets the gender of the item.</summary>
        /// <value>The gender.</value>
        public int Gender { get; set; }

        /// <summary>Gets or sets the season id for the item.</summary>
        /// <value>The season id.</value>
        public int? Season { get; set; }

        /// <summary>Gets or sets the cost of the item.</summary>
        /// <value>The cost.</value>
        public decimal Cost { get; set; }

        /// <summary>Gets or sets the price of the item.</summary>
        /// <value>The price.</value>
        public decimal Price { get; set; }

        /// <summary>Gets or sets the msrp of the item.</summary>
        /// <value>The msrp.</value>
        public decimal MSRP { get; set; }

        /// <summary>Gets or sets the price at Price Level A for the item.</summary>
        /// <value>The price at price level A.</value>
        public decimal PriceA { get; set; }

        /// <summary>Gets or sets the price at Price Level B for the item.</summary>
        /// <value>The price at price level B.</value>
        public decimal PriceB { get; set; }

        /// <summary>Gets or sets the price at Price Level C for the item.</summary>
        /// <value>The price at price level C.</value>
        public decimal PriceC { get; set; }

        /// <summary>Gets or sets the price at Price Level D for the item.</summary>
        /// <value>The price at price level D.</value>
        public decimal PriceD { get; set; }

        /// <summary>Gets or sets the price at Price Level E for the item.</summary>
        /// <value>The price at price level E.</value>
        public decimal PriceE { get; set; }

        /// <summary>Gets or sets the ebay price for the item.</summary>
        /// <value>The ebay price.</value>
        public decimal EbayPrice { get; set; }

        /// <summary>Gets or sets the amazon price for the item.</summary>
        /// <value>The amazon price.</value>
        public decimal AmazonPrice { get; set; }

        /// <summary>Gets or sets the website price of the item.</summary>
        /// <value>The website price.</value>
        public decimal WebsitePrice { get; set; }

        /// <summary>Gets or sets whether the item is on sale.</summary>
        /// <value>The on sale.</value>
        public bool? OnSale { get; set; }

        /// <summary>Gets or sets the sale price of the item when it is on sale.</summary>
        /// <value>The sale price.</value>
        public decimal SalePrice { get; set; }

        /// <summary>Gets or sets the sale start date.</summary>
        /// <value>The sale start date.</value>
        public DateTime? SaleStartDate { get; set; }

        /// <summary>Gets or sets the sale end date.</summary>
        /// <value>The sale end date.</value>
        public DateTime? SaleEndDate { get; set; }

        /// <summary>Gets or sets the tax rate id for the item.</summary>
        /// <value>The tax rate id.</value>
        public int TaxId { get; set; }

        /// <summary>Gets or sets the type of the item.</summary>
        /// <value>The type of the item.</value>
        public int ItemType { get; set; }

        /// <summary>Gets or sets the tare weight of the item.</summary>
        /// <value>The tare weight.</value>
        public decimal TareWeight { get; set; }

        /// <summary>Gets or sets the weight of the item.</summary>
        /// <value>The weight.</value>
        public decimal Weight { get; set; }

        /// <summary>Gets or sets the id of the supplier of the item.</summary>
        /// <value>The supplier id.</value>
        public int SupplierId { get; set; }

        /// <summary>Gets or sets the Date/Time the item was last sold.</summary>
        /// <value>The date the item was last sold.</value>
        public DateTime? LastSold { get; set; }

        /// <summary>Gets or sets the extended description of the item.</summary>
        /// <value>The extended description.</value>
        public string ExtendedDescription { get; set; }

        /// <summary>Gets or sets whether quantity entry is allowed on the POS.</summary>
        /// <value>True if quantity entry not allowed, false if not.</value>
        public bool QuantityEntryNotAllowed { get; set; }

        /// <summary>Gets or sets whether a price must be entered on POS.</summary>
        /// <value>True if price must be entered, false if not.</value>
        public bool PriceMustBeEntered { get; set; }

        /// <summary>Gets or sets the item is active.</summary>
        /// <value>True if active, false if not.</value>
        public bool Active { get; set; }

        /// <summary>Gets or sets whether the item should not be ordered.</summary>
        /// <value>True if do not order, false if not.</value>
        public bool DoNotOrder { get; set; }

        /// <summary>Gets or sets the date the item was created.</summary>
        /// <value>The date created.</value>
        public DateTime DateCreated { get; set; }

        /// <summary>Gets or sets the date the price was last changed.</summary>
        /// <value>The date the price was changed.</value>
        public DateTime? Price_Changed { get; set; }

        /// <summary>Gets or sets the date the MSRP was last changed.</summary>
        /// <value>The date the MSRP was changed.</value>
        public DateTime? MSRP_Changed { get; set; }

        /// <summary>Gets or sets the date the sale price was last changed.</summary>
        /// <value>The date the sale price was changed.</value>
        public DateTime? SalePrice_Changed { get; set; }

        /// <summary>Gets or sets the date the price at Price Level A was last changed.</summary>
        /// <value>The date the price at Price Level A was changed.</value>
        public DateTime? PriceA_Changed { get; set; }

        /// <summary>Gets or sets the date the price at Price Level B was last changed.</summary>
        /// <value>The date the price at Price Level B was changed.</value>
        public DateTime? PriceB_Changed { get; set; }

        /// <summary>Gets or sets the date the price at Price Level C was last changed.</summary>
        /// <value>The date the price at Price Level C was changed.</value>
        public DateTime? PriceC_Changed { get; set; }

        /// <summary>Gets or sets the date the price at Price Level D was last changed.</summary>
        /// <value>The date the price at Price Level D was changed.</value>
        public DateTime? PriceD_Changed { get; set; }

        /// <summary>Gets or sets the date the price at Price Level E was last changed.</summary>
        /// <value>The date the price at Price Level E was changed.</value>
        public DateTime? PriceE_Changed { get; set; }

        /// <summary>Gets or sets the date the amazon price was last changed.</summary>
        /// <value>The date the amazon price was changed.</value>
        public DateTime? PriceAmazon_Changed { get; set; }

        /// <summary>Gets or sets the date the ebay price was last changed.</summary>
        /// <value>The date the ebay price was changed.</value>
        public DateTime? PriceEbay_Changed { get; set; }

        /// <summary>Gets or sets the date the website price was last changed.</summary>
        /// <value>The date the website price was changed.</value>
        public DateTime? WebsitePrice_Changed { get; set; }

        /// <summary>Gets or sets whether the item was imported from SIM.</summary>
        /// <value>True if item was SIM imported.</value>
        public bool? SIMImported { get; set; }

        /// <summary>Gets or sets the date the item was imported from SIM.</summary>
        /// <value>The SIM import date.</value>
        public DateTime? SIMImportDate { get; set; }

        /// <summary>Gets or sets whether the item should be updated from SIM.</summary>
        /// <value>True if item should be updated from SIM.</value>
        public bool? UpdateFromSIM { get; set; }

        /// <summary>Gets or sets the date the item was last updated from SIM.</summary>
        /// <value>The date of the last update.</value>
        public DateTime? LastUpdateFromSIM { get; set; }

        /// <summary>Gets or sets the label mode.</summary>
        /// <value>The label mode.</value>
        public int LabelMode { get; set; }

        /// <summary>Gets or sets the matrix code of the item.</summary>
        /// <value>The matrix code.</value>
        public string MatrixCode { get; set; }

        /// <summary>Gets or sets the matrix description.</summary>
        /// <value>Information describing the matrix.</value>
        public string MatrixDescription { get; set; }

        /// <summary>Gets or sets the value of dimension 1 of a matrix item.</summary>
        /// <value>The dimension 1 value.</value>
        public string Dimension1 { get; set; }

        /// <summary>Gets or sets the value of dimension 2 of a matrix item.</summary>
        /// <value>The dimension 2 value.</value>
        public string Dimension2 { get; set; }

        /// <summary>Gets or sets the value of dimension 3 of a matrix item.</summary>
        /// <value>The dimension 3 value.</value>
        public string Dimension3 { get; set; }

        /// <summary>Gets or sets the supplier part code of the item.</summary>
        /// <value>The supplier part code.</value>
        public string SupplierCode { get; set; }

        /// <summary>Gets or sets the supplier master pack quantity.</summary>
        /// <value>The supplier master pack quantity.</value>
        public int SupplierMasterPackQuantity { get; set; }

        /// <summary>Gets or sets the supplier minimum order value.</summary>
        /// <value>The supplier minimum order value.</value>
        public decimal SupplierMinimumOrder { get; set; }

        /// <summary>Gets or sets the supplier tax id.</summary>
        /// <value>The supplier tax id.</value>
        public int SupplierTaxId { get; set; }
    }
}