using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tff.WebApi.Models;
using Tff.WebApi.Models.Dtos.Players;
using Tff.WebApi.Repositories;
using Tff.WebApi.Services.Mappers;

namespace Tff.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlayerController(BaseDbContext context, PlayerMapper playerMapper) : ControllerBase
{

    [HttpPost("add")]
    public IActionResult Add(PlayerAddRequestDto playerAddRequestDto)
    {
        Player player = playerMapper.ConvertToEntity(playerAddRequestDto); //dönüştürme işlemi

        context.Add(player);
        context.SaveChanges();

        return Ok("Ekleme işlemi başarılı");
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var values = context.Players.Include(x=>x.Team).ToList();
        List<PlayerResponseDto> responses = new List<PlayerResponseDto>();
        foreach (Player player in values) { 
        PlayerResponseDto responseDto = playerMapper.ConvertToDto(player);
            responses.Add(responseDto);
        }
        return Ok(responses);
    }

    [HttpGet]
    public IActionResult Deneme()
    {
        Player player = new Player();
        PlayerResponseDto playerResponseDto = player;
        return Ok();
    }
}
