// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Storage.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.Storage.Fluent.Models;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The implementation of  Usages.
    /// </summary>
    ///GENTHASH:Y29tLm1pY3Jvc29mdC5henVyZS5tYW5hZ2VtZW50LnN0b3JhZ2UuaW1wbGVtZW50YXRpb24uVXNhZ2VzSW1wbA==
    internal partial class UsagesImpl  : ReadableWrappers<IStorageUsage, UsageImpl, Usage>, IUsages
    {
        private readonly IStorageManager manager;

        ///GENMHASH:35D07311D3F5A0FC20A86A7B024BE1D1:FCBE9313644315745EDD2396965C2FE2
        internal  UsagesImpl(IStorageManager manager)
        {
            this.manager = manager;
        }

        IUsagesOperations IHasInner<IUsagesOperations>.Inner => this.manager.Inner.Usages;

        ///GENMHASH:7D6013E8B95E991005ED921F493EFCE4:50D821C2930D637FC2173CD8C27AF5F7
        public IEnumerable<Microsoft.Azure.Management.Storage.Fluent.IStorageUsage> List()
        {
            //TODO: service is not supporting this listing anymore
            //var storageUsages = Extensions.Synchronize(() => this.manager.Inner.Usages.ListAsync());
            //if (storageUsages == null)
            //{
            //    return new List<IStorageUsage>();
            //}
            //return WrapList(storageUsages);
            throw new NotImplementedException("Storage is no longer supporting usages listing anymore");
        }

        ///GENMHASH:7F5BEBF638B801886F5E13E6CCFF6A4E:FF27DF14BEE91BED69598A874F25301A
        public async Task<Microsoft.Azure.Management.ResourceManager.Fluent.Core.IPagedCollection<IStorageUsage>> ListAsync(bool loadAllPages = true, CancellationToken cancellationToken = default(CancellationToken))
        {
            //TODO: service is not supporting this listing anymore
            //return await PagedCollection<IStorageUsage, Usage>.LoadPage(this.manager.Inner.Usages.ListAsync, WrapModel, cancellationToken);
            throw new NotImplementedException("Storage is no longer supporting usages listing anymore");
        }

        ///GENMHASH:438AA0AEE9E5AB3F7FB0CB3404AB0062:36C68AF6A66967842C933E2D8D22EACE
        protected override IStorageUsage WrapModel(Usage usageInner)
        {
            return new UsageImpl(usageInner);
        }

        Microsoft.Azure.Management.Storage.Fluent.IStorageManager Manager()
        {
            return this.manager;
        }
    }
}