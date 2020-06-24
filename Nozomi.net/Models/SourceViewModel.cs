// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Nozomi.net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SourceViewModel
    {
        /// <summary>
        /// Initializes a new instance of the SourceViewModel class.
        /// </summary>
        public SourceViewModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SourceViewModel class.
        /// </summary>
        public SourceViewModel(System.Guid? guid = default(System.Guid?), string abbreviation = default(string), string name = default(string), string apiDocsUrl = default(string))
        {
            Guid = guid;
            Abbreviation = abbreviation;
            Name = name;
            ApiDocsUrl = apiDocsUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "guid")]
        public System.Guid? Guid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiDocsUrl")]
        public string ApiDocsUrl { get; set; }

    }
}