// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Encryption settings for disk or snapshot
    /// </summary>
    public partial class EncryptionSettings
    {
        /// <summary>
        /// Initializes a new instance of the EncryptionSettings class.
        /// </summary>
        public EncryptionSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EncryptionSettings class.
        /// </summary>
        /// <param name="enabled">Set this flag to true and provide
        /// DiskEncryptionKey and optional KeyEncryptionKey to enable
        /// encryption. Set this flag to false and remove DiskEncryptionKey and
        /// KeyEncryptionKey to disable encryption. If EncryptionSettings is
        /// null in the request object, the existing settings remain
        /// unchanged.</param>
        /// <param name="diskEncryptionKey">Key Vault Secret Url and vault id
        /// of the disk encryption key</param>
        /// <param name="keyEncryptionKey">Key Vault Key Url and vault id of
        /// the key encryption key</param>
        public EncryptionSettings(bool? enabled = default(bool?), KeyVaultAndSecretReference diskEncryptionKey = default(KeyVaultAndSecretReference), KeyVaultAndKeyReference keyEncryptionKey = default(KeyVaultAndKeyReference))
        {
            Enabled = enabled;
            DiskEncryptionKey = diskEncryptionKey;
            KeyEncryptionKey = keyEncryptionKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets set this flag to true and provide DiskEncryptionKey
        /// and optional KeyEncryptionKey to enable encryption. Set this flag
        /// to false and remove DiskEncryptionKey and KeyEncryptionKey to
        /// disable encryption. If EncryptionSettings is null in the request
        /// object, the existing settings remain unchanged.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets key Vault Secret Url and vault id of the disk
        /// encryption key
        /// </summary>
        [JsonProperty(PropertyName = "diskEncryptionKey")]
        public KeyVaultAndSecretReference DiskEncryptionKey { get; set; }

        /// <summary>
        /// Gets or sets key Vault Key Url and vault id of the key encryption
        /// key
        /// </summary>
        [JsonProperty(PropertyName = "keyEncryptionKey")]
        public KeyVaultAndKeyReference KeyEncryptionKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DiskEncryptionKey != null)
            {
                DiskEncryptionKey.Validate();
            }
            if (KeyEncryptionKey != null)
            {
                KeyEncryptionKey.Validate();
            }
        }
    }
}
