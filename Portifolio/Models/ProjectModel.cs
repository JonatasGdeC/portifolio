using System.Text.Json.Serialization;

namespace Portifolio.Models;

public class ProjectModel
{
    public string Title { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public List<string> Tools { get; set; } = [];
    public string? Url { get; set; }

    [JsonPropertyName(name: "githubUrl")]
    public string? UrlGithub { get; set; }

    public List<string> Images { get; set; } = [];
}
