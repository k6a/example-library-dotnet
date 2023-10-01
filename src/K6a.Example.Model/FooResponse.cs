using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace K6a.Example.Model
{
    /// <summary>
    /// Response for Foo
    /// </summary>
    [DataContract]
    [Serializable]
    public class FooResponse
    {
        /// <summary>
        /// Response status code
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true, Name = "responseCode", Order = 0)]
        [JsonPropertyName("responseCode"), JsonPropertyOrder(0)]
        public int? ResponseCode { get; set; }
    }
}
