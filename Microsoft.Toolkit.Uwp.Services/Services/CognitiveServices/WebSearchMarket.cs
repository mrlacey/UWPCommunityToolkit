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
    /// Markets supported by the Web Search API
    /// As documented at https://dev.cognitive.microsoft.com/docs/services/56b43eeccf5ff8098cef3807/operations/56b4447dcf5ff8098cef380d
    /// </summary>
    public enum WebSearchMarket
    {
        /// <summary>
        /// Not specified
        /// </summary>
        [StringValue("")]
        NotSpecified,

        /// <summary>
        /// Argentina
        /// </summary>
        [StringValue("es-AR")]
        Argentina,

        /// <summary>
        /// Australia
        /// </summary>
        [StringValue("en-AU")]
        Australia,

        /// <summary>
        /// Austria
        /// </summary>
        [StringValue("de-AT")]
        Austria,

        /// <summary>
        /// Belgium (Dutch)
        /// </summary>
        [StringValue("nl-BE")]
        BelgiumDutch,

        /// <summary>
        /// Belgium (French)
        /// </summary>
        [StringValue("fr-BE")]
        BelgiumFrench,

        /// <summary>
        /// Brazil
        /// </summary>
        [StringValue("pt-BR")]
        Brazil,

        /// <summary>
        /// Canada (English)
        /// </summary>
        [StringValue("en-CA")]
        CanadaEnglish,

        /// <summary>
        /// Canada (French)
        /// </summary>
        [StringValue("fr-CA")]
        CanadaFrench,

        /// <summary>
        /// Chile
        /// </summary>
        [StringValue("es-CL")]
        Chile,

        /// <summary>
        /// Denmark
        /// </summary>
        [StringValue("da-DK")]
        Denmark,

        /// <summary>
        /// Finland
        /// </summary>
        [StringValue("fi-FI")]
        Finland,

        /// <summary>
        /// France
        /// </summary>
        [StringValue("fr-FR")]
        France,

        /// <summary>
        /// Germany
        /// </summary>
        [StringValue("de-DE")]
        Germany,

        /// <summary>
        /// Hong Kong
        /// </summary>
        [StringValue("zh-HK")]
        HongKong,

        /// <summary>
        /// India
        /// </summary>
        [StringValue("en-IN")]
        India,

        /// <summary>
        /// Indonesia
        /// </summary>
        [StringValue("en-ID")]
        Indonesia,

        /// <summary>
        /// Ireland
        /// </summary>
        [StringValue("en-IE")]
        Ireland,

        /// <summary>
        /// Italy
        /// </summary>
        [StringValue("it-IT")]
        Italy,

        /// <summary>
        /// Japan
        /// </summary>
        [StringValue("ja-JP")]
        Japan,

        /// <summary>
        /// Korea
        /// </summary>
        [StringValue("ko-KR")]
        Korea,

        /// <summary>
        /// Malaysia
        /// </summary>
        [StringValue("en-MY")]
        Malaysia,

        /// <summary>
        /// Mexico
        /// </summary>
        [StringValue("es-MX")]
        Mexico,

        /// <summary>
        /// Netherlands
        /// </summary>
        [StringValue("nl-NL")]
        Netherlands,

        /// <summary>
        /// New Zealand
        /// </summary>
        [StringValue("en-NZ")]
        NewZealand,

        /// <summary>
        /// Norway
        /// </summary>
        [StringValue("no-NO")]
        Norway,

        /// <summary>
        /// China
        /// </summary>
        [StringValue("zh-CN")]
        China,

        /// <summary>
        /// Poland
        /// </summary>
        [StringValue("pl-PL")]
        Poland,

        /// <summary>
        /// Portugal
        /// </summary>
        [StringValue("pt-PT")]
        Portugal,

        /// <summary>
        /// Philippines
        /// </summary>
        [StringValue("en-PH")]
        Philippines,

        /// <summary>
        /// Russia
        /// </summary>
        [StringValue("ru-RU")]
        Russia,

        /// <summary>
        /// Saudi Arabia
        /// </summary>
        [StringValue("ar-SA")]
        SaudiArabia,

        /// <summary>
        /// South Africa
        /// </summary>
        [StringValue("en-ZA")]
        SouthAfrica,

        /// <summary>
        /// Spain
        /// </summary>
        [StringValue("es-ES")]
        Spain,

        /// <summary>
        /// Sweden
        /// </summary>
        [StringValue("sv-SE")]
        Sweden,

        /// <summary>
        /// Switzerland (French)
        /// </summary>
        [StringValue("fr-CH")]
        SwitzerlandFrench,

        /// <summary>
        /// Switzerland (German)
        /// </summary>
        [StringValue("de-CH")]
        SwitzerlandGerman,

        /// <summary>
        /// Taiwan
        /// </summary>
        [StringValue("zh-TW")]
        Taiwan,

        /// <summary>
        /// Turkey
        /// </summary>
        [StringValue("tr-TR")]
        Turkey,

        /// <summary>
        /// United Kingdom
        /// </summary>
        [StringValue("en-GB")]
        UnitedKingdom,

        /// <summary>
        /// United States (English)
        /// </summary>
        [StringValue("en-US")]
        UnitedStatesEnglish,

        /// <summary>
        /// United States (Spanish)
        /// </summary>
        [StringValue("es-US")]
        UnitedStatesSpanish,
    }
}
