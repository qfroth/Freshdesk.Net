using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshdesk
{
    public class GetSolutionArticleResponse
    {
        [JsonProperty(PropertyName = "article")]
        public GetSolutionArticleInfo Article { get; set; }
    }

    public class GetSolutionArticleInfo
    {
        [JsonProperty(PropertyName = "art_type")]
        public int ArtType { get; set; }

        [JsonProperty(PropertyName = "desc_un_html")]
        public string DescUnHtml { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "status")]
        public int Status { get; set; }

        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }
    }
}
