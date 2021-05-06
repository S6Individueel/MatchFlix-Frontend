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
#nullable restore
#line 2 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/socket")]
    public partial class Socket : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
       
    private HubConnection hubConnection;
    private List<Quote> messages = new List<Quote>();
    private List<Quote> quotes = new List<Quote>();
    private string message = "";
    private string dynamicGroup = "";
    private string dynamicUserId = "";

    //private static readonly string baseURI = "https://matchingtest.azurewebsites.net/api";
    private static readonly string baseURI = "http://localhost:7071/api";

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri($"{baseURI}"), options =>
            {
                options.Headers.Add("x-ms-signalr-userid", $"{dynamicUserId}");
            })
            .Build();

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
                                           
    }

    public async Task Send() =>
        await hubConnection.SendAsync("SendMessageToGroup", message, dynamicGroup);
    //await client.GetFromJsonAsync<string>($"{baseURI}/SendQuote");

    public async Task SendToGroup() =>
    //await client.PostAsJsonAsync<string>($"{baseURI}/{dynamicGroup}/send", "{'message': '" + message + "'}");
    await client.PostAsJsonAsync<string>($"{baseURI}/{dynamicGroup}/send", JsonSerializer.Serialize(message));

    public async Task SendAnswers(List<string> answers) =>
    //await client.PostAsJsonAsync<string>($"{baseURI}/{dynamicGroup}/send", "{'message': '" + message + "'}");
    await client.PostAsJsonAsync<string>($"{baseURI}/{dynamicGroup}/send", JsonSerializer.Serialize(answers));

    public async Task AddToGroup()
    {
        hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri($"{baseURI}"), options =>
        {
            options.Headers.Add("x-ms-signalr-userid", $"{dynamicUserId}");
        })
        .Build();
        hubConnection.On<Quote>("incomingQuote", (IncomingQuote) =>
        {
            quotes.Add(IncomingQuote);
            StateHasChanged();
        });
        hubConnection.On<Quote>(dynamicGroup, (message) =>
        {
            messages.Add(message);//Replace later with a message model
            StateHasChanged();
        });

        await hubConnection.StartAsync();
        await client.PostAsJsonAsync<string>($"{baseURI}/{dynamicGroup}/add/{dynamicUserId}", dynamicGroup);
    }

    public bool IsConnected =>
    hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }
    public class Quote
    {
        public string author { get; set; }
        public string body { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
