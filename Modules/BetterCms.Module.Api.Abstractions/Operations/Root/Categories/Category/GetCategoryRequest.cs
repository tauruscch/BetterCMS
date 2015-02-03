﻿using System;
using System.Runtime.Serialization;

using BetterCms.Module.Api.Infrastructure;

using ServiceStack.ServiceHost;

namespace BetterCms.Module.Api.Operations.Root.Categories.Category
{
    /// <summary>
    /// Request to get category data.
    /// </summary>
    [Route("/categories/{CategoryId}", Verbs = "GET")]
    [Serializable]
    [DataContract]
    public class GetCategoryRequest : RequestBase<GetCategoryModel>, IReturn<GetCategoryResponse>
    {
        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        /// <value>
        /// The category identifier.
        /// </value>
        [DataMember]
        public Guid CategoryId { get; set; }
    }
}