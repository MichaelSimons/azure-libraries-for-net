// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;

    /// <summary>
    /// Entry point to virtual machine image offer SKUs.
    /// </summary>
    public interface IVirtualMachineSkus :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineSku>
    {

    }
}