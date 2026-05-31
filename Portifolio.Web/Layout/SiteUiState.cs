using System.Globalization;

namespace Portifolio.Web.Layout;

public enum SiteTheme
{
    Dark,
    Light
}

public enum SiteLanguage
{
    Pt,
    En,
    Es
}

public sealed class SiteUiState
{
    public SiteTheme Theme { get; private set; } = SiteTheme.Dark;
    public SiteLanguage Language => FromCulture(culture: CultureInfo.CurrentUICulture);

    public event Action? Changed;
    
    public void SetTheme(SiteTheme theme)
    {
        if (Theme == theme)
        {
            return;
        }

        Theme = theme;
        Changed?.Invoke();
    }
    

    private static SiteLanguage FromCulture(CultureInfo culture) => culture.TwoLetterISOLanguageName switch
    {
        "pt" => SiteLanguage.Pt,
        "es" => SiteLanguage.Es,
        _    => SiteLanguage.En
    };

}
