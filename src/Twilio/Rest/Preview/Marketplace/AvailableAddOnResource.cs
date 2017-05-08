using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Marketplace 
{

    /// <summary>
    /// AvailableAddOnResource
    /// </summary>
    public class AvailableAddOnResource : Resource 
    {
        private static Request BuildFetchRequest(FetchAvailableAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/marketplace/AvailableAddOns/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch an instance of an Add-on currently available to be installed.
        /// </summary>
        ///
        /// <param name="options"> Fetch AvailableAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOn </returns> 
        public static AvailableAddOnResource Fetch(FetchAvailableAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of an Add-on currently available to be installed.
        /// </summary>
        ///
        /// <param name="options"> Fetch AvailableAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOn </returns> 
        public static async System.Threading.Tasks.Task<AvailableAddOnResource> FetchAsync(FetchAvailableAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch an instance of an Add-on currently available to be installed.
        /// </summary>
        ///
        /// <param name="pathSid"> The unique Available Add-on Sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOn </returns> 
        public static AvailableAddOnResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAvailableAddOnOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch an instance of an Add-on currently available to be installed.
        /// </summary>
        ///
        /// <param name="pathSid"> The unique Available Add-on Sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOn </returns> 
        public static async System.Threading.Tasks.Task<AvailableAddOnResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAvailableAddOnOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadAvailableAddOnOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/marketplace/AvailableAddOns",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of Add-ons currently available to be installed.
        /// </summary>
        ///
        /// <param name="options"> Read AvailableAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOn </returns> 
        public static ResourceSet<AvailableAddOnResource> Read(ReadAvailableAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<AvailableAddOnResource>.FromJson("available_add_ons", response.Content);
            return new ResourceSet<AvailableAddOnResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of Add-ons currently available to be installed.
        /// </summary>
        ///
        /// <param name="options"> Read AvailableAddOn parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOn </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AvailableAddOnResource>> ReadAsync(ReadAvailableAddOnOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AvailableAddOnResource>.FromJson("available_add_ons", response.Content);
            return new ResourceSet<AvailableAddOnResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of Add-ons currently available to be installed.
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AvailableAddOn </returns> 
        public static ResourceSet<AvailableAddOnResource> Read(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAvailableAddOnOptions{PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of Add-ons currently available to be installed.
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AvailableAddOn </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AvailableAddOnResource>> ReadAsync(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadAvailableAddOnOptions{PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<AvailableAddOnResource> NextPage(Page<AvailableAddOnResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AvailableAddOnResource>.FromJson("available_add_ons", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a AvailableAddOnResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AvailableAddOnResource object represented by the provided JSON </returns> 
        public static AvailableAddOnResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AvailableAddOnResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Add-on
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// A description of this Add-on
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// A short description of the Add-on functionality
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }
        /// <summary>
        /// The way customers are charged for using this Add-on
        /// </summary>
        [JsonProperty("pricing_type")]
        public string PricingType { get; private set; }
        /// <summary>
        /// The JSON Schema describing the Add-on's configuration
        /// </summary>
        [JsonProperty("configuration_schema")]
        public object ConfigurationSchema { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private AvailableAddOnResource()
        {

        }
    }

}