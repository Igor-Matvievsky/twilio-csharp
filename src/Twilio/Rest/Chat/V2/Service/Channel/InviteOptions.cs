/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Chat.V2.Service.Channel 
{

    /// <summary>
    /// FetchInviteOptions
    /// </summary>
    public class FetchInviteOptions : IOptions<InviteResource> 
    {
        /// <summary>
        /// The SID of the Service to fetch the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Channel the resource to fetch belongs to
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchInviteOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the resource from </param>
        /// <param name="pathChannelSid"> The SID of the Channel the resource to fetch belongs to </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchInviteOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// CreateInviteOptions
    /// </summary>
    public class CreateInviteOptions : IOptions<InviteResource> 
    {
        /// <summary>
        /// The SID of the Service to create the resource under
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Channel the new resource belongs to
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The `identity` value that identifies the new resource's User
        /// </summary>
        public string Identity { get; }
        /// <summary>
        /// The Role assigned to the new member
        /// </summary>
        public string RoleSid { get; set; }

        /// <summary>
        /// Construct a new CreateInviteOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the resource under </param>
        /// <param name="pathChannelSid"> The SID of the Channel the new resource belongs to </param>
        /// <param name="identity"> The `identity` value that identifies the new resource's User </param>
        public CreateInviteOptions(string pathServiceSid, string pathChannelSid, string identity)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = identity;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }

            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadInviteOptions
    /// </summary>
    public class ReadInviteOptions : ReadOptions<InviteResource> 
    {
        /// <summary>
        /// The SID of the Service to read the resources from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Channel the resources to read belong to
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The `identity` value of the resources to read
        /// </summary>
        public List<string> Identity { get; set; }

        /// <summary>
        /// Construct a new ReadInviteOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resources from </param>
        /// <param name="pathChannelSid"> The SID of the Channel the resources to read belong to </param>
        public ReadInviteOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.AddRange(Identity.Select(prop => new KeyValuePair<string, string>("Identity", prop)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteInviteOptions
    /// </summary>
    public class DeleteInviteOptions : IOptions<InviteResource> 
    {
        /// <summary>
        /// The SID of the Service to delete the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Channel the resource to delete belongs to
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteInviteOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the resource from </param>
        /// <param name="pathChannelSid"> The SID of the Channel the resource to delete belongs to </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteInviteOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}