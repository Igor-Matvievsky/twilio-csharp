/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// DayResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.BulkExports.Export
{

    public class DayResource : Resource
    {
        private static Request BuildReadRequest(ReadDayOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/BulkExports/Exports/" + options.PathResourceType + "/Days",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Days for a resource.
        /// </summary>
        /// <param name="options"> Read Day parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Day </returns>
        public static ResourceSet<DayResource> Read(ReadDayOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<DayResource>.FromJson("days", response.Content);
            return new ResourceSet<DayResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Days for a resource.
        /// </summary>
        /// <param name="options"> Read Day parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Day </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DayResource>> ReadAsync(ReadDayOptions options,
                                                                                            ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<DayResource>.FromJson("days", response.Content);
            return new ResourceSet<DayResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Days for a resource.
        /// </summary>
        /// <param name="pathResourceType"> The type of communication – Messages, Calls </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Day </returns>
        public static ResourceSet<DayResource> Read(string pathResourceType,
                                                    int? pageSize = null,
                                                    long? limit = null,
                                                    ITwilioRestClient client = null)
        {
            var options = new ReadDayOptions(pathResourceType){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Days for a resource.
        /// </summary>
        /// <param name="pathResourceType"> The type of communication – Messages, Calls </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Day </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<DayResource>> ReadAsync(string pathResourceType,
                                                                                            int? pageSize = null,
                                                                                            long? limit = null,
                                                                                            ITwilioRestClient client = null)
        {
            var options = new ReadDayOptions(pathResourceType){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<DayResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<DayResource>.FromJson("days", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<DayResource> NextPage(Page<DayResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<DayResource>.FromJson("days", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<DayResource> PreviousPage(Page<DayResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<DayResource>.FromJson("days", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a DayResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> DayResource object represented by the provided JSON </returns>
        public static DayResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<DayResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The redirect_to
        /// </summary>
        [JsonProperty("redirect_to")]
        public Uri RedirectTo { get; private set; }
        /// <summary>
        /// The date of the data in the file
        /// </summary>
        [JsonProperty("day")]
        public string Day { get; private set; }
        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        [JsonProperty("size")]
        public int? Size { get; private set; }
        /// <summary>
        /// The type of communication – Messages, Calls
        /// </summary>
        [JsonProperty("resource_type")]
        public string ResourceType { get; private set; }

        private DayResource()
        {

        }
    }

}