// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PMC.Web.Pages
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
#line 2 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\PlannedMeals.razor"
using PMC.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\PlannedMeals.razor"
using PMC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\PlannedMeals.razor"
using PMC.DataModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/plannedmeals")]
    public partial class PlannedMeals : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\PlannedMeals.razor"
       

    [Inject]
    private RepoFactory repoFactory { get; set; }

    private List<Meal> plannedMealList = new List<Meal>();
    private int userID;
    private int mealID;
    protected int MealID { get { return mealID; } set { mealID = value; SelectedMealService.MealID = value; } }
    //private int mealCount;
    //private string tempMealDate = "";
    //private string tempStartDate = "";

    //PMC1052-01 PMC1052-05 PMC1055-01 PMC1055-02 PMC1092-17
    protected override async Task OnInitializedAsync()
    {

        userID = repoFactory.UserID;

        var repo = repoFactory.Get<PMC.Data.MealRepo>();
        var meals = repo.GetPlannedMealsByUserID(userID).ToList();
        plannedMealList = meals.ToList();
        SelectedMealService.MealCount = plannedMealList.Count();
    }

    protected void setMealID(int id)
    {
        SelectedMealService.MealID = id;
        StateHasChanged();
        isOpened = false;
    }

    protected void mealSelect(ChangeEventArgs e)
    {
        isOpened = false;
        NavManager.NavigateTo(HomeURIService.HomeUri + "mymeal");
        StateHasChanged();
    }

    bool isOpened = false;
    void OpenModal()
    {
        isOpened = true;

    }
    void CloseModal()
    {
        isOpened = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedMealService SelectedMealService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HomeURIService HomeURIService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
