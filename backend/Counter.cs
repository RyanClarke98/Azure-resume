using Newtonsoft.Json;

namespace Company.Function
{
    public class GetResumeCounter

    {
        [JsonProperty(PropertyName="id")]
        public string Id {get; set;}
        
         [JsonProperty(PropertyName= "count")]
        public init Count {get;set;}
    }
}