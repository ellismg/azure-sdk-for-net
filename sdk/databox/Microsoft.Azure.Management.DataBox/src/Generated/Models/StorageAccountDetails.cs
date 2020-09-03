// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details for the storage account.
    /// </summary>
    [Newtonsoft.Json.JsonObject("StorageAccount")]
    public partial class StorageAccountDetails : DataAccountDetails
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountDetails class.
        /// </summary>
        public StorageAccountDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountDetails class.
        /// </summary>
        /// <param name="storageAccountId">Storage Account Resource Id.</param>
        /// <param name="sharePassword">Password for all the shares to be
        /// created on the device. Should not be passed for
        /// TransferType:ExportFromAzure jobs. If this is not passed, the
        /// service will generate password itself. This will not be returned in
        /// Get Call. Password Requirements :  Password must be minimum of 12
        /// and maximum of 64 characters. Password must have at least one
        /// uppercase alphabet, one number and one special character. Password
        /// cannot have the following characters : IilLoO0 Password can have
        /// only alphabets, numbers and these characters :
        /// @#\-$%^!+=;:_()]+</param>
        public StorageAccountDetails(string storageAccountId, string sharePassword = default(string))
            : base(sharePassword)
        {
            StorageAccountId = storageAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage Account Resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccountId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountId");
            }
        }
    }
}