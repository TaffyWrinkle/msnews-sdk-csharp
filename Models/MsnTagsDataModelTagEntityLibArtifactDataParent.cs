// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace MicrosoftNewsAPI.SDK.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MsnTagsDataModelTagEntityLibArtifactDataParent
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibArtifactDataParent class.
        /// </summary>
        public MsnTagsDataModelTagEntityLibArtifactDataParent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MsnTagsDataModelTagEntityLibArtifactDataParent class.
        /// </summary>
        /// <param name="name">Gets or sets Name</param>
        /// <param name="id">Gets or sets Id</param>
        /// <param name="type">Gets or sets Type</param>
        public MsnTagsDataModelTagEntityLibArtifactDataParent(string name = default(string), string id = default(string), string type = default(string))
        {
            Name = name;
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}