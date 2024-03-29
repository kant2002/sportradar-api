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

    public partial class Competitor
    {
        /// <summary>
        /// Initializes a new instance of the Competitor class.
        /// </summary>
        public Competitor()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Competitor class.
        /// </summary>
        public Competitor(string id, string name, string country, string countryCode, string abbreviation, string qualifier)
        {
            Id = id;
            Name = name;
            Country = country;
            CountryCode = countryCode;
            Abbreviation = abbreviation;
            Qualifier = qualifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "qualifier")]
        public string Qualifier { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Country == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Country");
            }
            if (CountryCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CountryCode");
            }
            if (Abbreviation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Abbreviation");
            }
            if (Qualifier == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Qualifier");
            }
        }
    }
}
