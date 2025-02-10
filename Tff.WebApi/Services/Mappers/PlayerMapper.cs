using Tff.WebApi.Models;
using Tff.WebApi.Models.Dtos.Players;

namespace Tff.WebApi.Services.Mappers;

public class PlayerMapper
{
    public Player ConvertToEntity(PlayerAddRequestDto dto)
    {
        return new Player
        {

            Name = dto.Name,
            Surname = dto.Surname,
            Position = dto.Position,
            Number = dto.Number,
            TeamId = dto.TeamId,
        };
    }

    public PlayerResponseDto ConvertToDto(Player player)
    {
        return new PlayerResponseDto
        {
            Id = player.Id,
            Number = player.Number,
            Name = player.Name,
            Surname = player.Surname,
            Position = player.Position,
            TeamId = player.TeamId,
            TeamName = player.Team.Name,
        };
    }
}
