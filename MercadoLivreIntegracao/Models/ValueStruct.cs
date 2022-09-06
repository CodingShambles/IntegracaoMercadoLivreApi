using System.Text.Json.Serialization;

namespace MercadoLivreIntegracao.Models;

public class ValueStruct
{
    [JsonPropertyName("number")]
    public long? Number { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}