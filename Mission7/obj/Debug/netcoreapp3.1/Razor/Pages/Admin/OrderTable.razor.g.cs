#pragma checksum "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a86c428e19e483b8cb2a012064d17da7fd94677"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission7.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/_Imports.razor"
using Mission7.Models;

#line default
#line hidden
#nullable disable
    public partial class OrderTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenElement(7, "th");
            __builder.AddAttribute(8, "colspan", "5");
            __builder.AddAttribute(9, "class", "text-center");
            __builder.AddContent(10, 
#nullable restore
#line 4 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
                                                 TableTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n\n    ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\n");
#nullable restore
#line 9 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
         if (Orders?.Count() > 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
             foreach (Purchase o in Orders)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 14 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
                         o.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 15 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
                         o.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.AddMarkupContent(25, "<th>Books</th>\n                    ");
            __builder.AddMarkupContent(26, "<th>Quantity</th>\n\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
                                                                          x => OrderSelected.InvokeAsync(o.PurchaseId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "\n                            ");
            __builder.AddContent(33, 
#nullable restore
#line 21 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
                             ButtonLabel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n");
#nullable restore
#line 26 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
                 foreach (CartLineItem cli in o.Lines)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                    ");
            __builder.OpenElement(39, "tr");
            __builder.AddMarkupContent(40, "\n                        <td colspan=\"2\"></td>\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 30 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
                             cli.Books.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                        ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 31 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
                             cli.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n");
#nullable restore
#line 33 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "            ");
            __builder.AddMarkupContent(49, "<tr>\n                <td colspan=\"5\" class=\"text-center\">No Orders</td>\n            </tr>\n");
#nullable restore
#line 41 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Users/ashleydenison/Documents/GitHub/Mission10Take1/Mission7/Pages/Admin/OrderTable.razor"
       
    [Parameter]
    public string TableTitle { get; set; } = "Orders";

    [Parameter]
    public IEnumerable<Purchase> Orders { get; set; }

    [Parameter]
    public string ButtonLabel { get; set; } = "Shipped";

    [Parameter]
    public EventCallback<int> OrderSelected { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
