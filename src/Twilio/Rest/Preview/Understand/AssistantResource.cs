/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
///
/// AssistantResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Preview.Understand
{

    public class AssistantResource : Resource
    {
        private static Request BuildFetchRequest(FetchAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Fetch(FetchAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> FetchAsync(FetchAssistantOptions options,
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAssistantOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> FetchAsync(string pathSid,
                                                                                      ITwilioRestClient client = null)
        {
            var options = new FetchAssistantOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Preview,
                "/understand/Assistants",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static ResourceSet<AssistantResource> Read(ReadAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<AssistantResource>.FromJson("assistants", response.Content);
            return new ResourceSet<AssistantResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssistantResource>> ReadAsync(ReadAssistantOptions options,
                                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AssistantResource>.FromJson("assistants", response.Content);
            return new ResourceSet<AssistantResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static ResourceSet<AssistantResource> Read(int? pageSize = null,
                                                          long? limit = null,
                                                          ITwilioRestClient client = null)
        {
            var options = new ReadAssistantOptions(){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<AssistantResource>> ReadAsync(int? pageSize = null,
                                                                                                  long? limit = null,
                                                                                                  ITwilioRestClient client = null)
        {
            var options = new ReadAssistantOptions(){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<AssistantResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AssistantResource>.FromJson("assistants", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<AssistantResource> NextPage(Page<AssistantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AssistantResource>.FromJson("assistants", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<AssistantResource> PreviousPage(Page<AssistantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Preview,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AssistantResource>.FromJson("assistants", response.Content);
        }

        private static Request BuildCreateRequest(CreateAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/understand/Assistants",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Create(CreateAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> CreateAsync(CreateAssistantOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> A text description for the Assistant. It is non-unique and can up to 255 characters
        ///                    long. </param>
        /// <param name="logQueries"> A boolean that specifies whether queries should be logged for 30 days further training.
        ///                  If false, no queries will be stored, if true, queries will be stored for 30 days and deleted
        ///                  thereafter. Defaults to true if no value is provided. </param>
        /// <param name="uniqueName"> A user-provided string that uniquely identifies this resource as an alternative to the
        ///                  sid. Unique up to 64 characters long. </param>
        /// <param name="callbackUrl"> A user-provided URL to send event callbacks to. </param>
        /// <param name="callbackEvents"> Space-separated list of callback events that will trigger callbacks. </param>
        /// <param name="fallbackActions"> The JSON actions to be executed when the user's input is not recognized as matching
        ///                       any Task. </param>
        /// <param name="initiationActions"> The JSON actions to be executed on inbound phone calls when the Assistant has to
        ///                         say something first. </param>
        /// <param name="styleSheet"> The JSON object that holds the style sheet for the assistant </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Create(string friendlyName = null,
                                               bool? logQueries = null,
                                               string uniqueName = null,
                                               Uri callbackUrl = null,
                                               string callbackEvents = null,
                                               object fallbackActions = null,
                                               object initiationActions = null,
                                               object styleSheet = null,
                                               ITwilioRestClient client = null)
        {
            var options = new CreateAssistantOptions(){FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, FallbackActions = fallbackActions, InitiationActions = initiationActions, StyleSheet = styleSheet};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> A text description for the Assistant. It is non-unique and can up to 255 characters
        ///                    long. </param>
        /// <param name="logQueries"> A boolean that specifies whether queries should be logged for 30 days further training.
        ///                  If false, no queries will be stored, if true, queries will be stored for 30 days and deleted
        ///                  thereafter. Defaults to true if no value is provided. </param>
        /// <param name="uniqueName"> A user-provided string that uniquely identifies this resource as an alternative to the
        ///                  sid. Unique up to 64 characters long. </param>
        /// <param name="callbackUrl"> A user-provided URL to send event callbacks to. </param>
        /// <param name="callbackEvents"> Space-separated list of callback events that will trigger callbacks. </param>
        /// <param name="fallbackActions"> The JSON actions to be executed when the user's input is not recognized as matching
        ///                       any Task. </param>
        /// <param name="initiationActions"> The JSON actions to be executed on inbound phone calls when the Assistant has to
        ///                         say something first. </param>
        /// <param name="styleSheet"> The JSON object that holds the style sheet for the assistant </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> CreateAsync(string friendlyName = null,
                                                                                       bool? logQueries = null,
                                                                                       string uniqueName = null,
                                                                                       Uri callbackUrl = null,
                                                                                       string callbackEvents = null,
                                                                                       object fallbackActions = null,
                                                                                       object initiationActions = null,
                                                                                       object styleSheet = null,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new CreateAssistantOptions(){FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, FallbackActions = fallbackActions, InitiationActions = initiationActions, StyleSheet = styleSheet};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Update(UpdateAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> UpdateAsync(UpdateAssistantOptions options,
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="friendlyName"> A text description for the Assistant. It is non-unique and can up to 255 characters
        ///                    long. </param>
        /// <param name="logQueries"> A boolean that specifies whether queries should be logged for 30 days further training.
        ///                  If false, no queries will be stored, if true, queries will be stored for 30 days and deleted
        ///                  thereafter. Defaults to true if no value is provided. </param>
        /// <param name="uniqueName"> A user-provided string that uniquely identifies this resource as an alternative to the
        ///                  sid. Unique up to 64 characters long. </param>
        /// <param name="callbackUrl"> A user-provided URL to send event callbacks to. </param>
        /// <param name="callbackEvents"> Space-separated list of callback events that will trigger callbacks. </param>
        /// <param name="fallbackActions"> The JSON actions to be executed when the user's input is not recognized as matching
        ///                       any Task. </param>
        /// <param name="initiationActions"> The JSON actions to be executed on inbound phone calls when the Assistant has to
        ///                         say something first. </param>
        /// <param name="styleSheet"> The JSON object that holds the style sheet for the assistant </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static AssistantResource Update(string pathSid,
                                               string friendlyName = null,
                                               bool? logQueries = null,
                                               string uniqueName = null,
                                               Uri callbackUrl = null,
                                               string callbackEvents = null,
                                               object fallbackActions = null,
                                               object initiationActions = null,
                                               object styleSheet = null,
                                               ITwilioRestClient client = null)
        {
            var options = new UpdateAssistantOptions(pathSid){FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, FallbackActions = fallbackActions, InitiationActions = initiationActions, StyleSheet = styleSheet};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="friendlyName"> A text description for the Assistant. It is non-unique and can up to 255 characters
        ///                    long. </param>
        /// <param name="logQueries"> A boolean that specifies whether queries should be logged for 30 days further training.
        ///                  If false, no queries will be stored, if true, queries will be stored for 30 days and deleted
        ///                  thereafter. Defaults to true if no value is provided. </param>
        /// <param name="uniqueName"> A user-provided string that uniquely identifies this resource as an alternative to the
        ///                  sid. Unique up to 64 characters long. </param>
        /// <param name="callbackUrl"> A user-provided URL to send event callbacks to. </param>
        /// <param name="callbackEvents"> Space-separated list of callback events that will trigger callbacks. </param>
        /// <param name="fallbackActions"> The JSON actions to be executed when the user's input is not recognized as matching
        ///                       any Task. </param>
        /// <param name="initiationActions"> The JSON actions to be executed on inbound phone calls when the Assistant has to
        ///                         say something first. </param>
        /// <param name="styleSheet"> The JSON object that holds the style sheet for the assistant </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<AssistantResource> UpdateAsync(string pathSid,
                                                                                       string friendlyName = null,
                                                                                       bool? logQueries = null,
                                                                                       string uniqueName = null,
                                                                                       Uri callbackUrl = null,
                                                                                       string callbackEvents = null,
                                                                                       object fallbackActions = null,
                                                                                       object initiationActions = null,
                                                                                       object styleSheet = null,
                                                                                       ITwilioRestClient client = null)
        {
            var options = new UpdateAssistantOptions(pathSid){FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, FallbackActions = fallbackActions, InitiationActions = initiationActions, StyleSheet = styleSheet};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Preview,
                "/understand/Assistants/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static bool Delete(DeleteAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAssistantOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns>
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAssistantOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAssistantOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a AssistantResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AssistantResource object represented by the provided JSON </returns>
        public static AssistantResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AssistantResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique ID of the Account that created this Assistant.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The date that this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// A text description for the Assistant. It is non-unique and can up to 255 characters long.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The unique ID (Sid) of the latest model build. Null if no model has been built.
        /// </summary>
        [JsonProperty("latest_model_build_sid")]
        public string LatestModelBuildSid { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// A boolean that specifies whether queries should be logged for 30 days further training. If false, no queries will be stored, if true, queries will be stored for 30 days and deleted thereafter.
        /// </summary>
        [JsonProperty("log_queries")]
        public bool? LogQueries { get; private set; }
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// A user-provided string that uniquely identifies this resource as an alternative to the sid. You can use the unique name in the URL path. Unique up to 64 characters long.
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// A user-provided URL to send event callbacks to.
        /// </summary>
        [JsonProperty("callback_url")]
        public Uri CallbackUrl { get; private set; }
        /// <summary>
        /// Space-separated list of callback events that will trigger callbacks.
        /// </summary>
        [JsonProperty("callback_events")]
        public string CallbackEvents { get; private set; }

        private AssistantResource()
        {

        }
    }

}