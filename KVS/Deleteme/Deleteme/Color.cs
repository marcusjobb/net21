namespace Deleteme;

using System;

public class Color
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string FurColor { get; set; } = string.Empty;

    public string EyesColor { get; set; } = string.Empty;

    public string TailColor { get; set; } = string.Empty;
}
