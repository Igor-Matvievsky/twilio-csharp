/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Verify.V2
{

    /// <summary>
    /// Create a new Verification Service.
    /// </summary>
    public class CreateServiceOptions : IOptions<ServiceResource>
    {
        /// <summary>
        /// A string to describe the verification service
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The length of the verification code to generate
        /// </summary>
        public int? CodeLength { get; set; }
        /// <summary>
        /// Whether to perform a lookup with each verification
        /// </summary>
        public bool? LookupEnabled { get; set; }
        /// <summary>
        /// Whether to skip sending SMS verifications to landlines
        /// </summary>
        public bool? SkipSmsToLandlines { get; set; }
        /// <summary>
        /// Whether to ask the user to press a number before delivering the verify code in a phone call
        /// </summary>
        public bool? DtmfInputRequired { get; set; }
        /// <summary>
        /// The name of an alternative text-to-speech service to use in phone calls
        /// </summary>
        public string TtsName { get; set; }
        /// <summary>
        /// Whether to pass PSD2 transaction parameters when starting a verification
        /// </summary>
        public bool? Psd2Enabled { get; set; }
        /// <summary>
        /// Whether to add a privacy warning at the end of an SMS.
        /// </summary>
        public bool? DoNotShareWarningEnabled { get; set; }

        /// <summary>
        /// Construct a new CreateServiceOptions
        /// </summary>
        /// <param name="friendlyName"> A string to describe the verification service </param>
        public CreateServiceOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
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

            if (CodeLength != null)
            {
                p.Add(new KeyValuePair<string, string>("CodeLength", CodeLength.ToString()));
            }

            if (LookupEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("LookupEnabled", LookupEnabled.Value.ToString().ToLower()));
            }

            if (SkipSmsToLandlines != null)
            {
                p.Add(new KeyValuePair<string, string>("SkipSmsToLandlines", SkipSmsToLandlines.Value.ToString().ToLower()));
            }

            if (DtmfInputRequired != null)
            {
                p.Add(new KeyValuePair<string, string>("DtmfInputRequired", DtmfInputRequired.Value.ToString().ToLower()));
            }

            if (TtsName != null)
            {
                p.Add(new KeyValuePair<string, string>("TtsName", TtsName));
            }

            if (Psd2Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Psd2Enabled", Psd2Enabled.Value.ToString().ToLower()));
            }

            if (DoNotShareWarningEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("DoNotShareWarningEnabled", DoNotShareWarningEnabled.Value.ToString().ToLower()));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch specific Verification Service Instance.
    /// </summary>
    public class FetchServiceOptions : IOptions<ServiceResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchServiceOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchServiceOptions(string pathSid)
        {
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
    /// Delete a specific Verification Service Instance.
    /// </summary>
    public class DeleteServiceOptions : IOptions<ServiceResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteServiceOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public DeleteServiceOptions(string pathSid)
        {
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
    /// Retrieve a list of all Verification Services for an account.
    /// </summary>
    public class ReadServiceOptions : ReadOptions<ServiceResource>
    {
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
    /// Update a specific Verification Service.
    /// </summary>
    public class UpdateServiceOptions : IOptions<ServiceResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A string to describe the verification service
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The length of the verification code to generate
        /// </summary>
        public int? CodeLength { get; set; }
        /// <summary>
        /// Whether to perform a lookup with each verification
        /// </summary>
        public bool? LookupEnabled { get; set; }
        /// <summary>
        /// Whether to skip sending SMS verifications to landlines
        /// </summary>
        public bool? SkipSmsToLandlines { get; set; }
        /// <summary>
        /// Whether to ask the user to press a number before delivering the verify code in a phone call
        /// </summary>
        public bool? DtmfInputRequired { get; set; }
        /// <summary>
        /// The name of an alternative text-to-speech service to use in phone calls
        /// </summary>
        public string TtsName { get; set; }
        /// <summary>
        /// Whether to pass PSD2 transaction parameters when starting a verification
        /// </summary>
        public bool? Psd2Enabled { get; set; }
        /// <summary>
        /// Whether to add a privacy warning at the end of an SMS.
        /// </summary>
        public bool? DoNotShareWarningEnabled { get; set; }

        /// <summary>
        /// Construct a new UpdateServiceOptions
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public UpdateServiceOptions(string pathSid)
        {
            PathSid = pathSid;
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

            if (CodeLength != null)
            {
                p.Add(new KeyValuePair<string, string>("CodeLength", CodeLength.ToString()));
            }

            if (LookupEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("LookupEnabled", LookupEnabled.Value.ToString().ToLower()));
            }

            if (SkipSmsToLandlines != null)
            {
                p.Add(new KeyValuePair<string, string>("SkipSmsToLandlines", SkipSmsToLandlines.Value.ToString().ToLower()));
            }

            if (DtmfInputRequired != null)
            {
                p.Add(new KeyValuePair<string, string>("DtmfInputRequired", DtmfInputRequired.Value.ToString().ToLower()));
            }

            if (TtsName != null)
            {
                p.Add(new KeyValuePair<string, string>("TtsName", TtsName));
            }

            if (Psd2Enabled != null)
            {
                p.Add(new KeyValuePair<string, string>("Psd2Enabled", Psd2Enabled.Value.ToString().ToLower()));
            }

            if (DoNotShareWarningEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("DoNotShareWarningEnabled", DoNotShareWarningEnabled.Value.ToString().ToLower()));
            }

            return p;
        }
    }

}