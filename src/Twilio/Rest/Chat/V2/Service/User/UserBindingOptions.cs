/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Chat.V2.Service.User 
{

    /// <summary>
    /// ReadUserBindingOptions
    /// </summary>
    public class ReadUserBindingOptions : ReadOptions<UserBindingResource> 
    {
        /// <summary>
        /// The SID of the Service to read the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the User of the User Bindings to read
        /// </summary>
        public string PathUserSid { get; }
        /// <summary>
        /// The push technology used by the User Binding resources to read
        /// </summary>
        public List<UserBindingResource.BindingTypeEnum> BindingType { get; set; }

        /// <summary>
        /// Construct a new ReadUserBindingOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the resource from </param>
        /// <param name="pathUserSid"> The SID of the User of the User Bindings to read </param>
        public ReadUserBindingOptions(string pathServiceSid, string pathUserSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
            BindingType = new List<UserBindingResource.BindingTypeEnum>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (BindingType != null)
            {
                p.AddRange(BindingType.Select(prop => new KeyValuePair<string, string>("BindingType", prop.ToString())));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchUserBindingOptions
    /// </summary>
    public class FetchUserBindingOptions : IOptions<UserBindingResource> 
    {
        /// <summary>
        /// The SID of the Service to fetch the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the User for the binding
        /// </summary>
        public string PathUserSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchUserBindingOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the resource from </param>
        /// <param name="pathUserSid"> The SID of the User for the binding </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchUserBindingOptions(string pathServiceSid, string pathUserSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
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
    /// DeleteUserBindingOptions
    /// </summary>
    public class DeleteUserBindingOptions : IOptions<UserBindingResource> 
    {
        /// <summary>
        /// The SID of the Service to delete the resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the User of the User Bindings to delete
        /// </summary>
        public string PathUserSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteUserBindingOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the resource from </param>
        /// <param name="pathUserSid"> The SID of the User of the User Bindings to delete </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteUserBindingOptions(string pathServiceSid, string pathUserSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathUserSid = pathUserSid;
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