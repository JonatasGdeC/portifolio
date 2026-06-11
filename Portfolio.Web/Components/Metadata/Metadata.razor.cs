using Microsoft.AspNetCore.Components;

namespace Portfolio.Web.Components.Metadata;

public partial class Metadata
{
  [Parameter] public List<string> ArticleTag { get; set; } = ["Desenvolvedor", "Full Stack", "Back-end", "Fron-end", "Júnior", "Pleno", ".NET", "Blazor", "C#", "Web", "MySQL", "SQL", "Azure", "API REST", "Docker", "CI/CD"];
  [Parameter] public string? Url { get; set; }
  [Parameter] public string? Description { get; set; } = "Sou desenvolvedor Full Stack com foco em .NET e Blazor, atuando na construção de aplicações web completas.";
  [Parameter] public string? OgTitle { get; set; } = "Olá! Meu nome é Jônatas. Em que posso te ajudar?";
  [Parameter] public string Image { get; set; } = "https://jonatasgdec-portifolio.vercel.app/media/profile.webp";
  [Parameter] public string ImageAlt { get; set; } = "Desenvolvedor Full Stack .NET e Blazor";

  string CanonicalUrl => $"https://jonatasgdec-portifolio.vercel.app{(!string.IsNullOrEmpty(value: Url) ? Url : "")}";
}
