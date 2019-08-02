// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AndriiKurdiumov.SportRadar.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SportRadarSoccerAPI.
    /// </summary>
    public static partial class SportRadarSoccerAPIExtensions
    {
            /// <summary>
            /// Get daily results
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accessLevel'>
            /// Possible values include: 'x', 't'
            /// </param>
            /// <param name='leagueGroup'>
            /// Possible values include: 'eu', 'intl', 'am', 'as', 'global', 'other'
            /// </param>
            /// <param name='languageCode'>
            /// </param>
            /// <param name='date'>
            /// The calendar year
            /// </param>
            public static DailyResults GetDailyResults(this ISportRadarSoccerAPI operations, string accessLevel, string leagueGroup, string languageCode, System.DateTime date)
            {
                return operations.GetDailyResultsAsync(accessLevel, leagueGroup, languageCode, date).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get daily results
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accessLevel'>
            /// Possible values include: 'x', 't'
            /// </param>
            /// <param name='leagueGroup'>
            /// Possible values include: 'eu', 'intl', 'am', 'as', 'global', 'other'
            /// </param>
            /// <param name='languageCode'>
            /// </param>
            /// <param name='date'>
            /// The calendar year
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DailyResults> GetDailyResultsAsync(this ISportRadarSoccerAPI operations, string accessLevel, string leagueGroup, string languageCode, System.DateTime date, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDailyResultsWithHttpMessagesAsync(accessLevel, leagueGroup, languageCode, date, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get matches on the specific day
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accessLevel'>
            /// Possible values include: 'x', 't'
            /// </param>
            /// <param name='leagueGroup'>
            /// Possible values include: 'eu', 'intl', 'am', 'as', 'global', 'other'
            /// </param>
            /// <param name='languageCode'>
            /// </param>
            /// <param name='date'>
            /// The calendar year
            /// </param>
            public static Schedule GetDailySchedule(this ISportRadarSoccerAPI operations, string accessLevel, string leagueGroup, string languageCode, System.DateTime date)
            {
                return operations.GetDailyScheduleAsync(accessLevel, leagueGroup, languageCode, date).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get matches on the specific day
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accessLevel'>
            /// Possible values include: 'x', 't'
            /// </param>
            /// <param name='leagueGroup'>
            /// Possible values include: 'eu', 'intl', 'am', 'as', 'global', 'other'
            /// </param>
            /// <param name='languageCode'>
            /// </param>
            /// <param name='date'>
            /// The calendar year
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Schedule> GetDailyScheduleAsync(this ISportRadarSoccerAPI operations, string accessLevel, string leagueGroup, string languageCode, System.DateTime date, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDailyScheduleWithHttpMessagesAsync(accessLevel, leagueGroup, languageCode, date, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get live results
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accessLevel'>
            /// Possible values include: 'x', 't'
            /// </param>
            /// <param name='leagueGroup'>
            /// Possible values include: 'eu', 'intl', 'am', 'as', 'global', 'other'
            /// </param>
            /// <param name='languageCode'>
            /// </param>
            public static LiveResult GetLiveResults(this ISportRadarSoccerAPI operations, string accessLevel, string leagueGroup, string languageCode)
            {
                return operations.GetLiveResultsAsync(accessLevel, leagueGroup, languageCode).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get live results
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='accessLevel'>
            /// Possible values include: 'x', 't'
            /// </param>
            /// <param name='leagueGroup'>
            /// Possible values include: 'eu', 'intl', 'am', 'as', 'global', 'other'
            /// </param>
            /// <param name='languageCode'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<LiveResult> GetLiveResultsAsync(this ISportRadarSoccerAPI operations, string accessLevel, string leagueGroup, string languageCode, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLiveResultsWithHttpMessagesAsync(accessLevel, leagueGroup, languageCode, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
