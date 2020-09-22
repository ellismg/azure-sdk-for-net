// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class GlobalValidation : ProxyOnlyResource
    {
        /// <summary>
        /// Initializes a new instance of the GlobalValidation class.
        /// </summary>
        public GlobalValidation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GlobalValidation class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="unauthenticatedClientAction">Possible values include:
        /// 'RedirectToLoginPage', 'AllowAnonymous', 'Return401',
        /// 'Return403'</param>
        public GlobalValidation(string id = default(string), string name = default(string), string kind = default(string), string type = default(string), bool? requireAuthentication = default(bool?), UnauthenticatedClientActionV2? unauthenticatedClientAction = default(UnauthenticatedClientActionV2?), string redirectToProvider = default(string), IList<string> excludedPaths = default(IList<string>))
            : base(id, name, kind, type)
        {
            RequireAuthentication = requireAuthentication;
            UnauthenticatedClientAction = unauthenticatedClientAction;
            RedirectToProvider = redirectToProvider;
            ExcludedPaths = excludedPaths;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.requireAuthentication")]
        public bool? RequireAuthentication { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'RedirectToLoginPage',
        /// 'AllowAnonymous', 'Return401', 'Return403'
        /// </summary>
        [JsonProperty(PropertyName = "properties.unauthenticatedClientAction")]
        public UnauthenticatedClientActionV2? UnauthenticatedClientAction { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.redirectToProvider")]
        public string RedirectToProvider { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.excludedPaths")]
        public IList<string> ExcludedPaths { get; set; }

    }
}