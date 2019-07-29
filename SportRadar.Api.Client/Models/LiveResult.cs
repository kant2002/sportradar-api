// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.SportRadar.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class LiveResult
    {
        /// <summary>
        /// Initializes a new instance of the LiveResult class.
        /// </summary>
        public LiveResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LiveResult class.
        /// </summary>
        public LiveResult(System.DateTime generatedAt, string schema, string message = default(string), IList<DailyResult> results = default(IList<DailyResult>))
        {
            GeneratedAt = generatedAt;
            Schema = schema;
            Message = message;
            Results = results;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "generated_at")]
        public System.DateTime GeneratedAt { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "schema")]
        public string Schema { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<DailyResult> Results { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Schema == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Schema");
            }
            if (Results != null)
            {
                foreach (var element in Results)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
