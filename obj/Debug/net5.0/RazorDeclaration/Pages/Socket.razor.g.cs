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
#line 14 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using Microsoft.Extensions.Configuration.Json;

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
#line 7 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
using MatchFlix_Frontend.Components.Chat;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/swiping")]
    public partial class Socket : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 236 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
       
    private ShowDTO chosenShow = new ShowDTO();
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
#nullable restore
#line 252 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
       
    string mvmt;
    string rotation;
    double iconOpacity;
    string iconSize;
    string iconOpacityReset = "";
    int opacityNormalizer = 200;

    double difference;
    bool isRight;
    string mvmtReset = "";
    string rotationReset = "";

    private bool animeCheck;
    private bool movieCheck;
    private string cursorGrab;
    ((double, double) tupleMouse, DateTime StartTime) mousePoint;
    bool pressedDown;

    void HandleMouseDown(MouseEventArgs m)
    {
        cursorGrab = "-webkit-grabbing;";
        pressedDown = true;
        (double, double) pos = (m.ClientX, m.ClientY);
        mousePoint.StartTime = DateTime.Now;
        mousePoint.tupleMouse = pos;
    }

    void HandleMouseMove(MouseEventArgs m)
    {
        if (pressedDown == true)
        {
            mvmtReset = "";
            iconOpacityReset = "";
            difference = m.ClientX - mousePoint.tupleMouse.Item1;
            if (difference > 0) { isRight = true; } else { isRight = false; }
            iconSize = Math.Abs(difference / 50) + "em";
            mvmt = difference + "px";
            rotation = (difference / 10) + "deg";
            iconOpacity = (difference) / opacityNormalizer;
        }
    }

    void HandleMouseUp(MouseEventArgs m)
    {
        difference = 0;
        pressedDown = false;
        cursorGrab = "";
        mvmt = "";
        iconOpacity = 0;
        mvmtReset = "transform 0.5s";
        iconOpacityReset = "opacity 0.5s ease-in-out";
        const double swipeThreshold = 0.8;
        try
        {
            if (mousePoint.Equals(default))
            {
                return;
            }


            var diffX = mousePoint.tupleMouse.Item1 - m.ClientX;
            var diffY = mousePoint.tupleMouse.Item2 - m.ClientY;
            var diffTime = DateTime.Now - mousePoint.StartTime;
            var velocityX = Math.Abs(diffX / diffTime.Milliseconds);
            var velocityY = Math.Abs(diffY / diffTime.Milliseconds);

            if (velocityX < swipeThreshold && velocityY < swipeThreshold) return;
            if (Math.Abs(velocityX - velocityY) < .5) return;

            if (velocityX >= swipeThreshold)
            {
                if (diffX < 0)
                { ChooseRight(dataSet[0].Id); }
                else { ChooseLeft(dataSet[0].Id); }
            }
        }

        catch (Exception e)
        {
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 338 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
       
    #region Swiping
    private List<ShowDTO> dataSet;
    private List<ShowDTO> swipedSet = new List<ShowDTO>();
    private int dataCount = 0;
    private readonly string baseApiUri = "https://localhost:5021";
    private string selectedData = "";


    (TouchPoint ReferencePoint, DateTime StartTime) startPoint;

    string swipingMessage = "touch to begin";

    void HandleTouchStart(TouchEventArgs t)
    {
        startPoint.ReferencePoint = t.TargetTouches[0];
        startPoint.StartTime = DateTime.Now;
        cursorGrab = "-webkit-grabbing;";
    }

    void HandleTouchMove(TouchEventArgs t) //A list of TouchPoint for every point of contact currently touching the surface.
    {
        mvmtReset = "";
        double difference = t.TargetTouches[0].ClientX - startPoint.ReferencePoint.ClientX;
        mvmt = difference + "px";
        rotation = (difference / 10) + "deg";
    }


    void HandleTouchEnd(TouchEventArgs t)
    {
        mvmt = "";
        mvmtReset = "transform 0.5s";
        cursorGrab = "";
        const double swipeThreshold = 0.8;
        try
        {
            if (startPoint.ReferencePoint == null)
            {
                return;
            }

            var endReferencePoint = t.ChangedTouches[0];

            var diffX = startPoint.ReferencePoint.ClientX - endReferencePoint.ClientX;
            var diffY = startPoint.ReferencePoint.ClientY - endReferencePoint.ClientY;
            var diffTime = DateTime.Now - startPoint.StartTime;
            var velocityX = Math.Abs(diffX / diffTime.Milliseconds);
            var velocityY = Math.Abs(diffY / diffTime.Milliseconds);

            if (velocityX < swipeThreshold && velocityY < swipeThreshold) return;
            if (Math.Abs(velocityX - velocityY) < .5) return;

            if (velocityX >= swipeThreshold)
            {
                if (diffX < 0)
                { ChooseRight(dataSet[0].Id); }
                else { ChooseLeft(dataSet[0].Id); }
            }
        }

        catch (Exception e)
        {
            message = e.Message;
        }
    }

    void SearchAndAdd(int id, string answer)
    {
        foreach (ShowDTO show in dataSet)
        {
            if (show.Id == id)
            {
                swipedSet.Add(show);
                myAnswers.Add(answer);
                dataSet.Remove(show);
                return;
            }
        }
    }

    void ChooseLeft(int id)
    {
        SearchAndAdd(id, "no");
    }

    void ChooseRight(int id)
    {
        SearchAndAdd(id, "yes");
    }

    void ShowAnswers()
    {
        message = JsonSerializer.Serialize(myAnswers);
    }
    public async Task LoadData(string dataURL, string _selectedData)
    {
        selectedData = _selectedData;
        dataSet = await client.GetFromJsonAsync<List<ShowDTO>>($"{baseApiUri}/{dataURL}");
        dataCount = dataSet.Count;
    }

    #endregion


    private HubConnection hubConnection;
    private List<ChatMessage> messages = new List<ChatMessage>();
    private List<MatchList> matches = new List<MatchList>();

    private static readonly string baseURI = "https://matchfunctionmatchflix.azurewebsites.net/api";
    //private static readonly string baseURI = "http://localhost:7071/api";
    private string message = "";
    private string dynamicGroup = "";
    private string dynamicUserId = "";

    private bool isDoneSwiping = false;
    private bool isChat = true;
    private bool isSwiping = false;
    private bool isHost = false;
    private bool isGuest = false;
    private bool isEndResult = false;
    private bool isPreLoadLobby = true;
    private bool isDoneMessage = true;
    private string toggleText = "Hide";

    private List<string> allAnswers = new List<string>();
    private List<string> comparedList = new List<string>();
    private List<string> myAnswers = new List<string>();
    private List<string> allUsers = new List<string>();

    private List<ShowDTO> endList = new List<ShowDTO>();

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri($"{baseURI}"))
            .Build();
    }

    void ToSwiping()
    {
        NavigationManager.NavigateTo("/");
        InvokeAsync(() =>
        {
            uriHelper.NavigateTo(uriHelper.Uri);

        });
    }

    async Task ToHome()
    {
        NavigationManager.NavigateTo("/");
        await InvokeAsync(async () =>
        {
            if (hubConnection.State.Equals(HubConnectionState.Connected))
            {await DisposeAsync();}
            uriHelper.NavigateTo(uriHelper.BaseUri);
        });
    }

    private void ToggleChat()
    {
        isChat = isChat ? false : true;
        toggleText = isChat ? "Hide" : "Show";
    }

    private async Task ToggleSwiping()
    {
        if (dataSet != null && allUsers.Count >= 2)
        {
            isSwiping = true;
            isPreLoadLobby = false;
            await client.PostAsJsonAsync<bool>($"{baseURI}/{dynamicGroup}/start/{selectedData}", isHost);
        }
    }

    public async Task SendAnswers(List<string> answers)
    {
        isDoneSwiping = true;
        isDoneMessage = false;
        isSwiping = false;
        await client.PostAsJsonAsync<string>($"{baseURI}/{dynamicGroup}/send/answers", JsonSerializer.Serialize(answers));
    }

    public async Task HostGroup()
    {
        var task = _message.Loading(CreateMessage("Connecting to server...", 0));
        isHost = true;
        await ListenerBuilder(isHost, false, true, true, true);
        await client.GetAsync($"{baseURI}/host/{dynamicUserId}");
        task.Start();
        await _message.Success("Successfully connected");
    }

    private MessageConfig CreateMessage(string content, int duration)
    {
        return new MessageConfig()
        {
            Content = content,
            Duration = duration
        };
    }

    public async Task JoinGroup()
    {
        var task = _message.Loading(CreateMessage($"Connecting to {dynamicGroup}...", 0));
        isGuest = true;
        await ListenerBuilder(isHost, true, true, true, true);
        await client.PostAsJsonAsync<string>($"{baseURI}/{dynamicGroup}/add/{dynamicUserId}", dynamicGroup);
        await client.PostAsJsonAsync<string>($"{baseURI}/{dynamicGroup}/updatehost", dynamicUserId);
        task.Start();
        await _message.Success("Successfully connected");
    }

    //TODO: Host should send a message containing the list of shows that will be swiped to every user when start button is clicked.
    public async Task ListenerBuilder(bool host, bool chat, bool answers, bool usersInfo, bool swipeData)
    {
        hubConnection = new HubConnectionBuilder()
        .WithUrl(NavigationManager.ToAbsoluteUri($"{baseURI}"), options =>
        {
            options.Headers.Add("x-ms-signalr-userid", $"{dynamicUserId}");
        })
        .Build();
        if (host) //Host has some special configurations regarding listeners since the host is the first one to join a room.
        {
            chat = false; //Makes sure to disable extra chat listener if forgotten in config.
            usersInfo = false;
            allUsers.Add(dynamicUserId);
            hubConnection.On<string>("incomingHost", (incomingHost) =>
            {
                dynamicGroup = incomingHost;
                hubConnection.On<ChatMessage>("incomingUserUpdate", async (message) =>
                {
                    messages.Add(message); //Make it special list message or somethgin color idk
                    allUsers.Add(message.UserName);
                    message.UsersList = allUsers;
                    message.ShowChoice = selectedData;//Doesn't allow for dynamic change of data.
                    StateHasChanged();
                    await client.PostAsJsonAsync<string>($"{baseURI}/{dynamicGroup}/updategroup", JsonSerializer.Serialize(message));
                });
                hubConnection.On<ChatMessage>(incomingHost, (message) =>
                {
                    messages.Add(message);
                    StateHasChanged();
                });

                StateHasChanged();
            });
        }
        if (chat)
        {
            hubConnection.On<ChatMessage>(dynamicGroup, (message) =>
            {
                messages.Add(message);
                StateHasChanged();
            });
        }
        if (answers)
        {
            hubConnection.On<MatchList>("incomingList", (incomingList) =>
            {
                matches.Add(incomingList);
                ParseAnswer(incomingList.MatchResults);
                if (allAnswers.Count == dataCount * allUsers.Count)
                {
                    CalculateResults();
                }
                StateHasChanged();
            });
        }
        if (usersInfo)
        {
            hubConnection.On<ChatMessage>("incomingUser", (message) =>
            {
                messages.Add(message); //Takes latest user and funny entrance, Make it special list message or somethgin color idk
                selectedData = message.ShowChoice;
                allUsers = message.UsersList; //latest user from server.
                StateHasChanged();
            });
        }
        if (swipeData)
        {
            hubConnection.On<string>("incomingData", async (message) =>
            {
                selectedData = message.ToString();
                if (selectedData == "Anime")
                {
                    await LoadData("topanime", selectedData);
                    dataCount = dataSet.Count;
                }
                else if (selectedData == "Movies")
                {
                    await LoadData("topmovie", selectedData);
                    dataCount = dataSet.Count;
                }
                isPreLoadLobby = false;
                isSwiping = true;
                StateHasChanged();
            });
        }

        await hubConnection.StartAsync();
    }

    public void ParseAnswer(string messageBody)
    {
        List<string> answers = JsonSerializer.Deserialize<List<string>>(messageBody);
        foreach (var item in answers)
        {
            allAnswers.Add(item);
        }
    }

    public void CalculateResults()
    {

        for (int answerCount = 0; answerCount < dataCount; answerCount++)
        {
            for (int NxtUsrIndex = 0; NxtUsrIndex < allAnswers.Count; NxtUsrIndex += dataCount) //For every user
            {
                if (allAnswers[answerCount + NxtUsrIndex] == "yes")
                {
                    swipedSet[answerCount].Yes_Count++;
                }
                else
                {
                    swipedSet[answerCount].No_Count++;
                }
            }
            endList.Add(swipedSet[answerCount]);
        }
        isSwiping = false;
        isDoneSwiping = true;
        isEndResult = true;
        try
        {chosenShow = endList[0];}
        catch(Exception ex) { Console.WriteLine(ex.Message); }
    }

    public bool IsConnected =>
    hubConnection.State == HubConnectionState.Connected;

    public async ValueTask DisposeAsync()
    {
        await hubConnection.DisposeAsync();
    }

    //Current users dropdown menu
    private RenderFragment _overlayMenu =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "Menu");
            __builder2.AddMarkupContent(1, "\r\n");
#nullable restore
#line 687 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
         foreach (var user in allUsers)
        {

#line default
#line hidden
#nullable disable
            __builder2.AddContent(2, "            ");
            __builder2.OpenElement(3, "MenuItem");
            __builder2.OpenElement(4, "a");
            __builder2.AddAttribute(5, "style", "color:#6D5AB3;");
            __builder2.AddContent(6, 
#nullable restore
#line 689 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
                                                 user.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
            __builder2.CloseElement();
            __builder2.AddMarkupContent(7, "\r\n");
#nullable restore
#line 690 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
        }

#line default
#line hidden
#nullable disable
            __builder2.AddContent(8, "    ");
            __builder2.CloseElement();
        }
#nullable restore
#line 691 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
           ;

private RenderFragment ButtonsRender(RenderFragment leftButton, RenderFragment rightButton)
{
 return 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(9, "Template");
            __builder2.AddMarkupContent(10, "\r\n    ");
            __builder2.OpenElement(11, "span");
            __builder2.AddContent(12, 
#nullable restore
#line 696 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
           leftButton

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
            __builder2.AddMarkupContent(13, "\r\n    ");
            __builder2.AddContent(14, 
#nullable restore
#line 697 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
     rightButton

#line default
#line hidden
#nullable disable
            );
            __builder2.AddMarkupContent(15, "\r\n");
            __builder2.CloseElement();
        }
#nullable restore
#line 698 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
           ;
}

private RenderFragment iconUser =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(16, "<Icon Type=\"user\"></Icon>");
        }
#nullable restore
#line 702 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
                     ;
private RenderFragment iconGroup =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(17, "<Icon Type=\"usergroup-add\"></Icon>");
        }
#nullable restore
#line 704 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Socket.razor"
                              ;

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MessageService _message { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
