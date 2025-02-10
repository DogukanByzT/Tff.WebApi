using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tff.WebApi.Models;
using Tff.WebApi.Repositories;

namespace Tff.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class TeamsController(BaseDbContext context) : ControllerBase
{

    [HttpPost("add")]
    public IActionResult Add(Team team)
    {
        context.Add(team);
        context.SaveChanges();

        return Ok("Takım başarıyla eklendi.");
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var values = context.Teams.ToList();
        return Ok(values);
    }


    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var value = context.Teams.Where(x => x.Id == id);
        return Ok(value);
    }

    [HttpGet("delete")]
    public IActionResult Delete(int id)
    {
        var value = context.Teams.Where(x => x.Id == id);
        context.Remove(value);
        return Ok();
    }
}
