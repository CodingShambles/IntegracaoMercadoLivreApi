using System.Text.Json.Serialization;

namespace MercadoLivreIntegracao.Models;

public class SaleTerms
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value_id")]
    public string? ValueId { get; set; }

    [JsonPropertyName("value_name")]
    public string? ValueName { get; set; }

    [JsonPropertyName("value_struct")]
    public ValueStruct? ValueStruct { get; set; }

    [JsonPropertyName("values")]
    public List<Values>? Values { get; set; }
}