// Code generated by Microsoft (R) AutoRest Code Generator 1.2.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace ApplicationGateway.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response for GetConnectionSharedKey API service call
    /// </summary>
    public partial class ConnectionSharedKey
    {
        /// <summary>
        /// Initializes a new instance of the ConnectionSharedKey class.
        /// </summary>
        public ConnectionSharedKey()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectionSharedKey class.
        /// </summary>
        /// <param name="value">The virtual network connection shared key
        /// value.</param>
        public ConnectionSharedKey(string value)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual network connection shared key value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
