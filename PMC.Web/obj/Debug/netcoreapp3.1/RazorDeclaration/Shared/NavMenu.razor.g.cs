// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PMC.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Debora\source\repos\PMC\PMC.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Debora\source\repos\PMC\PMC.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debora\source\repos\PMC\PMC.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Debora\source\repos\PMC\PMC.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Debora\source\repos\PMC\PMC.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Debora\source\repos\PMC\PMC.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Debora\source\repos\PMC\PMC.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Debora\source\repos\PMC\PMC.Web\_Imports.razor"
using PMC.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Debora\source\repos\PMC\PMC.Web\_Imports.razor"
using PMC.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Debora\source\repos\PMC\PMC.Web\Shared\NavMenu.razor"
using PMC.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Debora\source\repos\PMC\PMC.Web\Shared\NavMenu.razor"
using PMC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debora\source\repos\PMC\PMC.Web\Shared\NavMenu.razor"
using PMC.DataModel;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 136 "C:\Users\Debora\source\repos\PMC\PMC.Web\Shared\NavMenu.razor"
       

    [Inject]
    private RepoFactory repoFactory { get; set; }
    private bool collapseNavMenu = true;
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;
    private string pmcImage = "PMC_Logo_trnsprnt.png";

    protected override async Task OnInitializedAsync()
    {
        AppState.OnChange += StateHasChanged;
        SelectedMealService.OnChange += StateHasChanged;
        SelectedRecipeService.OnChange += StateHasChanged;
        SelectedComponentService.OnChange += StateHasChanged;
    }

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    public void Dispose()
    {
        AppState.OnChange -= StateHasChanged;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedComponentService SelectedComponentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedRecipeService SelectedRecipeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedMealService SelectedMealService { get; set; }
    }
}
#pragma warning restore 1591
