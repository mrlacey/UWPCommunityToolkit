// ******************************************************************
// Copyright (c) Microsoft. All rights reserved.
// This code is licensed under the MIT License (MIT).
// THE CODE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH
// THE CODE OR THE USE OR OTHER DEALINGS IN THE CODE.
// ******************************************************************

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Services.Core;

namespace Microsoft.Toolkit.Uwp.Services.CognitiveServices
{
    /// <summary>
    /// Class for performing a web search via the Cognitive Services API
    /// </summary>
    public class WebSearchService // : IDataService<WebSearchDataProvider, WebSearchResult, WebSearchConfig>, IIncrementalSource<WebSearchResult>
    {
        private readonly WebSearchConfig _config;

        private WebSearchDataProvider webSearchDataProvider;

        /// <summary>
        /// Private singleton field.
        /// </summary>
        private static WebSearchService instance;

        /// <summary>
        /// Gets public singleton property.
        /// </summary>
        public static WebSearchService Instance => instance ?? (instance = new WebSearchService());

        /// <summary>
        /// Initialize the underlying provider with the subscription key for subsequent requests.
        /// </summary>
        /// <param name="subscriptionKey">Subscription key which provides access to this API</param>
        /// <returns>Success or failure.</returns>
        public bool Initialize(string subscriptionKey)
        {
            if (string.IsNullOrEmpty(subscriptionKey))
            {
                throw new ArgumentNullException(nameof(subscriptionKey));
            }

            Provider.SubscriptionKey = subscriptionKey;

            return true;
        }

        /// <summary>
        /// Gets a reference to an instance of the underlying data provider.
        /// </summary>
        public WebSearchDataProvider Provider => webSearchDataProvider ?? (webSearchDataProvider = new WebSearchDataProvider());

        public async Task<WebSearchResult> RequestAsync(WebSearchConfig config, int count = 10, int offset = 0)
        {
            var results = await Provider.LoadDataAsync(config, count, offset);

            return results;
        }

        // TODO: these methods
        /*
            // do this and add search type to config - remove other XxxSearchAsync methods from below
        public async Task<WebSearchResult> RequestSearchAsync(WebSearchConfig config) { }
        public async Task<WebSearchResult> RequestTrendingAsync(WebSearchConfig config) { } // use news/video/image type from config

        public async Task<WebSearchResult> NewsCategorySearchAsync(NewsCategory category) { }
        public async Task<WebSearchResult> AutoSuggestSuggestion(string searchTerm) { }
        public async Task<WebSearchResult> VideoDetailsAsync(string id, VideoSearchModule modulesRequested) { }

        public async Task<WebSearchResult> WebSearchAsync(string searchTerm) { }
        public async Task<WebSearchResult> NewsSearchAsync(string searchTerm) { }
        public async Task<WebSearchResult> NewsCategorySearchAsync(NewsCategory category) { }
        public async Task<WebSearchResult> NewsTrendingTopicsAsync() { }
        public async Task<WebSearchResult> VideoDetailsAsync(string id, VideoSearchModule modulesRequested) { }
        public async Task<WebSearchResult> VideoSearchAsync(string searchTerm) { }
        public async Task<WebSearchResult> VideoTrendingTopicsAsync() { }
      //  public async Task<WebSearchResult> ImageInsightsAsync() { } *NOT THIS*
        public async Task<WebSearchResult> ImageSearchAsync(string searchTerm) { }
        public async Task<WebSearchResult> TrendingImagesAsync() { }

        public async Task<WebSearchResult> AutoSuggestSuggestion(string searchTerm) { }*/

    }
}
