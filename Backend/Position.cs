// Position.cs
namespace MazeBfs;

// Immutable value type: two positions with the same row/column are equal,
// so it can be used directly as a key in HashSet / Dictionary.
public readonly record struct Position(int Row, int Column)
{
    // Returns the position reached after moving by the given offsets.
    public Position Move(int rowOffset, int columnOffset) => new(Row + rowOffset, Column + columnOffset);

    public override string ToString() => $"({Row},{Column})";
}
