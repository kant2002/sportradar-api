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

    public partial class Venue
    {
        /// <summary>
        /// Initializes a new instance of the Venue class.
        /// </summary>
        public Venue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Venue class.
        /// </summary>
        public Venue(string id, string name, int capacity, string cityName, string countryName, string countryCode)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
            CityName = cityName;
            CountryName = countryName;
            CountryCode = countryCode;
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
        [JsonProperty(PropertyName = "capacity")]
        public int Capacity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "country_code")]
        public string CountryCode { get; set; }

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
            if (CityName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CityName");
            }
            if (CountryName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CountryName");
            }
            if (CountryCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CountryCode");
            }
        }
    }
}
