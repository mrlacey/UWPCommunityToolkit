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
using System.Linq;
using Microsoft.Toolkit.Uwp.Services.CognitiveServices;
using Windows.UI.Xaml;

namespace Microsoft.Toolkit.Uwp.SampleApp.SamplePages
{
    public sealed partial class CognitiveServicesPage
    {
        public CognitiveServicesPage()
        {
            this.InitializeComponent();

            Markets.ItemsSource = Enum.GetValues(typeof(WebSearchMarket)).Cast<WebSearchMarket>().ToList();
            Markets.SelectedIndex = 0;
            SafeSearch.ItemsSource = Enum.GetValues(typeof(SafeSearch)).Cast<SafeSearch>().ToList();
            SafeSearch.SelectedItem = Services.CognitiveServices.SafeSearch.Moderate;
        }

        private async void SearchButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!await Tools.CheckInternetConnectionAsync())
            {
                return;
            }

            if (string.IsNullOrEmpty(SubscriptionKey.Text))
            {
                return;
            }

            if (string.IsNullOrEmpty(SearchText.Text))
            {
                return;
            }

            WebSearchMarket market = (WebSearchMarket)(Markets?.SelectedItem ?? WebSearchMarket.NotSpecified);
            SafeSearch safeSearch = (SafeSearch)(SafeSearch?.SelectedItem ?? Services.CognitiveServices.SafeSearch.NotSpecified);

            var searchConfig = new WebSearchConfig
            {
                Query = SearchText.Text,
                Market = market,
                SafeSearch = safeSearch
            };

            WebSearchService.Instance.Initialize(SubscriptionKey.Text);

            var result = await WebSearchService.Instance.RequestAsync(searchConfig);

            ListView.ItemsSource = result.WebPages.value;
        }
    }
}
