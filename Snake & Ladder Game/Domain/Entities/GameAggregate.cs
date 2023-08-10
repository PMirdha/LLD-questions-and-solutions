using SnakeLadderGame.Domain.ValueObjects;

namespace SnakeLadderGame.Domain.Entities;

public enum GameStatus
{
    NotStarted,
    Started,
    Finished
}
public class GameAggregate
{
    public List<PlayerValueObject> Players { get; }
    public GameStatus Status { get; }
    // public Map
    public void AddPlayer(PlayerValueObject player) { }
    public void StartGame() { }
    public void SetPlayerPosition(PlayerValueObject player, PositionValueObject position) { }
}