using System;
using Newtonsoft.Json;

namespace Microsoft.Toolkit.Uwp.Services.CognitiveServices
{
    public class WebSearchResult : SchemaBase
    {
        [JsonProperty("_type")]
        public string ResponseType { get; set; }

        [JsonProperty("webPages")]
        public WebSearchWebPages WebPages { get; set; }

        [JsonProperty("news")]
        public WebSearchNews News { get; set; }

        [JsonProperty("relatedSearches")]
        public WebSearchRelatedSearches RelatedSearches { get; set; }

        [JsonProperty("rankingResponse")]
        public WebSearchRankingResponse RankingResponse { get; set; }

    }

    public class WebSearchWebPages
    {
        public string webSearchUrl { get; set; }
        public int totalEstimatedMatches { get; set; }
        public WebSearchWebPage[] value { get; set; }
    }

    public class WebSearchWebPage
    {
        public string id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string displayUrl { get; set; }
        public string snippet { get; set; }
        public DateTime dateLastCrawled { get; set; }
    }

    public class WebSearchNews
    {
        public string id { get; set; }
        public string readLink { get; set; }
        public WebSearchNewsItem[] value { get; set; }
    }

    public class WebSearchNewsItem
    {
        public string name { get; set; }
        public string url { get; set; }
        public WebSearchNewsImage image { get; set; }
        public string description { get; set; }
        public WebSearchNewsEntity[] about { get; set; }
        public WebSearchNewsProvider[] provider { get; set; }
        public DateTime datePublished { get; set; }
        public string category { get; set; }
    }

    public class WebSearchNewsImage
    {
        public string contentUrl { get; set; }
        public WebSearchNewsThumbnail thumbnail { get; set; }
    }

    public class WebSearchNewsThumbnail
    {
        public string contentUrl { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class WebSearchNewsEntity
    {
        public string readLink { get; set; }
        public string name { get; set; }
    }

    public class WebSearchNewsProvider
    {
        public string _type { get; set; }
        public string name { get; set; }
    }

    public class WebSearchRelatedSearches
    {
        public string id { get; set; }
        public WebSearchRelatedSearch[] value { get; set; }
    }

    public class WebSearchRelatedSearch
    {
        public string text { get; set; }
        public string displayText { get; set; }
        public string webSearchUrl { get; set; }
    }

    public class WebSearchRankingResponse
    {
        public WebSearchRankingResponseMainline mainline { get; set; }
    }

    public class WebSearchRankingResponseMainline
    {
        public WebSearchRankingItem[] items { get; set; }
    }

    public class WebSearchRankingItem
    {
        public string answerType { get; set; }
        public int resultIndex { get; set; }
        public WebSearchRankingValue value { get; set; }
    }

    public class WebSearchRankingValue
    {
        public string id { get; set; }
    }

}