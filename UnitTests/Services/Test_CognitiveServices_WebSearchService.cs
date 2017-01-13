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

using Microsoft.Toolkit.Uwp.Services.CognitiveServices;
using Microsoft.Toolkit.Uwp.Services.Exceptions;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace UnitTests.Services
{
    [TestClass]
    public class Test_CognitiveServices_WebSearchService
    {
        private const string Query = @"Windows 10";

        [TestCategory("Services")]
        [TestMethod]
        public void Test_WebSearch_RequestFailsWithoutValidKey()
        {
            Assert.ThrowsException<RequestFailedException>(async () =>
            {
                var config = new WebSearchConfig { Query = Query };

                WebSearchService.Instance.Initialize("Valid-subscription-key-should-go-here");

                // This will throw due to invalid subscription key
                var results = await WebSearchService.Instance.RequestAsync(config, 20);
            });
        }
    }
}
