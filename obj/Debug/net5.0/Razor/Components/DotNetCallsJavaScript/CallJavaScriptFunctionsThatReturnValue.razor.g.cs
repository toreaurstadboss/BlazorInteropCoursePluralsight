#pragma checksum "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db57faa7d91b5bae0e98f51217c0700ee3866840"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class CallJavaScriptFunctionsThatReturnValue : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Call JavaScript functions that return a value</h2>\n\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-secondary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
                                            ShowPrompt

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Show prompt");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.AddMarkupContent(6, "<label>Prompt result:</label>\n");
            __builder.OpenElement(7, "span");
#nullable restore
#line 7 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
__builder.AddContent(8, promptResult);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-secondary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
                                            CreateEmployee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Create employee");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
            __builder.AddMarkupContent(15, "<label>Created employee:</label>\n");
            __builder.OpenElement(16, "span");
#nullable restore
#line 11 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
__builder.AddContent(17, employee);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Components\DotNetCallsJavaScript\CallJavaScriptFunctionsThatReturnValue.razor"
      
    private string promptResult; 

    private Employee employee {get; set;}

    private async Task ShowPrompt()
    {
        var result = await JSRunTime.InvokeAsync<string>("blazorInterop.showPrompt", "What's your name", "");
        if (result != null)
        {
            promptResult = result; 
        }
    }

    private async Task<Employee> CreateEmployee()
    {
        employee = await JSRunTime.InvokeAsync<Employee>("blazorInterop.createEmployee", "Tore", "Boss");
        return employee;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRunTime { get; set; }
    }
}
#pragma warning restore 1591
