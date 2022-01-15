using System.Threading.Tasks;
using Google.Cloud.Functions.Framework;
using Google.Cloud.Functions.Hosting;
using Microsoft.AspNetCore.Http;

namespace MyApi
{
  [FunctionsStartup(typeof(Startup))]
  public class Function : IHttpFunction
  {
    public Task HandleAsync(HttpContext context) =>
        Task.CompletedTask;
  }
}
