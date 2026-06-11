using System.Net.Http.Json;
using Portfolio.Web.Models;

namespace Portfolio.Web.Pages.Home.Components.Work;

public partial class Work
{
    private List<ProjectModel> Projects { get; set; } = [];
    private ProjectModel? SelectedProject { get; set; }
    private int ActiveImageIndex { get; set; }
    private bool IsImageModalOpen { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Projects = await HttpClient.GetFromJsonAsync<List<ProjectModel>>(requestUri: "mock/projects.json") ?? [];
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
        IsImageModalOpen = false;
    }

    private void SetImage(int imageIndex)
    {
        ActiveImageIndex = imageIndex;
    }

    private void OpenImageModal()
    {
        if (SelectedProject is null || SelectedProject.Images.Count == 0)
        {
            return;
        }

        IsImageModalOpen = true;
    }

    private void CloseImageModal()
    {
        IsImageModalOpen = false;
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
}
