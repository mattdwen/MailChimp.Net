using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MailChimp.Net;

public static class HttpContentExtensions
{
    public static async Task<T> ReadAsAsync<T>(this HttpContent content) {
        var data = await content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<T>(data);
    }
}
