#pragma checksum "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f218129dd120f897fb2f3645aefe421d6f343d"
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
#line 2 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
using PMC.Web.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
using PMC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
using PMC.DataModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/myprofile")]
    public partial class MyProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
 if (userID == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Please Login</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 13 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
 if (userID != 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "h4");
            __builder.OpenElement(5, "b");
            __builder.AddContent(6, 
#nullable restore
#line 15 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
            currentUserName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, " User Profile");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "grid-container");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "grid-item grid-item-1");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "style", "font-size:16px; ");
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.AddMarkupContent(18, "<tr>\r\n                    <th></th>\r\n                    <th></th>\r\n                </tr>\r\n                ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.AddMarkupContent(21, "<td align=\"right\" style=\"border: solid; border-width: .5px; border-color: #ddd\"><b>Username:</b></td>\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddAttribute(23, "style", "padding-left:5px; border:solid; border-width:.5px; border-color:#ddd ");
            __builder.AddContent(24, 
#nullable restore
#line 25 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
                                                                                                       user.UserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.AddMarkupContent(29, "<td align=\"right\" style=\"border: solid; border-width: .5px; border-color: #ddd\"><b>First:</b></td>\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "style", "padding-left:5px; border:solid; border-width:.5px; border-color:#ddd");
            __builder.AddContent(32, 
#nullable restore
#line 29 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
                                                                                                      user.UserFirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "tr");
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.AddMarkupContent(37, "<td align=\"right\" style=\"border: solid; border-width: .5px; border-color: #ddd\"><b>Last:</b></td>\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "style", "padding-left:5px; border:solid; border-width:.5px; border-color:#ddd");
            __builder.AddContent(40, 
#nullable restore
#line 33 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
                                                                                                      user.UserLastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "tr");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.AddMarkupContent(45, "<td align=\"right\" style=\"border: solid; border-width: .5px; border-color: #ddd\"><b>State:</b></td>\r\n                    ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "style", "text-transform:uppercase; padding-left:5px; font-size:14px; border:solid; border-width:.5px; border-color:#ddd");
            __builder.AddContent(48, 
#nullable restore
#line 37 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
                                                                                                                                                user.UserState

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "tr");
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.AddMarkupContent(53, "<td align=\"right\" style=\" border: solid; border-width: .5px; border-color: #ddd\"><b>Email:</b></td>\r\n                    ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "style", "padding-left:5px; border:solid; border-width:.5px; border-color:#ddd");
            __builder.AddAttribute(56, "class", "emailDisplay");
            __builder.AddContent(57, 
#nullable restore
#line 41 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
                                                                                                                           user.UserEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                ");
            __builder.OpenElement(60, "tr");
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.AddMarkupContent(62, "<td align=\"right\" style=\" border: solid; border-width: .5px; border-color: #ddd\"><b># in Family:</b></td>\r\n                    ");
            __builder.OpenElement(63, "td");
            __builder.AddAttribute(64, "style", "padding-left:5px; border:solid; border-width:.5px; border-color:#ddd");
            __builder.AddContent(65, 
#nullable restore
#line 45 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
                                                                                                      user.UserNumFamMembers

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                \r\n");
#nullable restore
#line 49 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
                 if (userHelp == 0) { 

#line default
#line hidden
#nullable disable
            __builder.AddContent(68, "                ");
            __builder.OpenElement(69, "tr");
            __builder.AddMarkupContent(70, "\r\n                    ");
            __builder.AddMarkupContent(71, "<td align=\"right\">Show Help on start up?</td>\r\n                    ");
            __builder.OpenElement(72, "td");
            __builder.AddAttribute(73, "style", "padding-left:5px");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "value", "Show Help");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
                                                                                                   helpOnStartUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "style", "border-width:0px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n");
#nullable restore
#line 54 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 59 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Debora\source\repos\PMC\PMC.Web\Pages\MyProfile.razor"
       

    [Inject]
    private RepoFactory repoFactory { get; set; }
    private UserAccount user = new UserAccount();
    private UserRepo userRepo;
    private int userID;
    private int userHelp;
    private string currentUserName;

    //PMC1092-38 
    protected override async Task OnInitializedAsync()
    {
        userID = repoFactory.UserID;

        if (userID != 0)
        {
            userRepo = repoFactory.Get<PMC.Data.UserRepo>();
            user = userRepo.GetUserByUserID(userID);
            userHelp = user.ShowHelpOnStartUp;
            currentUserName = user.UserName + "'s";
        }
    }

    protected void helpOnStartUp()
    {
        userRepo.SetUserShowHelpOnStartUp(userID);
        NavManager.NavigateTo(HomeURIService.HomeUri + "help");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HomeURIService HomeURIService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
