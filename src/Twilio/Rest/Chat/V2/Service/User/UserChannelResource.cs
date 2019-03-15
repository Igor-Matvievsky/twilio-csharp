/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// UserChannelResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Chat.V2.Service.User 
{

    public class UserChannelResource : Resource 
    {
        public sealed class ChannelStatusEnum : StringEnum 
        {
            private ChannelStatusEnum(string value) : base(value) {}
            public ChannelStatusEnum() {}
            public static implicit operator ChannelStatusEnum(string value)
            {
                return new ChannelStatusEnum(value);
            }

            public static readonly ChannelStatusEnum Joined = new ChannelStatusEnum("joined");
            public static readonly ChannelStatusEnum Invited = new ChannelStatusEnum("invited");
            public static readonly ChannelStatusEnum NotParticipating = new ChannelStatusEnum("not_participating");
        }

        public sealed class NotificationLevelEnum : StringEnum 
        {
            private NotificationLevelEnum(string value) : base(value) {}
            public NotificationLevelEnum() {}
            public static implicit operator NotificationLevelEnum(string value)
            {
                return new NotificationLevelEnum(value);
            }

            public static readonly NotificationLevelEnum Default = new NotificationLevelEnum("default");
            public static readonly NotificationLevelEnum Muted = new NotificationLevelEnum("muted");
        }

        private static Request BuildReadRequest(ReadUserChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathServiceSid + "/Users/" + options.PathUserSid + "/Channels",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// List all Channels for a given User.
        /// </summary>
        /// <param name="options"> Read UserChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserChannel </returns> 
        public static ResourceSet<UserChannelResource> Read(ReadUserChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<UserChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<UserChannelResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// List all Channels for a given User.
        /// </summary>
        /// <param name="options"> Read UserChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserChannel </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<UserChannelResource>> ReadAsync(ReadUserChannelOptions options, 
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<UserChannelResource>.FromJson("channels", response.Content);
            return new ResourceSet<UserChannelResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// List all Channels for a given User.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resources from </param>
        /// <param name="pathUserSid"> The SID of the User to fetch the User Channel resources from </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserChannel </returns> 
        public static ResourceSet<UserChannelResource> Read(string pathServiceSid, 
                                                            string pathUserSid, 
                                                            int? pageSize = null, 
                                                            long? limit = null, 
                                                            ITwilioRestClient client = null)
        {
            var options = new ReadUserChannelOptions(pathServiceSid, pathUserSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// List all Channels for a given User.
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resources from </param>
        /// <param name="pathUserSid"> The SID of the User to fetch the User Channel resources from </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserChannel </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<UserChannelResource>> ReadAsync(string pathServiceSid, 
                                                                                                    string pathUserSid, 
                                                                                                    int? pageSize = null, 
                                                                                                    long? limit = null, 
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadUserChannelOptions(pathServiceSid, pathUserSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<UserChannelResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<UserChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<UserChannelResource> NextPage(Page<UserChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Chat,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<UserChannelResource>.FromJson("channels", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<UserChannelResource> PreviousPage(Page<UserChannelResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Chat,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<UserChannelResource>.FromJson("channels", response.Content);
        }

        private static Request BuildFetchRequest(FetchUserChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathServiceSid + "/Users/" + options.PathUserSid + "/Channels/" + options.PathChannelSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch UserChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserChannel </returns> 
        public static UserChannelResource Fetch(FetchUserChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch UserChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserChannel </returns> 
        public static async System.Threading.Tasks.Task<UserChannelResource> FetchAsync(FetchUserChannelOptions options, 
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
        /// <param name="pathServiceSid"> The SID of the Service to fetch the User Channel resource from </param>
        /// <param name="pathUserSid"> The SID of the User to fetch the User Channel resource from </param>
        /// <param name="pathChannelSid"> The SID of the Channel that has the User Channel to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserChannel </returns> 
        public static UserChannelResource Fetch(string pathServiceSid, 
                                                string pathUserSid, 
                                                string pathChannelSid, 
                                                ITwilioRestClient client = null)
        {
            var options = new FetchUserChannelOptions(pathServiceSid, pathUserSid, pathChannelSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the User Channel resource from </param>
        /// <param name="pathUserSid"> The SID of the User to fetch the User Channel resource from </param>
        /// <param name="pathChannelSid"> The SID of the Channel that has the User Channel to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserChannel </returns> 
        public static async System.Threading.Tasks.Task<UserChannelResource> FetchAsync(string pathServiceSid, 
                                                                                        string pathUserSid, 
                                                                                        string pathChannelSid, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchUserChannelOptions(pathServiceSid, pathUserSid, pathChannelSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateUserChannelOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Chat,
                "/v2/Services/" + options.PathServiceSid + "/Users/" + options.PathUserSid + "/Channels/" + options.PathChannelSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update UserChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserChannel </returns> 
        public static UserChannelResource Update(UpdateUserChannelOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update UserChannel parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserChannel </returns> 
        public static async System.Threading.Tasks.Task<UserChannelResource> UpdateAsync(UpdateUserChannelOptions options, 
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
        /// <param name="pathServiceSid"> The SID of the Service to update the resource from </param>
        /// <param name="pathUserSid"> The SID of the User to update the User Channel resource from </param>
        /// <param name="pathChannelSid"> The SID of the Channel with the User Channel resource to update </param>
        /// <param name="notificationLevel"> The push notification level to assign to the User Channel </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of UserChannel </returns> 
        public static UserChannelResource Update(string pathServiceSid, 
                                                 string pathUserSid, 
                                                 string pathChannelSid, 
                                                 UserChannelResource.NotificationLevelEnum notificationLevel, 
                                                 ITwilioRestClient client = null)
        {
            var options = new UpdateUserChannelOptions(pathServiceSid, pathUserSid, pathChannelSid, notificationLevel);
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to update the resource from </param>
        /// <param name="pathUserSid"> The SID of the User to update the User Channel resource from </param>
        /// <param name="pathChannelSid"> The SID of the Channel with the User Channel resource to update </param>
        /// <param name="notificationLevel"> The push notification level to assign to the User Channel </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of UserChannel </returns> 
        public static async System.Threading.Tasks.Task<UserChannelResource> UpdateAsync(string pathServiceSid, 
                                                                                         string pathUserSid, 
                                                                                         string pathChannelSid, 
                                                                                         UserChannelResource.NotificationLevelEnum notificationLevel, 
                                                                                         ITwilioRestClient client = null)
        {
            var options = new UpdateUserChannelOptions(pathServiceSid, pathUserSid, pathChannelSid, notificationLevel);
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a UserChannelResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> UserChannelResource object represented by the provided JSON </returns> 
        public static UserChannelResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<UserChannelResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The SID of the Service that the resource is associated with
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The SID of the Channel the resource belongs to
        /// </summary>
        [JsonProperty("channel_sid")]
        public string ChannelSid { get; private set; }
        /// <summary>
        /// The SID of the User the User Channel belongs to
        /// </summary>
        [JsonProperty("user_sid")]
        public string UserSid { get; private set; }
        /// <summary>
        /// The SID of the User as a Member in the Channel
        /// </summary>
        [JsonProperty("member_sid")]
        public string MemberSid { get; private set; }
        /// <summary>
        /// The status of the User on the Channel
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserChannelResource.ChannelStatusEnum Status { get; private set; }
        /// <summary>
        /// The index of the last Message in the Channel the Member has read
        /// </summary>
        [JsonProperty("last_consumed_message_index")]
        public int? LastConsumedMessageIndex { get; private set; }
        /// <summary>
        /// The number of unread Messages in the Channel for the User
        /// </summary>
        [JsonProperty("unread_messages_count")]
        public int? UnreadMessagesCount { get; private set; }
        /// <summary>
        /// Absolute URLs to access the Members, Messages , Invites and, if it exists, the last Message for the Channel
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// The absolute URL of the resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The push notification level of the User for the Channel
        /// </summary>
        [JsonProperty("notification_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public UserChannelResource.NotificationLevelEnum NotificationLevel { get; private set; }

        private UserChannelResource()
        {

        }
    }

}