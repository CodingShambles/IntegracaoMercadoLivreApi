using Microsoft.AspNetCore.Mvc;
using MercadoLivreIntegracao.Extensions;
using MercadoLivreIntegracao.API;
using System.Text.Json;
using MercadoLivreIntegracao.Models;

namespace MercadoLivreIntegracao.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IntegrationController : ControllerBase
    {
        protected readonly ILogger<IntegrationController> _logger;
        [HttpGet("getItems")]
        public string Get(string id)
        {
            if (id is null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            try
            {
                var result = RequestsApi.Get(id);
                var data = $"{Util.GetRelevantData(DateTime.Now)}, {result.Status}";

                var streamParameter = Util.StringToStream(data);

                Util.WriteToLog(streamParameter);

                return result.Result;
            }
            catch (Exception ex)
            {
                throw new BadHttpRequestException($"Não foi possível obter as informações do Produto {id}. {ex.Message}");
            }
        }
    }
}