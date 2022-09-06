using MercadoLivreIntegracao.Models;
using System.Text.Json;

namespace MercadoLivreIntegracao.API;

public class RequestsApi
{
    private static readonly HttpClient client = new();
    private static readonly string baseUrl = "https://api.mercadolibre.com";

    public static async Task<string> Get(string id)
    {
        string getUrl = $"{baseUrl}/items/{id}";

        try
        {
            var response = await client.GetAsync(getUrl);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            return responseBody;
        }
        catch(Exception ex)
        {
            throw new BadHttpRequestException($"Não foi possível realizar a requisição, {ex.Message}");
        }
    }
}


