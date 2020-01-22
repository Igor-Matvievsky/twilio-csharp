/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Api.V2010.Account.Call
{

    /// <summary>
    /// FetchNotificationOptions
    /// </summary>
    public class FetchNotificationOptions : IOptions<NotificationResource>
    {
        /// <summary>
        /// The SID of the Account that created the resource to fetch
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The Call SID of the resource to fetch
        /// </summary>
        public string PathCallSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchNotificationOptions
        /// </summary>
        /// <param name="pathCallSid"> The Call SID of the resource to fetch </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchNotificationOptions(string pathCallSid, string pathSid)
        {
            PathCallSid = pathCallSid;
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
    /// ReadNotificationOptions
    /// </summary>
    public class ReadNotificationOptions : ReadOptions<NotificationResource>
    {
        /// <summary>
        /// The SID of the Account that created the resources to read
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The Call SID of the resources to read
        /// </summary>
        public string PathCallSid { get; }
        /// <summary>
        /// Filter by log level
        /// </summary>
        public int? Log { get; set; }
        /// <summary>
        /// Filter by date
        /// </summary>
        public DateTime? MessageDateBefore { get; set; }
        /// <summary>
        /// Filter by date
        /// </summary>
        public DateTime? MessageDate { get; set; }
        /// <summary>
        /// Filter by date
        /// </summary>
        public DateTime? MessageDateAfter { get; set; }

        /// <summary>
        /// Construct a new ReadNotificationOptions
        /// </summary>
        /// <param name="pathCallSid"> The Call SID of the resources to read </param>
        public ReadNotificationOptions(string pathCallSid)
        {
            PathCallSid = pathCallSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Log != null)
            {
                p.Add(new KeyValuePair<string, string>("Log", Log.ToString()));
            }

            if (MessageDate != null)
            {
                p.Add(new KeyValuePair<string, string>("MessageDate", MessageDate.Value.ToString("yyyy-MM-dd")));
            }
            else
            {
                if (MessageDateBefore != null)
                {
                    p.Add(new KeyValuePair<string, string>("MessageDate<", MessageDateBefore.Value.ToString("yyyy-MM-dd")));
                }

                if (MessageDateAfter != null)
                {
                    p.Add(new KeyValuePair<string, string>("MessageDate>", MessageDateAfter.Value.ToString("yyyy-MM-dd")));
                }
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}