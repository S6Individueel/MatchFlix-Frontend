#pragma checksum "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7f606d8a229d02af384948814f1f7d916eedc3e"
// <auto-generated/>
#pragma warning disable 1591
namespace MatchFlix_Frontend.Components.LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
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
using MongoDB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\_Imports.razor"
using MongoDB.Driver.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
using MatchFlix_Frontend.Components.LoginComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
using MongoDB.Driver;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
using MongoDB.Bson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
using System.Security.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
using MatchFlix_Frontend.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    public partial class LoginComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 12 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
 if (isLoggingIn)
{

#line default
#line hidden
#nullable disable
            __Blazor.MatchFlix_Frontend.Components.LoginComponent.LoginComponent.TypeInference.CreateForm_0(__builder, 0, 1, 
#nullable restore
#line 14 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                  model

#line default
#line hidden
#nullable disable
            , 2, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                    OnFinishRegister

#line default
#line hidden
#nullable disable
            ), 3, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 16 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                          OnFinishFailedRegister

#line default
#line hidden
#nullable disable
            ), 4, 
#nullable restore
#line 17 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                        8

#line default
#line hidden
#nullable disable
            , 5, 
#nullable restore
#line 18 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                          16

#line default
#line hidden
#nullable disable
            , 6, (context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.FormItem>(7);
                __builder2.AddAttribute(8, "Label", "Username");
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.MatchFlix_Frontend.Components.LoginComponent.LoginComponent.TypeInference.CreateInput_1(__builder3, 10, 11, 
#nullable restore
#line 20 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                                 context.Username

#line default
#line hidden
#nullable disable
                    , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Username = __value, context.Username)), 13, () => context.Username);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenComponent<AntDesign.FormItem>(15);
                __builder2.AddAttribute(16, "Label", "Password");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.InputPassword>(18);
                    __builder3.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                                         context.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Password = __value, context.Password))));
                    __builder3.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => context.Password));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenComponent<AntDesign.FormItem>(23);
                __builder2.AddAttribute(24, "Label", "Email");
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.MatchFlix_Frontend.Components.LoginComponent.LoginComponent.TypeInference.CreateInput_2(__builder3, 26, 27, 
#nullable restore
#line 26 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                                 context.Email

#line default
#line hidden
#nullable disable
                    , 28, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Email = __value, context.Email)), 29, () => context.Email);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<AntDesign.FormItem>(31);
                __builder2.AddAttribute(32, "WrapperColOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 28 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                                    8

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "WrapperColSpan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 28 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                                                       16

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Button>(35);
                    __builder3.AddAttribute(36, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                           ButtonType.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "HtmlType", "submit");
                    __builder3.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(39, "\r\n                Submit\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(40, "\r\n        ");
                __builder2.OpenComponent<AntDesign.Button>(41);
                __builder2.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                          ToggleLoggingIn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(44, "Login");
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 35 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.MatchFlix_Frontend.Components.LoginComponent.LoginComponent.TypeInference.CreateForm_3(__builder, 45, 46, 
#nullable restore
#line 38 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                  loginModel

#line default
#line hidden
#nullable disable
            , 47, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 39 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                    OnFinish

#line default
#line hidden
#nullable disable
            ), 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 40 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                          OnFinishFailed

#line default
#line hidden
#nullable disable
            ), 49, 
#nullable restore
#line 41 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                        8

#line default
#line hidden
#nullable disable
            , 50, 
#nullable restore
#line 42 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                          16

#line default
#line hidden
#nullable disable
            , 51, (context) => (__builder2) => {
                __builder2.OpenComponent<AntDesign.FormItem>(52);
                __builder2.AddAttribute(53, "Label", "Username");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __Blazor.MatchFlix_Frontend.Components.LoginComponent.LoginComponent.TypeInference.CreateInput_4(__builder3, 55, 56, 
#nullable restore
#line 44 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                                 context.Username

#line default
#line hidden
#nullable disable
                    , 57, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Username = __value, context.Username)), 58, () => context.Username);
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n        ");
                __builder2.OpenComponent<AntDesign.FormItem>(60);
                __builder2.AddAttribute(61, "Label", "Password");
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.InputPassword>(63);
                    __builder3.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                                         context.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Password = __value, context.Password))));
                    __builder3.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => context.Password));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenComponent<AntDesign.FormItem>(68);
                __builder2.AddAttribute(69, "WrapperColOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 49 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                                    8

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "WrapperColSpan", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 49 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                                                       16

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Button>(72);
                    __builder3.AddAttribute(73, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                           ButtonType.Primary

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "HtmlType", "submit");
                    __builder3.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(76, "\r\n                Submit\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.OpenComponent<AntDesign.Button>(78);
                __builder2.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                          ToggleLoggingIn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(81, "Register");
                }
                ));
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 56 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
 if (isLoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(82, "div");
            __builder.OpenElement(83, "h1");
            __builder.AddContent(84, "Hi ");
            __builder.AddContent(85, 
#nullable restore
#line 60 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                thisUser.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(86, "!");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.OpenElement(88, "h1");
            __builder.AddContent(89, "Current Email: ");
            __builder.AddContent(90, 
#nullable restore
#line 61 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                            thisUser.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        ");
            __builder.OpenComponent<AntDesign.Button>(92);
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
                          ForgetMe

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(95, "Forget Me");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\ander\Desktop\frontend\MatchFlix-Frontend\Components\LoginComponent\LoginComponent.razor"
 
    public class Model
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }

    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }

    private bool isLoggingIn = false;
    private bool isLoggedIn = false;
    private Model model = new Model();
    private LoginModel loginModel = new LoginModel();
    private readonly string MongoServiceUri = "https://localhost:5941";
    private Dal dal = null;
    private User thisUser = new User();

    private async Task OnFinish(EditContext editContext)
    {
        thisUser = await GetUserAsync(loginModel.Username, loginModel.Password);
        Console.WriteLine($"Success:{JsonSerializer.Serialize(thisUser)}");

        if (this.thisUser.Pwd.Equals(loginModel.Password))
        {
            isLoggedIn = true;
        }
    }

    private void OnFinishFailed(EditContext editContext)
    {
        Console.WriteLine($"Failed:{JsonSerializer.Serialize(model)}");
    }

    private void OnFinishRegister(EditContext editContext)
    {
        CreateUser(model.Username, model.Password, model.Email);
        ToggleLoggingIn();
        model.Username = thisUser.Name;
        model.Password = thisUser.Pwd;
        Console.WriteLine($"Success:{JsonSerializer.Serialize(model)}");
    }

    private void OnFinishFailedRegister(EditContext editContext)
    {
        Console.WriteLine($"Failed:{JsonSerializer.Serialize(model)}");
    }

    private void ToggleLoggingIn()
    {
        if (isLoggingIn)
        {
            isLoggingIn = false;
        }
        else
        {
            isLoggingIn = true;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        dal = new Dal();
    }

    public async Task<User> CreateUser(string name, string password, string email)
    {
        User createdUser = await client.GetFromJsonAsync<User>($"{MongoServiceUri}/user/create?name={name}&password={password}&email={email}");
        thisUser = createdUser;
        return createdUser;
    }

    public async Task<User> GetUserAsync(string name, string password)
    {
        User foundUser = await client.GetFromJsonAsync<User>($"{MongoServiceUri}/user/getuser?name={name}&password={password}");
        thisUser = foundUser;
        Console.WriteLine("THISUSER: " + foundUser);
        if (foundUser.Pwd != null)
        {
            isLoggedIn = true;
            StateHasChanged();
        }
        return foundUser;
    }

    public async Task ForgetMe()
    {
        StringContent data = new StringContent(JsonSerializer.Serialize(thisUser), Encoding.UTF8, "application/json");
        await client.GetAsync($"{MongoServiceUri}/user/forgetme?name={loginModel.Username}&password={loginModel.Password}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
namespace __Blazor.MatchFlix_Frontend.Components.LoginComponent.LoginComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateForm_0<TModel>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TModel __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext> __arg2, int __seq3, global::OneOf.OneOf<global::System.String, global::System.Int32> __arg3, int __seq4, global::OneOf.OneOf<global::System.String, global::System.Int32> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<TModel> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Form<TModel>>(seq);
        __builder.AddAttribute(__seq0, "Model", __arg0);
        __builder.AddAttribute(__seq1, "OnFinish", __arg1);
        __builder.AddAttribute(__seq2, "OnFinishFailed", __arg2);
        __builder.AddAttribute(__seq3, "LabelColSpan", __arg3);
        __builder.AddAttribute(__seq4, "WrapperColSpan", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInput_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInput_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateForm_3<TModel>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TModel __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext> __arg2, int __seq3, global::OneOf.OneOf<global::System.String, global::System.Int32> __arg3, int __seq4, global::OneOf.OneOf<global::System.String, global::System.Int32> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<TModel> __arg5)
        {
        __builder.OpenComponent<global::AntDesign.Form<TModel>>(seq);
        __builder.AddAttribute(__seq0, "Model", __arg0);
        __builder.AddAttribute(__seq1, "OnFinish", __arg1);
        __builder.AddAttribute(__seq2, "OnFinishFailed", __arg2);
        __builder.AddAttribute(__seq3, "LabelColSpan", __arg3);
        __builder.AddAttribute(__seq4, "WrapperColSpan", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInput_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591