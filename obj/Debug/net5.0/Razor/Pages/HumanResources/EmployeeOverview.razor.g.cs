#pragma checksum "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3468079a525b7274f35f72babe8c80899549ce75"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.ServerApp.Pages.HumanResources
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeoverview")]
    public partial class EmployeeOverview : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"page-title\">All employees</h1>");
#nullable restore
#line 5 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BethanysPieShopHRM.GridLibrary.BlazorAgGrid<Employee>>(2);
            __builder.AddAttribute(3, "AutoGenerateColumns", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnSelectionChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Employee>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Employee>(this, 
#nullable restore
#line 11 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
                                                                               GridSelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "RowData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<Employee>>(
#nullable restore
#line 11 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
                                                                                                               Employees

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 13 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
     if (SelectedEmployee != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-header");
#nullable restore
#line 17 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
__builder.AddContent(10, SelectedEmployee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, " ");
#nullable restore
#line 17 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
__builder.AddContent(12, SelectedEmployee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card-body");
            __builder.OpenElement(16, "a");
            __builder.AddAttribute(17, "class", "btn btn-alert-secondary");
            __builder.AddAttribute(18, "href", "employeeedit/" + (
#nullable restore
#line 20 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
                                                                       SelectedEmployee.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "class", "btn btn-alert-secondary");
            __builder.AddAttribute(23, "href", "employeeedit/" + (
#nullable restore
#line 21 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
                                                                       SelectedEmployee.EmployeeId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, "view");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table");
            __builder.AddMarkupContent(27, "<thead><tr><th>Employee ID</th>\n        <th>First name</th>\n        <th>Last name</th>\n        <th></th></tr></thead>\n    ");
            __builder.OpenElement(28, "tbody");
#nullable restore
#line 38 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
       foreach (var employee in Employees)
      {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "tr");
            __builder.OpenElement(30, "td");
#nullable restore
#line 41 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
__builder.AddContent(31, employee.EmployeeId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n          ");
            __builder.OpenElement(33, "td");
#nullable restore
#line 42 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
__builder.AddContent(34, employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n          ");
            __builder.OpenElement(36, "td");
#nullable restore
#line 43 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
__builder.AddContent(37, employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n          ");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "href", 
#nullable restore
#line 45 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
                       $"employeedetail/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(42, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(43, "<i class=\"fas fa-info-circle\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n            ");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "href", 
#nullable restore
#line 48 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
                       $"employeeedit/{employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "class", "btn btn-primary table-btn");
            __builder.AddMarkupContent(48, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\src\Blazor-Interop\javascript-interop-blazor-applications\02\demos\before\BethanysPieShopHRM.ServerApp\Pages\HumanResources\EmployeeOverview.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
