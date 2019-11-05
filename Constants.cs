// <copyright file="Constants.cs" company="CitrusLime Ltd">
// Copyright (c) CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication
{
    /// <summary>Constants.</summary>
    public class Constants
    {
        /// <summary>The API key.</summary>
        public const string API_KEY = "YOUR API KEY HERE";

        /// <summary>Identifier for the customer to get from the API.</summary>
        public const int CUSTOMER_ID = 0;

        /// <summary>The name of the application.</summary>
        /// <remarks>An order will be created based on this name and the current time.</remarks>
        public const string APP_NAME = "My App";

        /// <summary>Values that represent REST verbs.</summary>
        public enum enumRESTVerb
        {
            /// <summary>An enum constant representing the get option.</summary>
            GET,

            /// <summary>An enum constant representing the put option.</summary>
            PUT,

            /// <summary>An enum constant representing the post option.</summary>
            POST,
        };

        /// <summary>Values that represent API call status.</summary>
        public enum enumApiCallStatus
        {
            /// <summary>An enum constant representing the success status.</summary>
            SUCCESS,

            /// <summary>An enum constant representing the server error status.</summary>
            SERVER_ERROR,

            /// <summary>An enum constant representing the not found status.</summary>
            NOT_FOUND,

            /// <summary>An enum constant representing the not authenticated status.</summary>
            NOT_AUTHENTICATED,
        }
    }
}