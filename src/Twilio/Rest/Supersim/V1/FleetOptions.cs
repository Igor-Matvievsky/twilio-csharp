/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Supersim.V1
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Create a Fleet
    /// </summary>
    public class CreateFleetOptions : IOptions<FleetResource>
    {
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// Defines whether SIMs in the Fleet are capable of using data connectivity
        /// </summary>
        public bool? DataEnabled { get; set; }
        /// <summary>
        /// Defines whether SIMs in the Fleet are capable of sending and receiving Commands via SMS
        /// </summary>
        public bool? CommandsEnabled { get; set; }
        /// <summary>
        /// The URL that will receive a webhook when a SIM in the Fleet originates a machine-to-machine Command
        /// </summary>
        public Uri CommandsUrl { get; set; }
        /// <summary>
        /// A string representing the HTTP method to use when making a request to `commands_url`
        /// </summary>
        public Twilio.Http.HttpMethod CommandsMethod { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (DataEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("DataEnabled", DataEnabled.Value.ToString().ToLower()));
            }

            if (CommandsEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsEnabled", CommandsEnabled.Value.ToString().ToLower()));
            }

            if (CommandsUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsUrl", Serializers.Url(CommandsUrl)));
            }

            if (CommandsMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("CommandsMethod", CommandsMethod.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Fetch a Fleet instance from your account.
    /// </summary>
    public class FetchFleetOptions : IOptions<FleetResource>
    {
        /// <summary>
        /// The SID that identifies the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchFleetOptions
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        public FetchFleetOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a list of Fleets from your account.
    /// </summary>
    public class ReadFleetOptions : ReadOptions<FleetResource>
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Updates the given properties of a Super SIM Fleet instance from your account.
    /// </summary>
    public class UpdateFleetOptions : IOptions<FleetResource>
    {
        /// <summary>
        /// The SID that identifies the resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        public string UniqueName { get; set; }

        /// <summary>
        /// Construct a new UpdateFleetOptions
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        public UpdateFleetOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            return p;
        }
    }

}