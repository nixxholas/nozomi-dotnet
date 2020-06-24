// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Nozomi.net.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UpdateRequestPropertyInputModel
    {
        /// <summary>
        /// Initializes a new instance of the UpdateRequestPropertyInputModel
        /// class.
        /// </summary>
        public UpdateRequestPropertyInputModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateRequestPropertyInputModel
        /// class.
        /// </summary>
        public UpdateRequestPropertyInputModel(System.Guid? guid = default(System.Guid?), int? type = default(int?), string key = default(string), string value = default(string), bool? isEnabled = default(bool?), string requestGuid = default(string), bool? isDeleted = default(bool?), bool? permanentDeletion = default(bool?))
        {
            Guid = guid;
            Type = type;
            Key = key;
            Value = value;
            IsEnabled = isEnabled;
            RequestGuid = requestGuid;
            IsDeleted = isDeleted;
            PermanentDeletion = permanentDeletion;
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
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestGuid")]
        public string RequestGuid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isDeleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "permanentDeletion")]
        public bool? PermanentDeletion { get; set; }

    }
}
