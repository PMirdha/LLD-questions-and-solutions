namespace SnakeLadderGame.Domain.ValueObjects;

public enum PositionType
{
    Normal,
    Snake,
    Ladder
}

public class PositionValueObject
{
    public int Value { get; }
    public PositionType Type { get; }
    public PositionValueObject NextPosition { get; }

    public PositionValueObject(int value, PositionType type, PositionValueObject nextPosition)
    {
        Value = value;
        Type = type;
        NextPosition = nextPosition;
    }
}