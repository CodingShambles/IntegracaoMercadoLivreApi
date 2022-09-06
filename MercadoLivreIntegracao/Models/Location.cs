using System.Text.Json.Serialization;

namespace MercadoLivreIntegracao.Models;

public class Location
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}