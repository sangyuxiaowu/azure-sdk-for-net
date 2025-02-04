// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The catalog's properties for partial update. Properties not provided in the update request will not be changed. </summary>
    public partial class DevCenterCatalogPatch
    {
        /// <summary> Initializes a new instance of <see cref="DevCenterCatalogPatch"/>. </summary>
        public DevCenterCatalogPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DevCenterCatalogPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="gitHub"> Properties for a GitHub catalog type. </param>
        /// <param name="adoGit"> Properties for an Azure DevOps catalog type. </param>
        internal DevCenterCatalogPatch(IDictionary<string, string> tags, DevCenterGitCatalog gitHub, DevCenterGitCatalog adoGit)
        {
            Tags = tags;
            GitHub = gitHub;
            AdoGit = adoGit;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Properties for a GitHub catalog type. </summary>
        public DevCenterGitCatalog GitHub { get; set; }
        /// <summary> Properties for an Azure DevOps catalog type. </summary>
        public DevCenterGitCatalog AdoGit { get; set; }
    }
}
