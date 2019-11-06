// <copyright file="AJAX.cs" company="CitrusLime Ltd">
// Copyright (c) CitrusLime Ltd. All rights reserved.
// </copyright>
namespace CitrusLime.CloudPOS.Api.CSharpSampleApplication.Ajax
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;
    using Newtonsoft.Json;
    using static CitrusLime.CloudPOS.Api.CSharpSampleApplication.Constants;

    /// <summary>AJAX methods.</summary>
    public class AJAX
    {
        /// <summary>Call the CloudPOS API.</summary>
        /// <param name="uri">The uri to call.</param>
        /// <param name="action">The action to perform.</param>
        /// <param name="jsonToSend">The JSON to send.</param>
        /// <returns>The CallResults.</returns>
        public static CallResults CallAPI(string uri, enumRESTVerb action, string jsonToSend = "")
        {
            CallResults results = new CallResults();

            string appendOrQueryString = uri.Contains("?") ? "&": "?";

            string pagedUrl = string.Format("{0}{1}pageNumber=", uri, appendOrQueryString);

            string nextUrl = uri;

            do
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Constants.API_KEY);

                    StringContent content = new StringContent(jsonToSend, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = GetResponseFromAPI(client, nextUrl, action, content);

                    string data = response.Content.ReadAsStringAsync().Result;

                    if (response.IsSuccessStatusCode == true)
                    {
                        nextUrl = HandlePaging(response, pagedUrl);

                        results.JsonBuilder.Append(data);
                    }
                    else
                    {
                        results.ErrorMessage = data;

                        HandleBadResponse(response, ref nextUrl, ref results);
                    }
                }
            }
            while (nextUrl != string.Empty);

            results.JsonBuilder.Replace("][", ",");

            return results;
        }

        /// <summary>Gets a response from the API.</summary>
        /// <param name="client">The client.</param>
        /// <param name="uri">The uri to call.</param>
        /// <param name="action">The action to perform.</param>
        /// <param name="content">The content to post.</param>
        /// <returns>The response.</returns>
        private static HttpResponseMessage GetResponseFromAPI(HttpClient client, string uri, enumRESTVerb action, StringContent content)
        {
            HttpResponseMessage response = default(HttpResponseMessage);

            switch (action)
            {
                case enumRESTVerb.GET:
                    response = client.GetAsync(uri).Result;
                    break;

                case enumRESTVerb.POST:
                    response = client.PostAsync(uri, content).Result;
                    break;

                case enumRESTVerb.PUT:
                    response = client.PutAsync(uri, content).Result;
                    break;
            }

            return response;
        }

        /// <summary>Handles a bad response from the API.</summary>
        /// <param name="response">The response.</param>
        /// <param name="nextUri">[in,out] The next uri to call.</param>
        /// <param name="results">[in,out] The results.</param>
        private static void HandleBadResponse(HttpResponseMessage response, ref string nextUri, ref CallResults results)
        {
            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    nextUri = string.Empty;
                    results.Status = enumApiCallStatus.NOT_FOUND;
                    break;

                case (HttpStatusCode)429:
                    Thread.Sleep(1000);
                    break;

                case HttpStatusCode.Unauthorized:
                    nextUri = string.Empty;
                    results.Status = enumApiCallStatus.NOT_AUTHENTICATED;
                    break;

                default:
                    nextUri = string.Empty;
                    results.Status = enumApiCallStatus.SERVER_ERROR;
                    break;
            }
        }

        /// <summary>Handles the paging from the response.</summary>
        /// <param name="response">The response.</param>
        /// <param name="baseUrl">The base url.</param>
        /// <returns>A string containing the uri and the next page to get.</returns>
        private static string HandlePaging(HttpResponseMessage response, string baseUrl)
        {
            string nextUrl = string.Empty;

            if (response.Headers.TryGetValues("paging-headers", out IEnumerable<string> headers))
            {
                string pagingHeaders = headers.First();

                Paging paging = JsonConvert.DeserializeObject<Paging>(pagingHeaders);

                if (paging.TotalPages != paging.CurrentPage)
                {
                    nextUrl = string.Format("{0}{1}", baseUrl, paging.CurrentPage + 1);
                }
            }

            return nextUrl;
        }
    }
}
