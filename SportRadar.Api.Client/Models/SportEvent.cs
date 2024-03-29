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

    public partial class SportEvent
    {
        /// <summary>
        /// Initializes a new instance of the SportEvent class.
        /// </summary>
        public SportEvent()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SportEvent class.
        /// </summary>
        public SportEvent(string id, System.DateTime scheduled, bool startTimeTbd, TournamentRound tournamentRound, Season season, Tournament tournament, IList<Competitor> competitors, string status = default(string), Venue venue = default(Venue))
        {
            Id = id;
            Scheduled = scheduled;
            StartTimeTbd = startTimeTbd;
            Status = status;
            TournamentRound = tournamentRound;
            Season = season;
            Tournament = tournament;
            Competitors = competitors;
            Venue = venue;
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
        [JsonProperty(PropertyName = "scheduled")]
        public System.DateTime Scheduled { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_time_tbd")]
        public bool StartTimeTbd { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tournament_round")]
        public TournamentRound TournamentRound { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "season")]
        public Season Season { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tournament")]
        public Tournament Tournament { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "competitors")]
        public IList<Competitor> Competitors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "venue")]
        public Venue Venue { get; set; }

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
            if (TournamentRound == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TournamentRound");
            }
            if (Season == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Season");
            }
            if (Tournament == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tournament");
            }
            if (Competitors == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Competitors");
            }
            if (TournamentRound != null)
            {
                TournamentRound.Validate();
            }
            if (Season != null)
            {
                Season.Validate();
            }
            if (Tournament != null)
            {
                Tournament.Validate();
            }
            if (Competitors != null)
            {
                foreach (var element in Competitors)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Venue != null)
            {
                Venue.Validate();
            }
        }
    }
}
