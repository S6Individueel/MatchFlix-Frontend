#pragma checksum "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65ab018cb20b16150581132f621fbe914aa98ebf"
// <auto-generated/>
#pragma warning disable 1591
namespace MatchFlix_Frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using MatchFlix_Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using MatchFlix_Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<AntDesign.Button>(5);
            __builder.AddAttribute(6, "Type", "primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\Pages\Counter.razor"
                                 IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "click me!");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "background:#ECECEC; padding:30px");
            __builder.OpenComponent<AntDesign.Card>(13);
            __builder.AddAttribute(14, "Bordered", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\Pages\Counter.razor"
                    false

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, Microsoft.AspNetCore.Components.RenderFragment>>(
#nullable restore
#line 9 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\Pages\Counter.razor"
                                   "Card title"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "Style", "width: 300px");
            __builder.AddAttribute(17, "Body", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "<p>Card content</p>\r\n            ");
                __builder2.AddMarkupContent(19, "<p>Card loll</p>\r\n            ");
                __builder2.AddMarkupContent(20, "<p>Henlo</p>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\ander\Documents\SCHOOL\SEMESTER 6\INDIVIDUEEL\PROJECTS\MatchFlix-Frontend\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
