namespace Portifolio.Components.Pages.Home.Components.Work;

public partial class Work
{
    private Project? SelectedProject { get; set; }

    private int ActiveImageIndex { get; set; }

    private static readonly Project[] Projects =
    [
        new(
            Title: "Portfolio UI",
            Summary: "Blazor Server, CSS isolado e internacionalizacao",
            Category: "Web application",
            Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae justo sed arcu interdum porta. Duis facilisis, sem at efficitur gravida, ligula massa volutpat velit, vitae finibus lorem neque a neque.",
            Tools: ["Blazor", "C#", ".NET", "CSS", "Razor"],
            GithubUrl: "https://github.com/JonatasGdeC",
            LiveUrl: "https://jonatasgdec.github.io",
            ThumbnailClass: "thumbnail-left",
            Images:
            [
                new(Label: "Visao geral", CssClass: "image-dashboard"),
                new(Label: "Detalhes", CssClass: "image-detail"),
                new(Label: "Mobile", CssClass: "image-mobile")
            ]),
        new(
            Title: "Design System",
            Summary: "Componentes reutilizaveis, tokens visuais e layout responsivo",
            Category: "Frontend toolkit",
            Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur ac mi in lorem dignissim tempor. Praesent sed mauris id mi posuere faucibus non sed elit. Suspendisse potenti.",
            Tools: ["HTML", "CSS", "Razor", "Figma", "Git"],
            GithubUrl: "https://github.com/JonatasGdeC",
            LiveUrl: "https://jonatasgdec.github.io",
            ThumbnailClass: "thumbnail-right",
            Images:
            [
                new(Label: "Componentes", CssClass: "image-components"),
                new(Label: "Tokens", CssClass: "image-tokens"),
                new(Label: "Fluxo", CssClass: "image-flow")
            ]),
        new(
            Title: "Portfolio UI",
            Summary: "Blazor Server, CSS isolado e internacionalizacao",
            Category: "Web application",
            Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer vitae justo sed arcu interdum porta. Duis facilisis, sem at efficitur gravida, ligula massa volutpat velit, vitae finibus lorem neque a neque.",
            Tools: ["Blazor", "C#", ".NET", "CSS", "Razor"],
            GithubUrl: "https://github.com/JonatasGdeC",
            LiveUrl: "https://jonatasgdec.github.io",
            ThumbnailClass: "thumbnail-left",
            Images:
            [
                new(Label: "Visao geral", CssClass: "image-dashboard"),
                new(Label: "Detalhes", CssClass: "image-detail"),
                new(Label: "Mobile", CssClass: "image-mobile")
            ]),
        new(
            Title: "Design System",
            Summary: "Componentes reutilizaveis, tokens visuais e layout responsivo",
            Category: "Frontend toolkit",
            Description: "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur ac mi in lorem dignissim tempor. Praesent sed mauris id mi posuere faucibus non sed elit. Suspendisse potenti.",
            Tools: ["HTML", "CSS", "Razor", "Figma", "Git"],
            GithubUrl: "https://github.com/JonatasGdeC",
            LiveUrl: "https://jonatasgdec.github.io",
            ThumbnailClass: "thumbnail-right",
            Images:
            [
                new(Label: "Componentes", CssClass: "image-components"),
                new(Label: "Tokens", CssClass: "image-tokens"),
                new(Label: "Fluxo", CssClass: "image-flow")
            ])
    ];

    private void OpenProject(Project project)
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
        if (SelectedProject is null)
        {
            return;
        }

        ActiveImageIndex = ActiveImageIndex == 0
            ? SelectedProject.Images.Length - 1
            : ActiveImageIndex - 1;
    }

    private void NextImage()
    {
        if (SelectedProject is null)
        {
            return;
        }

        ActiveImageIndex = ActiveImageIndex == SelectedProject.Images.Length - 1
            ? 0
            : ActiveImageIndex + 1;
    }

    private sealed record Project(
        string Title,
        string Summary,
        string Category,
        string Description,
        string[] Tools,
        string GithubUrl,
        string LiveUrl,
        string ThumbnailClass,
        ProjectImage[] Images);

    private sealed record ProjectImage(string Label, string CssClass);
}
