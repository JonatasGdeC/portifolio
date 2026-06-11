namespace Portfolio.Web.Pages.Home.Components.About;

public partial class About
{
    private readonly List<string> _frontEndSkills =
    [
        "Blazor", "HTML", "CSS", "JavaScript", "UX/UI",
        "Figma", "Lighthouse", "SEO"
    ];

    private readonly List<string> _backendSkills =
    [
        "C#", ".NET", "EF Core", "XUnit", "JWT", "MySql", 
        "SQL", "Azure", "API REST", "Docker", "CI/CD"
    ];

    private readonly List<string> _otherSkills =
    [
        "Git", "Trello", "SOLID", "DDD", "DRY"
    ];
}