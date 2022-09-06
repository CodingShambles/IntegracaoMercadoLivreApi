using System.Text.Json.Serialization;

namespace MercadoLivreIntegracao.Models;

public class Pictures
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("secure_url")]
    public string? SecuresUrl { get; set; }

    [JsonPropertyName("size")]
    public string? Size { get; set; }

    [JsonPropertyName("max_size")]
    public string? MaxSize { get; set; }

    [JsonPropertyName("quality")]
    public string? Quality { get; set; }
}