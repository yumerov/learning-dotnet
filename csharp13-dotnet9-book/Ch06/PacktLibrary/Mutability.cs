namespace Packt.Shared;

/// <summary>
/// Mutable record class
/// </summary>
public record class C1
{
    public string? Name { get; set; }
}

/// <summary>
/// Immutable record class
/// </summary>
/// <param name="Name"></param>
public record class C2(string? Name);

/// <summary>
/// Mutable record class
/// </summary>
public record struct S1
{
    public string? Name { get; set; }
}

/// <summary>
/// Mutable record struct
/// </summary>
/// <param name="Name"></param>
public record struct S2(string? Name);

/// <summary>
/// Immutable record struct
/// </summary>
/// <param name="Name"></param>
public readonly record struct S3(string? Name);