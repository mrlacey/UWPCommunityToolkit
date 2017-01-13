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

using Microsoft.Toolkit.Uwp.Services.Core;

namespace Microsoft.Toolkit.Uwp.Services.CognitiveServices
{
    /// <summary>
    /// Web Search options for filtering adult content from results
    /// </summary>
    public enum SafeSearch
    {
        /// <summary>
        /// Not specified
        /// </summary>
        [StringValue("")]
        NotSpecified,

        /// <summary>
        /// Strict – Filter adult text, images and videos from your search results
        /// </summary>
        [StringValue("Strict")]
        Strict,

        /// <summary>
        /// Moderate – Filter adult images and videos but not text from your search results
        /// </summary>
        [StringValue("Moderate")]
        Moderate,

        /// <summary>
        /// Off – Don’t filter adult content from your search results
        /// </summary>
        [StringValue("Off")]
        Off
    }
}
