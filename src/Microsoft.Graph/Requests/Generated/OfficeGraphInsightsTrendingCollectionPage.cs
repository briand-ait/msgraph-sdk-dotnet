// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type OfficeGraphInsightsTrendingCollectionPage.
    /// </summary>
    public partial class OfficeGraphInsightsTrendingCollectionPage : CollectionPage<Trending>, IOfficeGraphInsightsTrendingCollectionPage
    {
        /// <summary>
        /// Gets the next page <see cref="IOfficeGraphInsightsTrendingCollectionRequest"/> instance.
        /// </summary>
        public IOfficeGraphInsightsTrendingCollectionRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new OfficeGraphInsightsTrendingCollectionRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
