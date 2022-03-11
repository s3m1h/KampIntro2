using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiFileUpload.Services;

namespace WebApiFileUpload.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadsController : ControllerBase
    {
        IFile _file;
        public FileUploadsController(IFile file)
        {
            _file = file;
        }


        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok("api calıstırıldı..");
        }

        [HttpPost("upload")]
        public IActionResult Upload([FromForm(Name ="images")] IFormFile file)
        {
            var result = _file.Upload(file);
            return Ok(result);
        }
    }
}
