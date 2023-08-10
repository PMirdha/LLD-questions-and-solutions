using SnakeLadderGame.Domain.ValueObjects;

namespace SnakeLadderGame.Domain.Entities;

public class BoardAggregate
{
    public PositionValueObject InitialPosition { get; }
    public PositionValueObject FinalPosition { get; }
}