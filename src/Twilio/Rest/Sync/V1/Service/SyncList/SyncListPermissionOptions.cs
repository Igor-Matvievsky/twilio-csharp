/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Sync.V1.Service.SyncList
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Fetch a specific Sync List Permission.
    /// </summary>
    public class FetchSyncListPermissionOptions : IOptions<SyncListPermissionResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List Permission resource to fetch
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List with the Sync List Permission resource to fetch
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The application-defined string that uniquely identifies the User's Sync List Permission resource to fetch
        /// </summary>
        public string PathIdentity { get; }

        /// <summary>
        /// Construct a new FetchSyncListPermissionOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List Permission resource to fetch </param>
        /// <param name="pathListSid"> The SID of the Sync List with the Sync List Permission resource to fetch </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Sync List Permission
        ///                    resource to fetch </param>
        public FetchSyncListPermissionOptions(string pathServiceSid, string pathListSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIdentity = pathIdentity;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Delete a specific Sync List Permission.
    /// </summary>
    public class DeleteSyncListPermissionOptions : IOptions<SyncListPermissionResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List Permission resource to delete
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List with the Sync List Permission resource to delete
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The application-defined string that uniquely identifies the User's Sync List Permission resource to delete
        /// </summary>
        public string PathIdentity { get; }

        /// <summary>
        /// Construct a new DeleteSyncListPermissionOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List Permission resource to delete </param>
        /// <param name="pathListSid"> The SID of the Sync List with the Sync List Permission resource to delete </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Sync List Permission
        ///                    resource to delete </param>
        public DeleteSyncListPermissionOptions(string pathServiceSid, string pathListSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIdentity = pathIdentity;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Retrieve a list of all Permissions applying to a Sync List.
    /// </summary>
    public class ReadSyncListPermissionOptions : ReadOptions<SyncListPermissionResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List Permission resources to read
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List with the Sync List Permission resources to read
        /// </summary>
        public string PathListSid { get; }

        /// <summary>
        /// Construct a new ReadSyncListPermissionOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List Permission resources to read </param>
        /// <param name="pathListSid"> The SID of the Sync List with the Sync List Permission resources to read </param>
        public ReadSyncListPermissionOptions(string pathServiceSid, string pathListSid)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    ///
    /// Update an identity's access to a specific Sync List.
    /// </summary>
    public class UpdateSyncListPermissionOptions : IOptions<SyncListPermissionResource>
    {
        /// <summary>
        /// The SID of the Sync Service with the Sync List Permission resource to update
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the Sync List with the Sync List Permission resource to update
        /// </summary>
        public string PathListSid { get; }
        /// <summary>
        /// The application-defined string that uniquely identifies the User's Sync List Permission resource to update
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// Read access
        /// </summary>
        public bool? Read { get; }
        /// <summary>
        /// Write access
        /// </summary>
        public bool? Write { get; }
        /// <summary>
        /// Manage access
        /// </summary>
        public bool? Manage { get; }

        /// <summary>
        /// Construct a new UpdateSyncListPermissionOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Sync Service with the Sync List Permission resource to update </param>
        /// <param name="pathListSid"> The SID of the Sync List with the Sync List Permission resource to update </param>
        /// <param name="pathIdentity"> The application-defined string that uniquely identifies the User's Sync List Permission
        ///                    resource to update </param>
        /// <param name="read"> Read access </param>
        /// <param name="write"> Write access </param>
        /// <param name="manage"> Manage access </param>
        public UpdateSyncListPermissionOptions(string pathServiceSid,
                                               string pathListSid,
                                               string pathIdentity,
                                               bool? read,
                                               bool? write,
                                               bool? manage)
        {
            PathServiceSid = pathServiceSid;
            PathListSid = pathListSid;
            PathIdentity = pathIdentity;
            Read = read;
            Write = write;
            Manage = manage;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Read != null)
            {
                p.Add(new KeyValuePair<string, string>("Read", Read.Value.ToString().ToLower()));
            }

            if (Write != null)
            {
                p.Add(new KeyValuePair<string, string>("Write", Write.Value.ToString().ToLower()));
            }

            if (Manage != null)
            {
                p.Add(new KeyValuePair<string, string>("Manage", Manage.Value.ToString().ToLower()));
            }

            return p;
        }
    }

}