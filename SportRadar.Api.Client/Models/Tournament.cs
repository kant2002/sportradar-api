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

    public partial class Tournament
    {
        /// <summary>
        /// Initializes a new instance of the Tournament class.
        /// </summary>
        public Tournament()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Tournament class.
        /// </summary>
        public Tournament(string id, string name, Sport sport, Category category)
        {
            Id = id;
            Name = name;
            Sport = sport;
            Category = category;
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
        [JsonProperty(PropertyName = "sport")]
        public Sport Sport { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public Category Category { get; set; }

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
            if (Sport == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sport");
            }
            if (Category == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Category");
            }
            if (Sport != null)
            {
                Sport.Validate();
            }
            if (Category != null)
            {
                Category.Validate();
            }
        }
    }
}
