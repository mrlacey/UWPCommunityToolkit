using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Services.Twitter;
using Newtonsoft.Json;

namespace Microsoft.Toolkit.Uwp.Services.CognitiveServices
{
    public class WebSearchParser : IParser<WebSearchResult>
    {
        public IEnumerable<WebSearchResult> Parse(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }

            //return JsonConvert.DeserializeObject<WebSearchResult>(data);
            return new List<WebSearchResult>();
        }
    }
}
