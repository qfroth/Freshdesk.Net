using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freshdesk
{
    public class GetSolutionCategoriesResponse
    {
        [JsonProperty(PropertyName = "category")]
        public GetSolutionCategoryInfo Category { get; set; }
    }

    public class GetSolutionCategoryInfo
    {
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "folders")]
        public IEnumerable<GetSolutionFolderInfo> Folders { get; set; }

        [JsonProperty(PropertyName = "id")]
        public long Id { get; set; }

        [JsonProperty(PropertyName = "is_default")]
        public bool IsDefault { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
