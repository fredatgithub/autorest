// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsValidation.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// The product documentation.
    /// </summary>
    public partial class ChildProduct
    {
        /// <summary>
        /// Initializes a new instance of the ChildProduct class.
        /// </summary>
        public ChildProduct() { }

        /// <summary>
        /// Initializes a new instance of the ChildProduct class.
        /// </summary>
        public ChildProduct(int? count = default(int?))
        {
            Count = count;
        }
        /// <summary>
        /// Static constructor for ChildProduct class.
        /// </summary>
        static ChildProduct()
        {
            ConstProperty = "constant";
        }

        /// <summary>
        /// Gets or sets count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Constant string
        /// </summary>
        [JsonProperty(PropertyName = "constProperty")]
        public static string ConstProperty { get; private set; }

    }
}