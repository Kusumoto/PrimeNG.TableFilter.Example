using Newtonsoft.Json;

namespace PrimeNG.TableFilter.Example.ViewModels
{
    public class WebBoardViewModel
    {
        [JsonProperty("no")]
        public int No { get; set; }
        
        [JsonProperty("question")]
        public string Question { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("email")]
        public string Email { get; set; }
    }
}