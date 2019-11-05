// <copyright file="StoresService.cs" company="CitrusLime Ltd">
// Copyright (c) 2019 CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Classes
{
    using CitrusLime.CloudPOS.Api.CSharpSampleApplication.Ajax;
    using CitrusLime.CloudPOS.Api.CSharpSampleApplication.Data;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>A service for accessing stores' information.</summary>
    public class StoresService
    {
        /// <summary>The Store URL for the API calls.</summary>
        private const string STORES_API_URL = "https://cloudposapi.citruslime.com/api/Store";

        /// <summary>Gets all of the Stores for the group.</summary>
        /// <exception cref="Exception">Thrown when the call is not successful.</exception>
        /// <returns>A collection of all Stores for the group.</returns>
        public List<Store> GetAll()
        {
            CallResults results = AJAX.CallAPI(STORES_API_URL, Constants.enumRESTVerb.GET);

            if(!results.Success)
            {
                throw new Exception($"Error {System.Reflection.MethodBase.GetCurrentMethod().Name} - the error is {results.ErrorMessage}");
            }

            List<Store> stores = JsonConvert.DeserializeObject<List<Store>>(results.Json);

            return stores;
        }
    }
}
