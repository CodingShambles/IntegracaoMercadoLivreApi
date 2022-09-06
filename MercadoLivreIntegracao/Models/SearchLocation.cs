using System.Text.Json.Serialization;

namespace MercadoLivreIntegracao.Models;

public class SearchLocation
{
    [JsonPropertyName("neighborhood")]
    public Location? NeighbordHood { get; set; }

    [JsonPropertyName("city")]
    public Location? City { get; set; }

    [JsonPropertyName("state")]
    public Location? State { get; set; }
}