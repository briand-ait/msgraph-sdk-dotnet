// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type SiteItemsCollectionRequestBuilder.
    /// </summary>
    public partial class SiteItemsCollectionRequestBuilder : BaseRequestBuilder, ISiteItemsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SiteItemsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SiteItemsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISiteItemsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISiteItemsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SiteItemsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IBaseItemRequestBuilder"/> for the specified SiteBaseItem.
        /// </summary>
        /// <param name="id">The ID for the SiteBaseItem.</param>
        /// <returns>The <see cref="IBaseItemRequestBuilder"/>.</returns>
        public IBaseItemRequestBuilder this[string id]
        {
            get
            {
                return new BaseItemRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
