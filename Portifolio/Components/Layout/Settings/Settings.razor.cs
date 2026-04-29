using Microsoft.AspNetCore.Components;

namespace Portifolio.Components.Layout.Settings;

public partial class Settings
{
    
    [CascadingParameter] public SiteUiState UiState { get; set; }
    
    private bool _isSettingsOpen;

    private string SettingsDrawerClass => _isSettingsOpen ? "settings-drawer open" : "settings-drawer";
    
    private string ThemeButtonClass(SiteTheme theme) =>
        UiState.Theme == theme ? "setting-button active" : "setting-button";

    private string LanguageButtonClass(SiteLanguage language) =>
        UiState.Language == language ? "setting-button active" : "setting-button";
    
    private void OpenSettings() => _isSettingsOpen = true;
    
    private void CloseSettings() => _isSettingsOpen = false;
    
    private void NavigateToCulture(string culture)
    {
        string uri = new Uri(uriString: NavigationManager.Uri).GetComponents(components: UriComponents.PathAndQuery, format: UriFormat.Unescaped);
        string cultureEscaped = Uri.EscapeDataString(stringToEscape: culture);
        string uriEscaped = Uri.EscapeDataString(stringToEscape: uri);
        NavigationManager.NavigateTo(uri: $"Culture/Set?culture={cultureEscaped}&redirectUri={uriEscaped}", forceLoad: true);
    }
}