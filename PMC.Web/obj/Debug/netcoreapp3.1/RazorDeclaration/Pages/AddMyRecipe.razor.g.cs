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
#line 2 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
using PMC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
using PMC.DataModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
using PMC.Web.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addmyrecipe")]
    public partial class AddMyRecipe : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
       

    [Inject]
    private RepoFactory repoFactory { get; set; }
    private int userID;

    private Recipe recipe = new Recipe();
    public string RecipeName = "Enter Recipe Name";
    public int RecipeServings = 1;
    public bool validRecipeName;
    public string errorMsg = "";

    private List<CookMethod> cookmethod = new List<CookMethod>();
    private List<Cookware> cookware = new List<Cookware>();
    private int selectedCookMethod = 0;
    private int selectedCookware = 1;
    private bool readyAddInstruction = false;
    private int cookMethodCount = 0;


    protected override async Task OnInitializedAsync()
    {
        userID = repoFactory.UserID;

        var cookmethodRepo = repoFactory.Get<PMC.Data.CookMethodRepo>();
        var cmList = cookmethodRepo.GetCookMethods().ToList();
        cookmethod = cmList;
        cookMethodCount = cookmethod.Count + 3;
        isOpened = false;
        SelectedRecipeService.RecipeID = 0;
        SelectedIngredientService.IngredientID = 0;

    }

    //PMC1032-01 PMC1034-01 PMC1092-03 
    public async void AddRecipe()
    {

        var repo = repoFactory.Get<PMC.Data.RecipeRepo>();
        CheckRecipeName();

        if (validRecipeName == true)
        {
            //var currentRecipe = repo.InsertRecipeByUserID(userID, RecipeName, RecipeServings, selectedCookMethod, selectedCookware);
            //recipe = currentRecipe;
            //SelectedRecipeService.RecipeID = currentRecipe.RecipeID;
            recipe = repo.InsertRecipeByUserID(userID, RecipeName, RecipeServings, selectedCookMethod, selectedCookware);
            SelectedRecipeService.RecipeID = recipe.RecipeID;
            SelectedRecipeService.OnChange += StateHasChanged;
            SelectedIngredientService.IngredientCount = 0;
            SelectedInstructionService.InstructionCount = 0;
            NavManager.NavigateTo(HomeURIService.homeUri + "myrecipe");
        }
        else
        {
            errorMsg = "A recipe with this name already exists.  Please try a new name or use the navigation area to view your Recipe List.";
        }
        isOpened = false;
        //selectedCookMethod = 0;
        StateHasChanged();
        //NavManager.NavigateTo(HomeURIService.homeUri + "myrecipe");
    }

    protected async void CheckRecipeName()
    {
        var repo = repoFactory.Get<PMC.Data.RecipeRepo>();
        var recipeName = repo.CheckRecipeNameByUserID(RecipeName, userID);
        if (recipeName.RecipeNameCount == 0)
        {
            validRecipeName = true;
        }
        if (recipeName.RecipeNameCount != 0)
        {
            validRecipeName = false;
        }
        isOpened = false;
        //selectedCookMethod = 0;
        StateHasChanged();
    }

    protected async void DisplayInstructionArea()
    {
        isOpened = false;
        readyAddInstruction = true;
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

    private void recipeComplete()
    {
        SelectedRecipeService.RecipeID = 0;
        NavManager.NavigateTo(HomeURIService.homeUri + "myrecipelist");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HomeURIService HomeURIService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedInstructionService SelectedInstructionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedIngredientService SelectedIngredientService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedRecipeService SelectedRecipeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
