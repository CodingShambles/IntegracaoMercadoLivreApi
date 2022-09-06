using MercadoLivreIntegracao.Models;

namespace MercadoLivreIntegracao.Extensions;

public class Util
{
    public Util()
    {
    }

    public static Task WriteToLog(Stream data)
    {
        string path = "requestsLog.log";

        try
        {
            var buffer = new byte[16 * 1024];
            var memoryStream = new MemoryStream();

            data.CopyTo(memoryStream);
            buffer = memoryStream.ToArray();

            string result = System.Text.Encoding.UTF8.GetString(buffer);

            File.WriteAllTextAsync(path, result);

            return Task.CompletedTask;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Não foi possível armazenar as informações no arquivo de log. {ex.Message}");

            return Task.CompletedTask;
        }
    }

    public static string GetRelevantData(DateTime parameter)
    {
        var result = $"{parameter.Hour}:{parameter.Minute}:{parameter.Second}";

        return result;
    }

    public static Stream StringToStream(string result)
    {
        var stream = new MemoryStream();
        var writer = new StreamWriter(stream);

        writer.Write(result);
        writer.Flush();
        stream.Position = 0;

        return stream;
    }

    public static Root Deserialize(Stream result)
    {
        var content = new Root();

        return content;
    }
}
