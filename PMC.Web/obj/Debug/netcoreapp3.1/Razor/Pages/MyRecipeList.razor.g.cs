#pragma checksum "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37c798fde05a640d3233ef913aaaa53d7ec967af"
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
#line 2 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor"
using PMC.DataModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor"
using PMC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor"
using PMC.Web.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/myrecipelist")]
    public partial class MyRecipeList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "align", "right");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "style", " font-size:14px; background-color:white; border-width:0px; border-color:white");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor"
                                                                                                             OpenModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Help");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "align", "left");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenComponent<PMC.Web.Pages.BlazorModal>(11);
            __builder.AddAttribute(12, "Title", "Recipe List");
            __builder.AddAttribute(13, "IsOpened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor"
                                                   isOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ModalBody", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n                From your ");
                __builder2.AddMarkupContent(16, "<b>Recipe List</b> you can either select a recipe from the list displayed on the left, <br>\r\n                or you may search for a recipe by keywords.  Up to four keywords can be used in the search box.\r\n            ");
            }
            ));
            __builder.AddAttribute(17, "ModalFooter", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.AddMarkupContent(22, "<h3>My Recipe List</h3>\r\n");
#nullable restore
#line 23 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor"
 if (SelectedRecipeService.RecipeCount == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "    ");
            __builder.AddMarkupContent(24, "<p>\r\n        We could not find any recipes. If you are new to PMC, select <b>Help</b> in the navigation area for instructions on how to create recipes\r\n        or select <b>Add a Recipe</b>.\r\n    </p>\r\n");
#nullable restore
#line 29 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor"
 if (SelectedRecipeService.RecipeCount != 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(25, "    ");
            __builder.OpenComponent<PMC.Web.Pages.RecipeListWithDetails>(26);
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 33 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<hr>");
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyRecipeList.razor"
       
    [Inject]
    private RepoFactory repoFactory { get; set; }
    private int userID;
    protected string contentArea;
    protected int recipeCount = 0;
    private List<Recipe> recipeList = new List<Recipe>();
    private Recipe recipe = new Recipe();
    private int displayWidth = 0;
    //TODO change string for search
    //private string recipeSearch = "Enter a recipe name here";
    private List<Recipe> filteredRecipes = new List<Recipe>();
    //private int recipeSearchCount = 0;
    //private string searchUnsuccessful = "";
    private bool viewAllRecipes = false;
    //private string selectedRecipeName = "";

#pragma warning disable 1998
    protected override async Task OnInitializedAsync()
    {
        userID = repoFactory.UserID;

        SelectedRecipeService.RecipeID = 0;
        var repo = repoFactory.Get<PMC.Data.RecipeRepo>();
        recipeList = repo.GetRecipesByUserID(userID).ToList();
        displayWidth = recipe.MaxRecipeNameSize;

    }
#pragma warning restore 1998

    /*
    // This can be used when a search function is added to the MyRecipe page 
    protected void SearchRecipes()
    {
        var repo = repoFactory.Get<PMC.Data.RecipeRepo>();
        var rcpList = repo.SearchRecipeNameByUserID(recipeSearch, userID).ToList();
        filteredRecipes = rcpList;
        recipeSearchCount = rcpList.Count();
        searchUnsuccessful = "";
        if (recipeSearchCount > 0)
        {
            recipeSearchCount += 3;
        }
        if (recipeSearchCount == 0)
        {
            searchUnsuccessful = "We could not find any recipe containing that word.";
        }
        StateHasChanged();
        isOpened = false;
    }
    */

    protected void MyRecipe(ChangeEventArgs e)
    {
        isOpened = false;
        NavManager.NavigateTo(HomeURIService.HomeUri + "myrecipe");
    }

    private void goToAddRecipe()
    {
        NavManager.NavigateTo(HomeURIService.HomeUri + "addmyrecipe");
    }

    private void expand()
    {
        if (viewAllRecipes == false)
        {
            viewAllRecipes = true;
            StateHasChanged();
        }

    }
    private void collapse()
    {
        if (viewAllRecipes == true)
        {
            viewAllRecipes = false;
            StateHasChanged();
        }

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedRecipeService SelectedRecipeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HomeURIService HomeURIService { get; set; }
    }
}
#pragma warning restore 1591
