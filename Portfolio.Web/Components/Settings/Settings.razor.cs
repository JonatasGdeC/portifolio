using Microsoft.JSInterop;
using Portfolio.Web.Layout;

namespace Portfolio.Web.Components.Settings;

public partial class Settings
{
    private bool _isSettingsOpen;
    
    private string SettingsDrawerClass => _isSettingsOpen ? "settings-drawer open" : "settings-drawer";
    
    private string ThemeButtonClass(SiteTheme theme) => UiState.Theme == theme ? "setting-button active" : "setting-button";

    private string LanguageButtonClass(SiteLanguage language) => UiState.Language == language ? "setting-button active" : "setting-button";
    
    private void OpenSettings() => _isSettingsOpen = true;
    
    private void CloseSettings() => _isSettingsOpen = false;
    
    private async Task NavigateToCulture(string culture)
    {
        await JsRuntime.InvokeVoidAsync(identifier: "localStorage.setItem", args: ["culture", culture]);
        NavigationManager.NavigateTo(uri: NavigationManager.Uri, forceLoad: true);
    }
}
