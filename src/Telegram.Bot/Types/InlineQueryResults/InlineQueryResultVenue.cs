using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.Bot.Types.InlineQueryResults.Abstractions;
using Telegram.Bot.Types.InputMessageContents;

namespace Telegram.Bot.Types.InlineQueryResults
{
    /// <summary>
    /// Represents a venue. By default, the venue will be sent by the user. Alternatively, you can use <see cref="InputMessageContents.InputMessageContent"/> to send a message with the specified content instead of the venue.
    /// </summary>
    /// <remarks>
    /// This will only work in Telegram versions released after 9 April, 2016. Older clients will ignore them.
    /// </remarks>
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class InlineQueryResultVenue : InlineQueryResult,
                                          IThumbnailInlineQueryResult,
                                          ITitleInlineQueryResult,
                                          IInputMessageContentResult,
                                          ILocationInlineQueryResult
    {
        /// <summary>
        /// Initializes a new inline query result
        /// </summary>
        public InlineQueryResultVenue()
            : base(InlineQueryResultType.Venue)
        { }

        /// <summary>
        /// Initializes a new inline query result
        /// </summary>
        /// <param name="id">Unique identifier of this result</param>
        /// <param name="latitude">Latitude of the location in degrees</param>
        /// <param name="longitude">Longitude of the location in degrees</param>
        /// <param name="title">Title of the result</param>
        /// <param name="address">Address of the venue</param>
        public InlineQueryResultVenue(
            string id,
            float latitude,
            float longitude,
            string title,
            string address)
            : this()
        {
            Id = id;
            Latitude = latitude;
            Longitude = longitude;
            Title = title;
            Address = address;
        }

        /// <inheritdoc />
        [JsonProperty(Required = Required.Always)]
        public float Latitude { get; set; }

        /// <inheritdoc />
        [JsonProperty(Required = Required.Always)]
        public float Longitude { get; set; }

        /// <summary>
        /// Address of the venue
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Address { get; set; }

        /// <inheritdoc />
        [JsonProperty(Required = Required.Always)]
        public string Title { get; set; }

        /// <summary>
        /// Optional. Foursquare identifier of the venue if known
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FoursquareId { get; set; }

        /// <inheritdoc />
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Uri ThumbUrl { get; set; }

        /// <inheritdoc />
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ThumbWidth { get; set; }

        /// <inheritdoc />
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ThumbHeight { get; set; }

        /// <inheritdoc />
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }
    }
}
