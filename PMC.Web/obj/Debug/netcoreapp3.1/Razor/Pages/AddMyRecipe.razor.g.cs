#pragma checksum "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1aa544dae5604eecd5a0ed90cdbb09e1132f8c6"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "align", "right");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "style", " font-size:14px; background-color:white; border-width:0px; border-color:white");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
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
#line 15 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                                                   isOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ModalBody", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddMarkupContent(16, "<div>Recipes are the building blocks of every meal. Once a recipe has been created, it can be used over and over.</div>\r\n                ");
                __builder2.AddMarkupContent(17, "<div style=\"padding-bottom:0px\">Below, add a <b>Recipe Name</b>, the number of <b>Servings</b>, then select a <b>Cook Method</b>.</div>\r\n                ");
                __builder2.AddMarkupContent(18, "<div style=\"padding-top:0px\">Provided everything is correct, click the <b>Add Recipe</b> button.</div>\r\n                ");
                __builder2.AddMarkupContent(19, "<div>The <b>Add Ingredients</b> area will now appear.</div>\r\n                ");
                __builder2.AddMarkupContent(20, "<div>To view the meaning of each <em>Cook Method</em>, select <b>Definitions</b> in the navigation area.</div>\r\n            ");
            }
            ));
            __builder.AddAttribute(21, "ModalFooter", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
 if (userID == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.AddMarkupContent(27, "<p>You must log into your account before adding a recipe. </p>\r\n");
#nullable restore
#line 33 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
 if (userID > 0 && SelectedRecipeService.RecipeID == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "    \r\n");
            __builder.AddContent(29, "    ");
            __builder.OpenElement(30, "table");
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "id", "txtRecipeName");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "style", "width:700px; height:30px");
            __builder.AddAttribute(39, "onclick", "this.setSelectionRange(0, this.value.length)");
            __builder.AddAttribute(40, "maxlength", "99");
            __builder.AddAttribute(41, "autofocus", true);
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                                                  RecipeName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => RecipeName = __value, RecipeName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.OpenElement(47, "table");
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "tr");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "width", "25%");
            __builder.AddMarkupContent(53, "\r\n                # Servings:\r\n                ");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "id", "numRecipeServings");
            __builder.AddAttribute(56, "type", "number");
            __builder.AddAttribute(57, "min", "1");
            __builder.AddAttribute(58, "style", "width:50px; height:30px");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                                                      RecipeServings

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => RecipeServings = __value, RecipeServings, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "width", "85%");
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "select");
            __builder.AddAttribute(67, "name", "cookmethods");
            __builder.AddAttribute(68, "id", "cookmethodid");
            __builder.AddAttribute(69, "style", "width:300px; height:30px");
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 50 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                                                                     selectedCookMethod

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedCookMethod = __value, selectedCookMethod));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "option");
            __builder.AddAttribute(74, "value", "0");
            __builder.AddContent(75, "Select a Cook Method");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 52 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                     foreach (var list in cookmethod)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(77, "                        ");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "value", 
#nullable restore
#line 54 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                                        list.CookMethodID

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(80, "style", "height:0px");
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                                             () => { selectedCookMethod = list.CookMethodID; }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(82, 
#nullable restore
#line 56 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                                  list.CookMthdDesc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n");
#nullable restore
#line 57 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(84, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.OpenElement(88, "tr");
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "td");
            __builder.AddMarkupContent(91, "\r\n");
#nullable restore
#line 63 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                 if (RecipeName != null && selectedCookMethod != 0 && SelectedRecipeService.RecipeID == 0)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(92, "                    ");
            __builder.OpenElement(93, "input");
            __builder.AddAttribute(94, "id", "btnAddRecipe");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                                                       AddRecipe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "type", "button");
            __builder.AddAttribute(97, "value", "Add Recipe");
            __builder.AddAttribute(98, "style", "height:30px");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 66 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n");
#nullable restore
#line 70 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(104, "\r\n");
#nullable restore
#line 72 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
 if (validRecipeName == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "    ");
            __builder.OpenElement(106, "p");
            __builder.AddContent(107, 
#nullable restore
#line 74 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
        errorMsg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 75 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\AddMyRecipe.razor"
}

#line default
#line hidden
#nullable disable
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
            NavManager.NavigateTo(HomeURIService.HomeUri + "myrecipe");
        }
        else
        {
            errorMsg = "A recipe with this name already exists.  Please try a new name or use the navigation area to view your Recipe List.";
        }
        isOpened = false;
        //selectedCookMethod = 0;
        StateHasChanged();
        //NavManager.NavigateTo(HomeURIService.HomeUri + "myrecipe");
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
        NavManager.NavigateTo(HomeURIService.HomeUri + "myrecipelist");
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
