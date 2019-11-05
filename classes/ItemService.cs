// <copyright file="ItemService.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Classes
{
    using CitrusLime.CloudPOS.Api.CSharpSampleApplication.Ajax;
    using CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>A service for accessing item information.</summary>
    public class ItemService
    {
        /// <summary>The Item URL for the API calls.</summary>
        private const string ITEM_API_URL = "https://cloudposapi.citruslime.com/api/Item";

        /// <summary>Gets all of the items for the group.</summary>
        /// <exception cref="Exception">Thrown when the call is not successful.</exception>
        /// <returns>A collection of all Items for the group.</returns>
        public List<Item> GetAll()
        {
            CallResults results = AJAX.CallAPI(ITEM_API_URL, Constants.enumRESTVerb.GET);

            if (!results.Success)
            {
                throw new Exception($"Error {System.Reflection.MethodBase.GetCurrentMethod().Name} - the error is {results.ErrorMessage}");
            }

            List<Item> items = JsonConvert.DeserializeObject<List<Item>>(results.Json);

            return items;
        }
    }
}