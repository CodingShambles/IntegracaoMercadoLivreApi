using System.Text.Json.Serialization;

namespace MercadoLivreIntegracao.Models;

public class Values
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("struct")]
    public ValueStruct? Struct { get; set; }
}