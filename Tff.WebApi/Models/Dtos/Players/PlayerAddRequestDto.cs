namespace Tff.WebApi.Models.Dtos.Players;

public sealed class PlayerAddRequestDto
{

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public short Number { get; set; }

    public int TeamId { get; set; }

    public string? Position { get; set; }
}
