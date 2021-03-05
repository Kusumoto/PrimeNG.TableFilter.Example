using Newtonsoft.Json;

namespace PrimeNG.TableFilter.Example.ViewModels
{
    public class GenericResponseViewModel<T>
    {
        public GenericResponseViewModel(int total, T data)
        {
            Total = total;
            Data = data;
        }
        
        [JsonProperty("total")]
        public int Total { get; set; }
        
        [JsonProperty("data")]
        public T Data { get; set; }
    }
}