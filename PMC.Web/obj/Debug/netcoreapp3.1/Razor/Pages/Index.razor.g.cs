#pragma checksum "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f160ab2b7f24a2e2e7d6f5e1012ccb1aeb989770"
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
#line 2 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
using PMC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
using PMC.Web.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
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
#line 13 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
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
            __builder.AddAttribute(12, "Title", "Getting Started");
            __builder.AddAttribute(13, "IsOpened", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 15 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
                                                       isOpened

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ModalBody", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddMarkupContent(16, "<div>If you have already registered, enter your Username and Password, then click Login to access your account.</div>\r\n                ");
                __builder2.AddMarkupContent(17, "<div>If you have not registered yet, click the <b>Register</b> button to get started.</div>\r\n                ");
                __builder2.AddMarkupContent(18, @"<div style=""padding-left:10px"">Yeah, about that, you must have an account to continue. However, no need to fret, your information will never be shared with, nor sold to, any third parties.  After all, this is a school project and not yet meant for the real world.</div>
            ");
            }
            ));
            __builder.AddAttribute(19, "ModalFooter", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 26 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
 if (invalidLogin.Length > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(24, "    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "style", "color:red; background:yellow; width:30%");
            __builder.AddContent(27, " ");
            __builder.AddContent(28, 
#nullable restore
#line 28 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
                                                           invalidLogin

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 29 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 31 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
 if (repoFactory == null || !repoFactory.HasSession || AppState.LoggedIn == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "    \r\n    ");
            __builder.AddMarkupContent(32, "<div style=\"font-size:30px; padding-bottom:30px\"><h2>Welcome to the Plan a Meal Calculator (PMC)</h2></div>\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "grid-quarter");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "grid-quarter-1");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.OpenElement(40, "img");
            __builder.AddAttribute(41, "src", 
#nullable restore
#line 37 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
                            lizpic

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "style", "height:300px; width:197px; border-radius:20px; ");
            __builder.AddAttribute(43, "alt", "Food");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.AddMarkupContent(45, "<div>© Photos by <a href=\"https://www.srphotosbyliz.com/\" target=\"_blank\">Elizabeth Henry</a></div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "grid-quarter-2");
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.AddMarkupContent(50, "<div style=\"font-size:18px;\"><b>Login</b></div>\r\n            ");
            __builder.AddMarkupContent(51, "<div>Username</div>\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "id", "txtUserName");
            __builder.AddAttribute(55, "style", "border-width: 0; background-color: rgb(233, 238, 252);");
            __builder.AddAttribute(56, "type", "text");
            __builder.AddAttribute(57, "maxlength", "50");
            __builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
                                                                                                                userName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userName = __value, userName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.AddMarkupContent(61, "<div>Password</div>\r\n            ");
            __builder.OpenElement(62, "div");
            __builder.OpenElement(63, "input");
            __builder.AddAttribute(64, "id", "txtPassword");
            __builder.AddAttribute(65, "style", "border-width: 0; background-color: rgb(233, 238, 252);");
            __builder.AddAttribute(66, "type", "password");
            __builder.AddAttribute(67, "maxlength", "50");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
                                                                                                                password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "<br>\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "style", "padding-left:50px");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "id", "btnLogin");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
                                                                          Authenticate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "value", "Login");
            __builder.AddAttribute(78, "autofocus", true);
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            <br>\r\n            ");
            __builder.AddMarkupContent(80, "<div>Haven\'t registered with PMC yet?<br>Click the <b>Register</b> button to register today.</div>\r\n            ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "style", "padding-left:50px");
            __builder.OpenElement(83, "input");
            __builder.AddAttribute(84, "id", "btnAddUser");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
                                                                             goToAddUserAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "type", "button");
            __builder.AddAttribute(87, "value", "Register");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        <div class=\"grid-quarter-3\"></div>\r\n        <div class=\"grid-quarter-4\"></div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n    <br>\r\n");
#nullable restore
#line 55 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\Index.razor"
      


    [Inject]
    private RepoFactory repoFactory { get; set; }

    protected string userName;
    protected string password;
    protected string authMessage;
    protected string passwordEntered;
    protected string invalidLogin = "";
    private int viewHelp;

    private string lizpic = "LizCake.jpg";

    static readonly HttpClient client = new HttpClient();



    //PMC1092-16 PMC1092-02 PMC1092-11 PMC1092-12 PMC1092-14 PMC1092-16 PMC1094-01
    public async void Authenticate()
    {
        AppState.LoggedIn = false;
        if (client.BaseAddress == null)
        {
            client.BaseAddress = new Uri(HomeURIService.homeUri);
        }

        var repo = repoFactory.Get<PMC.Data.SessionInfoRepo>();
        var results = repo.Authenticate(userName, password);

        if (results != null)
        {
            repoFactory.SessionId = results.SsID;
            repoFactory.UserID = results.UserID;
            HttpResponseMessage response = await client.GetAsync(HomeURIService.homeUri);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            AppState.LoggedIn = true;
            collectCounts();
            DisplayHelp();
        }

        //if (repoFactory.UserID == 0)
        if(results == null)
        {
            AppState.LoggedIn = false;
            invalidLogin = "Invalid Username or Password, please try again.";
            NavManager.NavigateTo(HomeURIService.homeUri + "/");
        }


    }

    protected bool isOpened = false;
    void OpenModal()
    {
        isOpened = true;

    }
    void CloseModal()
    {
        isOpened = false;
    }

    protected void DisplayHelp()
    {
        var repo = repoFactory.Get<PMC.Data.UserRepo>();
        var currUser = repo.GetUserByUserID(repoFactory.UserID);
        viewHelp = currUser.ShowHelpOnStartUp;
        if (viewHelp == 1)
        {
            isOpened = false;
            NavManager.NavigateTo(HomeURIService.homeUri + "help");
        }
        if (viewHelp == 0)
        {
            isOpened = false;
            NavManager.NavigateTo(HomeURIService.homeUri + "plannedmeals");
        }
    }

    private void collectCounts()
    {
        var crepo = repoFactory.Get<PMC.Data.ComponentRepo>();
        SelectedComponentService.ComponentCount = crepo.GetComponentsByUserID(repoFactory.UserID).Count();

        var mrepo = repoFactory.Get<PMC.Data.MealRepo>();
        SelectedMealService.MealCount = mrepo.GetMealsByUserID(repoFactory.UserID).Count();

        var rrepo = repoFactory.Get<PMC.Data.RecipeRepo>();
        SelectedRecipeService.RecipeCount = rrepo.GetRecipesByUserID(repoFactory.UserID).Count();
    }

    protected void goToAddUserAccount()
    {
        NavManager.NavigateTo(HomeURIService.homeUri + "adduseraccount");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppState AppState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HomeURIService HomeURIService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedComponentService SelectedComponentService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedMealService SelectedMealService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SelectedRecipeService SelectedRecipeService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
