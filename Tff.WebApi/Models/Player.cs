namespace Tff.WebApi.Models;

public sealed class Player
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public string? Surname { get; set; }

    public short Number { get; set; }

    public Team? Team { get; set; }
    public int TeamId { get; set; }

    public string? Position { get; set; }
}
