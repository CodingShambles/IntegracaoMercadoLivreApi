using System.Text.Json.Serialization;

namespace MercadoLivreIntegracao.Models;

public class Shipping
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("methods")]
    public List<string>? Methods { get; set; }

    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }

    [JsonPropertyName("dimensions")]
    public string? Dimensions { get; set; }

    [JsonPropertyName("local_pick_up")]
    public bool? LocalPickUp { get; set; }

    [JsonPropertyName("free_shipping")]
    public bool? FreeShipping { get; set; }

    [JsonPropertyName("logistic_type")]
    public string? LogisticType { get; set; }

    [JsonPropertyName("store_pick_up")]
    public bool? StorePickUp { get; set; }
}