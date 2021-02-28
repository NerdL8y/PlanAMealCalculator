#pragma checksum "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c48b77e47699374ca60b3ad4d9a4df900de87e"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
using PMC.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
using PMC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
using PMC.DataModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/mealcomponentlist")]
    public partial class MealComponentList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, 
#nullable restore
#line 11 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
    SelectedMealService.MealID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n");
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, 
#nullable restore
#line 12 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
    componentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
 if (SelectedMealService.MealID > 0 && componentCount > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "grid-container");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "grid-item grid-item-1");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "span");
            __builder.AddAttribute(14, "style", "font-size:13px");
            __builder.AddMarkupContent(15, "<b>My Components</b> (");
            __builder.AddContent(16, 
#nullable restore
#line 18 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
                                                                componentCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, " each) ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 19 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
             foreach (var list in components)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "style", "padding-left:5px");
            __builder.AddContent(22, 
#nullable restore
#line 21 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
                                               list.CompName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 22 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 25 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MealComponentList.razor"
       


    [Inject]
    private RepoFactory repoFactory { get; set; }
    private int userID;

    private Component component = new Component();
    private List<MealComponent> mealComponents = new List<MealComponent>();
    protected string componentName { get; set; }
    protected int componentType { get; set; }
    protected List<ComponentType> compTypes = new List<ComponentType>();
    private List<Component> components = new List<Component>();
    private List<Component> appetizers = new List<Component>();
    //private int appcount = 0;
    private List<Component> entrees = new List<Component>();
    //private int entreecount = 0;
    private List<Component> desserts = new List<Component>();
    //private int dessertcount = 0;
    private int componentCount = 0;
    private Meal meal = new Meal();

    protected override async Task OnInitializedAsync()
    {
        userID = repoFactory.UserID;


    }


    protected async void GetRepoInformation()
    {
        //component info
        var mealRepo = repoFactory.Get<PMC.Data.MealRepo>();
        meal = mealRepo.GetMealByMealID(SelectedMealService.MealID);
        //components = meal.Components.ToList();
        //componentCount = components.Count();

        var repo = repoFactory.Get<PMC.Data.MealComponentRepo>();
        mealComponents = repo.GetMealComponentsByMealID(SelectedMealService.MealID).ToList();
        componentCount = mealComponents.Count();

        //appetizers = components.GetComponentAppetizersByUserID(userID).ToList();
        //entrees = componentRepo.GetComponentEntreesByUserID(userID).ToList();
        //desserts = componentRepo.GetComponentDessertsByUserID(userID).ToList();
        //appcount = appetizers.Count();
        //entreecount = entrees.Count();
        //dessertcount = desserts.Count();
        //componentType = 0;

        //component type info
        //var repo = repoFactory.Get<PMC.Data.ComponentTypeRepo>();
        //var repoList = repo.GetComponentTypes().ToList();
        //compTypes = repoList;
        StateHasChanged();

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedMealService SelectedMealService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedComponentService SelectedComponentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
