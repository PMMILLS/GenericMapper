using GenericMapper.Interfaces;
using Newtonsoft.Json;

namespace GenericMapper.Implementations
{
    public class ObjectMapper : IGenericMapper
    {
        public R Map<T, R>(T t)
        {
            var json = JsonConvert.SerializeObject(t);
            var r = JsonConvert.DeserializeObject<R>(json);

            return r;
        }
    }
}
