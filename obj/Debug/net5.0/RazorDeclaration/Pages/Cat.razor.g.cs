// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MatchFlix_Frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using MatchFlix_Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using MatchFlix_Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using BlazorAnimate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using MatchFlix_Frontend.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/endtest")]
    public partial class Cat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Cat.razor"
      
    private List<ShowDTO> endList = new List<ShowDTO>();
    private ShowDTO chosenShow = new ShowDTO();
    private bool isHidden { get; set; }

    protected override async Task OnInitializedAsync()
    {
        endList = await client.GetFromJsonAsync<List<ShowDTO>>("https://localhost:5021/topmovie");
        endList[0].Yes_Count = 1; //yellow
        endList[0].No_Count = 1;

        endList[1].Yes_Count = 1; //red
        endList[1].No_Count = 2;

        endList[2].Yes_Count = 2; //green
        endList[2].No_Count = 0;

        chosenShow = endList[0];
    }

    public void ViewShow(string chosenTitle)
    {
        foreach (ShowDTO show in endList)
        {
            if (show.Title.Equals(chosenTitle))
            {
                chosenShow = show;
                StateHasChanged();
                return;
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
