using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace repoInsight.Models;

public class GithubContributors
{

    public partial class Welcome
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("items")]
        public Items Items { get; set; }
    }

    public partial class Items
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }

        [JsonProperty("required")]
        public string[] ItemsRequired { get; set; }
    }

    public partial class Properties
    {
        [JsonProperty("login")]
        public Contributions Login { get; set; }

        [JsonProperty("id")]
        public Contributions Id { get; set; }

        [JsonProperty("node_id")]
        public Contributions NodeId { get; set; }

        [JsonProperty("avatar_url")]
        public Url AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public GravatarId GravatarId { get; set; }

        [JsonProperty("url")]
        public Url Url { get; set; }

        [JsonProperty("html_url")]
        public Url HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public Url FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public Contributions FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public Contributions GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public Contributions StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Url SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public Url OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Url ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public Contributions EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Url ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public Contributions Type { get; set; }

        [JsonProperty("site_admin")]
        public Contributions SiteAdmin { get; set; }

        [JsonProperty("contributions")]
        public Contributions Contributions { get; set; }

        [JsonProperty("email")]
        public Contributions Email { get; set; }

        [JsonProperty("name")]
        public Contributions Name { get; set; }
    }

    public partial class Url
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }

    public partial class Contributions
    {
        [JsonProperty("type")]
        public TypeEnum Type { get; set; }
    }

    public partial class GravatarId
    {
        [JsonProperty("type")]
        public string[] Type { get; set; }
    }

    public enum TypeEnum { Boolean, Integer, String };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                TypeEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "boolean":
                    return TypeEnum.Boolean;
                case "integer":
                    return TypeEnum.Integer;
                case "string":
                    return TypeEnum.String;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Boolean:
                    serializer.Serialize(writer, "boolean");
                    return;
                case TypeEnum.Integer:
                    serializer.Serialize(writer, "integer");
                    return;
                case TypeEnum.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }
}
