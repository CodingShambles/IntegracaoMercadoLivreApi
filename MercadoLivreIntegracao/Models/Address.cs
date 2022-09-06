using System.Text.Json.Serialization;

namespace MercadoLivreIntegracao.Models;

public class Address
{
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    [JsonPropertyName("city")]
    public Location? City { get; set; }

    [JsonPropertyName("state")]
    public Location? State { get; set; }

    [JsonPropertyName("country")]
    public Location? Country { get; set; }

    [JsonPropertyName("search_location")]
    public SearchLocation? SearchLocation { get; set; }
}