#pragma checksum "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\Developers\DotNetCallsJavaScript.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "642d628feff686abd362a6f73bb54abe750e4b01"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.ServerApp.Pages.Developers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp.Services.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp.Services.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp.Services.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.ServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.OnlineCheckLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\_Imports.razor"
using BethanysPieShopHRM.GridLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\Developers\DotNetCallsJavaScript.razor"
using BethanysPieShopHRM.ServerApp.Components.DotNetCallsJavaScript;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dotnetcallsjavascript")]
    public partial class DotNetCallsJavaScript : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">.NET calls JavaScript</h1>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "interop-card");
            __builder.OpenComponent<BethanysPieShopHRM.ServerApp.Components.DotNetCallsJavaScript.CallJavaScriptFunctionsThatReturnVoid>(3);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "interop-card");
            __builder.OpenComponent<BethanysPieShopHRM.ServerApp.Components.DotNetCallsJavaScript.CallJavaScriptFunctionsThatReturnValue>(7);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "interop-card");
            __builder.OpenComponent<BethanysPieShopHRM.ServerApp.Components.DotNetCallsJavaScript.PassHTMLElementsToJavaScript>(11);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "interop-card");
            __builder.OpenComponent<BethanysPieShopHRM.ServerApp.Components.DotNetCallsJavaScript.HandleJavaScriptErrors>(15);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "interop-card");
            __builder.OpenComponent<BethanysPieShopHRM.ServerApp.Components.DotNetCallsJavaScript.UseJavascriptModule>(19);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
