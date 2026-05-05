using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class MemberController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("API funcionando correctamente 🚀");
    }
}