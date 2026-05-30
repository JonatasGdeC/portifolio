using Microsoft.AspNetCore.Components;

namespace Portifolio.Web.Pages.Home.Components.Contact;

public partial class Contact
{
    [Inject] private IConfiguration Configuration { get; set; } = default!;
    
    private const string Web3FormsEndpoint = "https://api.web3forms.com/submit";

    private string AccessKey => Configuration[key: "WEB3FORMS_ACCESS_KEY"] ?? Configuration[key: "Web3Forms:AccessKey"] ?? string.Empty;

    private string SuccessRedirectUrl => $"{NavigationManager.BaseUri.TrimEnd(trimChar: '/')}?contact=success#contact";

    private bool IsMissingAccessKey =>
        string.IsNullOrWhiteSpace(value: AccessKey) ||
        AccessKey == "YOUR_WEB3FORMS_ACCESS_KEY";

    private bool HasError { get; set; }

    private string? StatusMessage { get; set; }

    protected override void OnInitialized()
    {
        if (IsMissingAccessKey)
        {
            HasError = true;
            StatusMessage = Localizer[name: "ContactMissingAccessKey"];
            return;
        }

        Uri currentUri = NavigationManager.ToAbsoluteUri(relativeUri: NavigationManager.Uri);
        if (currentUri.Query.Contains(value: "contact=success", comparisonType: StringComparison.OrdinalIgnoreCase))
        {
            HasError = false;
            StatusMessage = Localizer[name: "ContactSuccess"];
        }
    }

    private string StatusMessageClass => HasError
        ? "form-status form-status-error"
        : "form-status form-status-success";
}
