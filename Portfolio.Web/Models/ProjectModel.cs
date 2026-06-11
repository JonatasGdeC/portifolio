namespace Portfolio.Web.Models;

public record ProjectModel
{
    public string Title { get; init; } = string.Empty;
    public string Summary { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public string Category { get; init; } = string.Empty;
    public bool Studies { get; set; }
    public List<string> Tools { get; init; } = [];
    public Links Links { get; init; } = new();
    public List<string> Images { get; init; } = [];
}

public record Links
{
    public string? Production { get; init; }
    public string? FrontendGithub { get; init; }
    public string? BackendGithub { get; init; }
}