using System.Globalization;

namespace Portifolio.Components.Layout;

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

    public CultureInfo CurrentCulture => CultureInfo.CurrentUICulture;

    public void SetTheme(SiteTheme theme)
    {
        if (Theme == theme)
        {
            return;
        }

        Theme = theme;
        Changed?.Invoke();
    }

    public void SetLanguage(SiteLanguage language)
    {
        ApplyCulture(culture: ToCulture(language: language));

        Changed?.Invoke();
    }

    public static CultureInfo ToCulture(SiteLanguage language) => language switch
    {
        SiteLanguage.Pt => new CultureInfo(name: "pt"),
        SiteLanguage.Es => new CultureInfo(name: "es"),
        _ => new CultureInfo(name: "en")
    };

    private static SiteLanguage FromCulture(CultureInfo culture) => culture.TwoLetterISOLanguageName switch
    {
        "pt" => SiteLanguage.Pt,
        "es" => SiteLanguage.Es,
        _ => SiteLanguage.En
    };

    private static void ApplyCulture(CultureInfo culture)
    {
        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentUICulture = culture;
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;
    }
}
