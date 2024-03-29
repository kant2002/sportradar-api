// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.SportRadar.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class DailyResult
    {
        /// <summary>
        /// Initializes a new instance of the DailyResult class.
        /// </summary>
        public DailyResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DailyResult class.
        /// </summary>
        public DailyResult(SportEvent sportEvent, SportEventStatus sportEventStatus)
        {
            SportEvent = sportEvent;
            SportEventStatus = sportEventStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sport_event")]
        public SportEvent SportEvent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sport_event_status")]
        public SportEventStatus SportEventStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (SportEvent == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SportEvent");
            }
            if (SportEventStatus == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SportEventStatus");
            }
            if (SportEvent != null)
            {
                SportEvent.Validate();
            }
            if (SportEventStatus != null)
            {
                SportEventStatus.Validate();
            }
        }
    }
}
