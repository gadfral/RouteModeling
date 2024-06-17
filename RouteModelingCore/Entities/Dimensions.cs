namespace RouteModelingCore.Entities;

public sealed class Dimensions : IEquatable<Dimensions>
{
    public double Height { get; set; }

    public double Width { get; set; }

    public double Length { get; set; }

    public bool Equals(Dimensions? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Height.Equals(other.Height) && Width.Equals(other.Width) && Length.Equals(other.Length);
    }

    public override bool Equals(object? obj)
    {
        return ReferenceEquals(this, obj) || obj is Dimensions other && Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Height, Width, Length);
    }
}