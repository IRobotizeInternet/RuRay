using System;
using System.IO;

namespace SupportingScripts
{
    public class IterateFiles
    {
        public void PrintCode()
        {
            var directories = Directory.GetDirectories(@"D:\Dev\NgCore\CryptoFake\RuRay\RuRay\RuRay.BLL\App\LoggedIn\Pages\");

            foreach (var dir in directories)
            {
                var name = dir.Substring(dir.LastIndexOf("\\") + 1);
                //  var service = $"public Task<bool> Navigate{name}()"
                //+ "{" +
                //$"    new Page{name}().GoToPage(); " +
                // "    return Task.FromResult(true); " +
                // "}";
                //var service = $"Task<bool> Navigate{name}();";

                var service =
                " [HttpPost(\"\")]"
               + "[SwaggerResponse((int)HttpStatusCode.OK, Description = \"Returns 200\")]"
               + "[SwaggerResponse((int)HttpStatusCode.BadRequest, Description = \"Page Not Found\")]"
               + "[SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = \"Unexpected error\")]"
               + $"public async Task<IActionResult> Navigate{name}()"
               + "{"
               + $"   await _serviceNavigation.Navigate{name}();"
               + "   return Ok();"
               + "}";
                Console.WriteLine(service);
            }
        }
    }
}
