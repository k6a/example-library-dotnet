using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace K6a.Example
{
    /// <summary>
    /// Foo request
    /// </summary>
    [DataContract]
    [Serializable]
    public class FooRequest
    {
        /// <summary>
        /// Name to register.
        /// </summary>
        [DataMember(EmitDefaultValue = false, IsRequired = true, Name = "name", Order = 0)]
        [JsonPropertyName("name"), JsonPropertyOrder(0)]
        public string? Name { get; set; }
    }
}
