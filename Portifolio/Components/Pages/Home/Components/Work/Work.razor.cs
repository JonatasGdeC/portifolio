using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Portifolio.Models;

namespace Portifolio.Components.Pages.Home.Components.Work;

public partial class Work
{
    [Inject]
    private IWebHostEnvironment Environment { get; set; } = default!;

    private List<ProjectModel> Projects { get; set; } = [];

    private ProjectModel? SelectedProject { get; set; }

    private int ActiveImageIndex { get; set; }

    protected override async Task OnInitializedAsync()
    {
        string projectsPath = Path.Combine(path1: GetWebRootPath(), path2: "mock", path3: "projects.json");

        if (!File.Exists(path: projectsPath))
        {
            return;
        }

        string projectsJson = await File.ReadAllTextAsync(path: projectsPath);
        Projects = JsonSerializer.Deserialize<List<ProjectModel>>(
            json: projectsJson,
            options: new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? [];
    }

    private void OpenProject(ProjectModel project)
    {
        SelectedProject = project;
        ActiveImageIndex = 0;
    }

    private void CloseProject()
    {
        SelectedProject = null;
        ActiveImageIndex = 0;
    }

    private void SetImage(int imageIndex)
    {
        ActiveImageIndex = imageIndex;
    }

    private void PreviousImage()
    {
        if (SelectedProject is null || SelectedProject.Images.Count == 0)
        {
            return;
        }

        ActiveImageIndex = ActiveImageIndex == 0
            ? SelectedProject.Images.Count - 1
            : ActiveImageIndex - 1;
    }

    private void NextImage()
    {
        if (SelectedProject is null || SelectedProject.Images.Count == 0)
        {
            return;
        }

        ActiveImageIndex = ActiveImageIndex == SelectedProject.Images.Count - 1
            ? 0
            : ActiveImageIndex + 1;
    }

    private static string GetImageUrl(ProjectModel project, int imageIndex)
    {
        return project.Images.Count == 0
            ? string.Empty
            : NormalizeAssetPath(path: project.Images[index: imageIndex]);
    }

    private static string GetThumbnailUrl(ProjectModel project)
    {
        return project.Images.Count == 0
            ? string.Empty
            : NormalizeAssetPath(path: project.Images[index: 0]);
    }

    private static string NormalizeAssetPath(string path)
    {
        return path.TrimStart(trimChar: '.').TrimStart(trimChar: '/');
    }

    private string GetWebRootPath()
    {
        if (!string.IsNullOrWhiteSpace(value: Environment.WebRootPath))
        {
            return Environment.WebRootPath;
        }

        string contentRootWebRoot = Path.Combine(path1: Environment.ContentRootPath, path2: "wwwroot");
        if (Directory.Exists(path: contentRootWebRoot))
        {
            return contentRootWebRoot;
        }

        return Path.Combine(path1: Environment.ContentRootPath, path2: "Portifolio", path3: "wwwroot");
    }
}
