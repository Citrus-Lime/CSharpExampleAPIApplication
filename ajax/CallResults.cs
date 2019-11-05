// <copyright file="CallResults.cs" company="CitrusLime Ltd">
// Copyright (c) CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Ajax
{
    using System.Text;
    using static CitrusLime.CloudPOS.Api.CSharpSampleApplication.Constants;

    /// <summary>API call results.</summary>
    public class CallResults
    {
        /// <summary>The status of the API call.</summary>
        public enumApiCallStatus Status;

        /// <summary>The JSON builder.</summary>
        public StringBuilder JsonBuilder;

        /// <summary>Gets the JSON from the string builder.</summary>
        /// <value>The JSON from the string builder.</value>
        public string Json => JsonBuilder.ToString();

        /// <summary>The error message.</summary>
        public string ErrorMessage;

        /// <summary>Gets a value indicating whether the API call was successful.</summary>
        /// <value>True if the API call was successful, false if not.</value>
        public bool Success
        {
            get
            {
                if (Status == enumApiCallStatus.SUCCESS)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>Initialises a new instance of the <see cref="CitrusLime.CloudPOS.Api.CSharpSampleApplication.Ajax.CallResults"/> class.</summary>
        public CallResults()
        {
            JsonBuilder = new StringBuilder();
        }
    }
}
