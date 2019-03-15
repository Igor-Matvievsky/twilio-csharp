/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Chat.V2.Service 
{

    /// <summary>
    /// FetchRoleOptions
    /// </summary>
    public class FetchRoleOptions : IOptions<RoleResource> 
    {
        /// <summary>
        /// The SID of the Service to fetch the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchRoleOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchRoleOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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
    /// DeleteRoleOptions
    /// </summary>
    public class DeleteRoleOptions : IOptions<RoleResource> 
    {
        /// <summary>
        /// The SID of the Service to delete the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteRoleOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteRoleOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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
    /// CreateRoleOptions
    /// </summary>
    public class CreateRoleOptions : IOptions<RoleResource> 
    {
        /// <summary>
        /// The SID of the Service to create the resource under
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// A string to describe the new resource
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The type of role
        /// </summary>
        public RoleResource.RoleTypeEnum Type { get; }
        /// <summary>
        /// A permission the role should have
        /// </summary>
        public List<string> Permission { get; }

        /// <summary>
        /// Construct a new CreateRoleOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the resource under </param>
        /// <param name="friendlyName"> A string to describe the new resource </param>
        /// <param name="type"> The type of role </param>
        /// <param name="permission"> A permission the role should have </param>
        public CreateRoleOptions(string pathServiceSid, 
                                 string friendlyName, 
                                 RoleResource.RoleTypeEnum type, 
                                 List<string> permission)
        {
            PathServiceSid = pathServiceSid;
            FriendlyName = friendlyName;
            Type = type;
            Permission = permission;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }

            if (Permission != null)
            {
                p.AddRange(Permission.Select(prop => new KeyValuePair<string, string>("Permission", prop)));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadRoleOptions
    /// </summary>
    public class ReadRoleOptions : ReadOptions<RoleResource> 
    {
        /// <summary>
        /// The SID of the Service to read the resources from
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadRoleOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resources from </param>
        public ReadRoleOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateRoleOptions
    /// </summary>
    public class UpdateRoleOptions : IOptions<RoleResource> 
    {
        /// <summary>
        /// The SID of the Service to update the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A permission the role should have
        /// </summary>
        public List<string> Permission { get; }

        /// <summary>
        /// Construct a new UpdateRoleOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to update the resource from </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="permission"> A permission the role should have </param>
        public UpdateRoleOptions(string pathServiceSid, string pathSid, List<string> permission)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
            Permission = permission;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Permission != null)
            {
                p.AddRange(Permission.Select(prop => new KeyValuePair<string, string>("Permission", prop)));
            }

            return p;
        }
    }

}