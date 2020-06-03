using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sticker.Core.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {
        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> Post()
        {
            var files = Request.Form.Files;
            var fileResultList = new List<string>();

            if (files.Any(f => f.Length == 0))
            {
                return BadRequest();
            }

            foreach (var file in files)
            {
                var fileName = $@"{FileHash(file)}{Path.GetExtension(file.FileName)}";
                var apiPath = string.Join('/', @"/image", fileName);
                var fullPath = Path.Combine("data", fileName);
                await using var stream = new FileStream(fullPath, FileMode.Create);
                await file.CopyToAsync(stream);
                Console.WriteLine($"api path: {apiPath}, save path: {fullPath}");
                fileResultList.Add(apiPath);
            }

            return Ok(new {fileResultList});
        }

        private string FileHash(IFormFile file)
        {
            MemoryStream stream = new MemoryStream();
            file.OpenReadStream().CopyTo(stream);

            byte[] bytes = MD5.Create().ComputeHash(stream.ToArray());
            return BitConverter.ToString(bytes).Replace("-", string.Empty).ToLower();
        }
    }
}