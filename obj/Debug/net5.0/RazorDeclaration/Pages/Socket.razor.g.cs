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
#line 59 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
       
    private HubConnection hubConnection;
    private List<Quote> messages = new List<Quote>();
    private List<Quote> quotes = new List<Quote>();

    //private static readonly string baseURI = "https://matchingtest.azurewebsites.net/api";
    private static readonly string baseURI = "http://localhost:7071/api";
    private string message = "";
    private string dynamicGroup = "";
    private string dynamicUserId = "";

    private bool isChat = true;
    private string toggleText = "Hide";

    private List<string> allAnswers = new List<string>();
    private List<string> comparedList = new List<string>();

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
#line 89 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
                                               
    }

    private void ToggleChat()
    {
        isChat = isChat ? false : true;
        toggleText = isChat ? "Hide" : "Show";
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
        hubConnection.On<Quote>(dynamicGroup, (message) => //PROBLEM = ENTRIES GET ADDED AS 1 NOT PER ANSWER, SHOULD DESERIALIZE THE STRING
        {
            messages.Add(message);//TODO: Replace later with a message model
            ParseAnswer(message.body);
            //allAnswers.Add(message.body); //TODO: should be in seperate hub connection if I want to implement chat or have some differentiator headers/string b4 msg/idk
            if (allAnswers.Count == 20) //Replace with (amount * connected users in group) for user support
            {
                CalculateResults(); 
            }
            StateHasChanged();
        });

        await hubConnection.StartAsync();
        await client.PostAsJsonAsync<string>($"{baseURI}/{dynamicGroup}/add/{dynamicUserId}", dynamicGroup);
    }
    public void ParseAnswer(string messageBody) //Parse
    {
        List<string> answers = JsonSerializer.Deserialize<List<string>>(messageBody);
        foreach (var item in answers)
        {
            allAnswers.Add(item);
        }
    }

    public void CalculateResults()
    {
        for (int answerCount = 0; answerCount < (20 / 2); answerCount++) //Replace with (amount * connected users in group) for user support
        {
            int halfpoint = 20 / 2;
            //TODO: Use a dictionary with K/V = UserName/List<string>myAnswers
            CompareTwoAnswers(allAnswers[answerCount], allAnswers[halfpoint + answerCount]);
        }
    }

    public void CompareTwoAnswers(string userOne, string userTwo)
    {
        if (userOne == "yes" && userTwo == "yes")
        {
            comparedList.Add("yes");
        }
        else { comparedList.Add("no"); }
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