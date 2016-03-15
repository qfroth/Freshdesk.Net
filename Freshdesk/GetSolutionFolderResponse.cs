using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshdesk
{
    public class GetSolutionFolderResponse
    {
        [JsonProperty(PropertyName = "folder")]
        public GetSolutionFolderInfo Folder { get; set; }
    }

    public class GetSolutionFolderInfo
    {
        [JsonProperty(PropertyName = "category_id")]
        public long CategoryId { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "is_default")]
        public bool isDefault { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "articles")]
        public IEnumerable<GetSolutionArticleInfo> Articles { get; set; }
    }
}
