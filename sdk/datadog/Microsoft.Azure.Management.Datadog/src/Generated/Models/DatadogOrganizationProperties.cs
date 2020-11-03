// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Datadog.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DatadogOrganizationProperties
    {
        /// <summary>
        /// Initializes a new instance of the DatadogOrganizationProperties
        /// class.
        /// </summary>
        public DatadogOrganizationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatadogOrganizationProperties
        /// class.
        /// </summary>
        /// <param name="name">Name of the Datadog organization.</param>
        /// <param name="id">Id of the Datadog organization.</param>
        /// <param name="linkingAuthCode">The auth code used to linking to an
        /// existing datadog organization.</param>
        /// <param name="linkingClientId">The client_id from an existing in
        /// exchange for an auth token to link organization.</param>
        /// <param name="enterpriseAppId">The Id of the Enterprise App used for
        /// Single sign on.</param>
        public DatadogOrganizationProperties(string name = default(string), string id = default(string), string linkingAuthCode = default(string), string linkingClientId = default(string), string enterpriseAppId = default(string))
        {
            Name = name;
            Id = id;
            LinkingAuthCode = linkingAuthCode;
            LinkingClientId = linkingClientId;
            EnterpriseAppId = enterpriseAppId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the Datadog organization.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets id of the Datadog organization.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the auth code used to linking to an existing datadog
        /// organization.
        /// </summary>
        [JsonProperty(PropertyName = "linkingAuthCode")]
        public string LinkingAuthCode { get; set; }

        /// <summary>
        /// Gets or sets the client_id from an existing in exchange for an auth
        /// token to link organization.
        /// </summary>
        [JsonProperty(PropertyName = "linkingClientId")]
        public string LinkingClientId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Enterprise App used for Single sign on.
        /// </summary>
        [JsonProperty(PropertyName = "enterpriseAppId")]
        public string EnterpriseAppId { get; set; }

    }
}