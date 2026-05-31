namespace Portifolio.Web.Layout.MainLayout;

public partial class MainLayout
{
    private string ThemeClass => UiState.Theme == SiteTheme.Light ? "theme-light" : "theme-dark";

    protected override void OnInitialized()
    {
        UiState.Changed += HandleUiChanged;
    }

    private void HandleUiChanged()
    {
        InvokeAsync(workItem: StateHasChanged);
    }

    public void Dispose()
    {
        UiState.Changed -= HandleUiChanged;
    }
}