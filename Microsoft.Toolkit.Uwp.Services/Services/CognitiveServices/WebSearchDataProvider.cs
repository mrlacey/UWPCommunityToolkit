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
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Services.Core;
using Microsoft.Toolkit.Uwp.Services.Exceptions;
using Windows.Web.Http;
using Newtonsoft.Json;

namespace Microsoft.Toolkit.Uwp.Services.CognitiveServices
{
    public class WebSearchDataProvider// : DataProviderBase<WebSearchConfig, WebSearchResult>
    {
        /// <summary>
        /// Base Url for service.
        /// </summary>
        private const string BaseUrl = "https://api.cognitive.microsoft.com/bing/v5.0/search";

        public string SubscriptionKey { get; set; }

        public async Task<WebSearchResult> LoadDataAsync(WebSearchConfig config, int maxRecords, int pageIndex)
        {
            ValidateConfig(config);

            var result = await GetDataAsync(config, maxRecords, pageIndex);
            if (result != null)
            {
                return result;
            }

            return new WebSearchResult();
        }

        protected async Task<WebSearchResult> GetDataAsync(WebSearchConfig config, int count, int offset)
        {
            var marketValue = config.Market.GetStringValue();
            var safeSearchValue = config.SafeSearch.GetStringValue();

            var marketParam = string.IsNullOrWhiteSpace(marketValue) ? string.Empty : $"&mkt={marketValue}";
            var safeSearchParam = string.IsNullOrWhiteSpace(safeSearchValue) ? string.Empty : $"&safesearch={safeSearchValue}";

            var uri = new Uri($"{BaseUrl}?q={WebUtility.UrlEncode(config.Query)}&count={count}&offset={offset}{marketParam}{safeSearchParam}");

            using (HttpHelperRequest request = new HttpHelperRequest(uri, HttpMethod.Get))
            {
                request.Headers["Ocp-Apim-Subscription-Key"] = SubscriptionKey;

                using (var response = await HttpHelper.Instance.SendRequestAsync(request).ConfigureAwait(false))
                {
                    var data = await response.GetTextResultAsync().ConfigureAwait(false);

                    if (response.Success && !string.IsNullOrEmpty(data))
                    {
                        return JsonConvert.DeserializeObject<WebSearchResult>(data);
                    }

                    throw new RequestFailedException(response.StatusCode, data);
                }
            }
        }

        protected void ValidateConfig(WebSearchConfig config)
        {
            if (config == null)
            {
                throw new ConfigNullException();
            }

            if (config.Query == null)
            {
                throw new ConfigParameterNullException(nameof(config.Query));
            }
        }
    }
}
