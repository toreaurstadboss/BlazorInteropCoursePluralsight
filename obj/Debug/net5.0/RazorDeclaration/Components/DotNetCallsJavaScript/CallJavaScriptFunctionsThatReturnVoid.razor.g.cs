// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BethanysPieShopHRM.ServerApp.Components.DotNetCallsJavaScript
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
    public partial class CallJavaScriptFunctionsThatReturnVoid : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnVoid.razor"
      


    private async Task ShowAlert()
    {
        await JSRunTime.InvokeVoidAsync("blazorInterop.showAlert", "Hello Blazor");
        // await JSRunTime.InvokeVoidAsync("alert", "Hello Blazor from window object");
    }

    private async Task PassDotNetObjectToJs()
    {
        await JSRunTime.InvokeVoidAsync("blazorInterop.logToConsoleTable", new Employee
            {
                FirstName = "thomas",
                LastName = "Huber"
            });
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRunTime { get; set; }
    }
}
#pragma warning restore 1591