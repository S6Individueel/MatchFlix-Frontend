#pragma checksum "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aabc3872f4500343f091b35b6db1cd7988283da8"
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
#line 2 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/test")]
    public partial class Test : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "swipingContentPage");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "swipe-icons");
            __builder.AddAttribute(4, "style", "font-size:" + " " + (
#nullable restore
#line 10 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                        iconSize

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 11 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                 if (isRight)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "style", "opacity:" + " " + (
#nullable restore
#line 13 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                       iconOpacity

#line default
#line hidden
#nullable disable
            ) + ";" + " transition:" + (
#nullable restore
#line 13 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                  iconOpacityReset

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<AntDesign.Icon>(7);
            __builder.AddAttribute(8, "Type", "heart");
            __builder.AddAttribute(9, "Theme", "fill");
            __builder.AddAttribute(10, "Id", "swipe-icon-heart");
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                }else
                { 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "style", "opacity:" + " " + (
#nullable restore
#line 16 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                       iconOpacity * -1

#line default
#line hidden
#nullable disable
            ) + ";" + " transition:" + (
#nullable restore
#line 16 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                       iconOpacityReset

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<AntDesign.Icon>(13);
            __builder.AddAttribute(14, "Type", "close");
            __builder.AddAttribute(15, "Theme", "outline");
            __builder.AddAttribute(16, "Id", "swipe-icon-close");
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "isSwiping");
            __builder.AddAttribute(20, "onmouseup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                           HandleMouseUp

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ontouchstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.TouchEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                        HandleTouchStart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(22, "onkeypress", 
#nullable restore
#line 20 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                                                                    true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "ontouchmove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.TouchEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                                                                                       HandleTouchMove

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ontouchend", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.TouchEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                         HandleTouchEnd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onmousedown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                     HandleMouseDown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onmousemove", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                                  HandleMouseMove

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "style", "overflow:hidden;");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "card-choice-icon");
            __builder.AddAttribute(30, "style", "display:flex;justify-content:center;");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card");
            __builder.AddAttribute(33, "style", "width:" + " 18rem;" + " margin:" + " 2em;" + " transform:" + " translateX(" + (
#nullable restore
#line 26 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                                           mvmt

#line default
#line hidden
#nullable disable
            ) + ")" + " rotate(" + (
#nullable restore
#line 26 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                                                         rotation

#line default
#line hidden
#nullable disable
            ) + ");transition:" + " " + (
#nullable restore
#line 26 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                                                                                mvmtReset

#line default
#line hidden
#nullable disable
            ) + ";" + " cursor:" + " " + (
#nullable restore
#line 26 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                                                                                                    cursorGrab

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddMarkupContent(34, "<img class=\"card-img-top\" src=\"https://via.placeholder.com/350x150\" alt=\"Card image cap\">\r\n\r\n\r\n                    ");
            __builder.AddMarkupContent(35, "<div class=\"card-body\"><h5 class=\"card-title\">Placeholder title</h5>\r\n                        <p class=\"card-text\">Placeholder description</p></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "swipe-controls");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "swipe-buttons");
            __builder.OpenComponent<AntDesign.Button>(41);
            __builder.AddAttribute(42, "Type", "primary");
            __builder.AddAttribute(43, "Shape", "circle");
            __builder.AddAttribute(44, "Icon", "close");
            __builder.AddAttribute(45, "Size", "large");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                                          () => ChooseLeft(dataSet[0].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "swipe-buttons");
            __builder.OpenComponent<AntDesign.Button>(50);
            __builder.AddAttribute(51, "Type", "primary");
            __builder.AddAttribute(52, "Shape", "circle");
            __builder.AddAttribute(53, "Icon", "heart");
            __builder.AddAttribute(54, "Size", "large");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
                                                                                          () => ChooseRight(dataSet[0].Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Pages\Test.razor"
           
        #region Swiping
        private List<ShowDTO> dataSet;
        private List<ShowDTO> swipedSet = new List<ShowDTO>();
        private int dataCount = 0;
        private readonly string baseApiUri = "https://localhost:5021";
        private string selectedData = "";

        string mvmt;
        string rotation;
        double iconOpacity;
        string iconSize;
        string iconOpacityReset= "";
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
                if (difference > 0){ isRight = true; }else{ isRight = false; }
                iconSize = Math.Abs(difference / 50) + "em";
                mvmt = difference + "px";
                rotation = (difference / 10) + "deg";
                iconOpacity = (difference) / opacityNormalizer ;
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
            }
        }

        void SearchAndAdd(int id, string answer)
        {
            foreach (ShowDTO show in dataSet)
            {
                if (show.Id == id)
                {
                    swipedSet.Add(show);
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


        public async Task LoadData(string dataURL, string _selectedData)
        {
            selectedData = _selectedData;
            dataCount = dataSet.Count;
        }

        #endregion
    

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
