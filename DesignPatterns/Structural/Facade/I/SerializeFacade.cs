using System.Text.Json;

namespace DesignPatterns.Structural.Facade.I
{
    internal class SerializeFacade
    {
        static JsonSerializerOptions Options { get; } = new()
        {
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault,
            IgnoreReadOnlyProperties = true,
            WriteIndented = true
        };

        public static string Serialize(object obj)
        {
            return JsonSerializer.Serialize(obj, Options);
        }
    }
}
