using Newtonsoft.Json;

namespace Prototype
{
    public static class DeepCloner
    {
        public static T DeepClone<T>(this T source)
        {
            var serialized = JsonConvert.SerializeObject(source);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
    }
}
