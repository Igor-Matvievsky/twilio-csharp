/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Verify.V1.Service 
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Create a new Verification for a To number using a Service
    /// </summary>
    public class CreateVerificationOptions : IOptions<VerificationResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// To phonenumber
        /// </summary>
        public string To { get; }
        /// <summary>
        /// sms or call
        /// </summary>
        public string Channel { get; }
        /// <summary>
        /// Digits to send when a phone call is started
        /// </summary>
        public string SendDigits { get; set; }
        /// <summary>
        /// Locale used in the sms or call.
        /// </summary>
        public string Locale { get; set; }
        /// <summary>
        /// A pre-generated code
        /// </summary>
        public string CustomCode { get; set; }
        /// <summary>
        /// Amount of the associated PSD2 compliant transaction.
        /// </summary>
        public string Amount { get; set; }
        /// <summary>
        /// Payee of the associated PSD2 compliant transaction.
        /// </summary>
        public string Payee { get; set; }

        /// <summary>
        /// Construct a new CreateVerificationOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="to"> To phonenumber </param>
        /// <param name="channel"> sms or call </param>
        public CreateVerificationOptions(string pathServiceSid, string to, string channel)
        {
            PathServiceSid = pathServiceSid;
            To = to;
            Channel = channel;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To));
            }

            if (Channel != null)
            {
                p.Add(new KeyValuePair<string, string>("Channel", Channel));
            }

            if (SendDigits != null)
            {
                p.Add(new KeyValuePair<string, string>("SendDigits", SendDigits));
            }

            if (Locale != null)
            {
                p.Add(new KeyValuePair<string, string>("Locale", Locale));
            }

            if (CustomCode != null)
            {
                p.Add(new KeyValuePair<string, string>("CustomCode", CustomCode));
            }

            if (Amount != null)
            {
                p.Add(new KeyValuePair<string, string>("Amount", Amount));
            }

            if (Payee != null)
            {
                p.Add(new KeyValuePair<string, string>("Payee", Payee));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Update a Verification status
    /// </summary>
    public class UpdateVerificationOptions : IOptions<VerificationResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Verification.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// New status to set for the Verification.
        /// </summary>
        public VerificationResource.StatusEnum Status { get; }

        /// <summary>
        /// Construct a new UpdateVerificationOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Verification. </param>
        /// <param name="status"> New status to set for the Verification. </param>
        public UpdateVerificationOptions(string pathServiceSid, string pathSid, VerificationResource.StatusEnum status)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
            Status = status;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Fetch a specific Verification
    /// </summary>
    public class FetchVerificationOptions : IOptions<VerificationResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Verification.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchVerificationOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Verification. </param>
        public FetchVerificationOptions(string pathServiceSid, string pathSid)
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

}