#pragma checksum "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d3ee77106ed62fe2fba687b5d5f7bbf15ec5593"
// <auto-generated/>
#pragma warning disable 1591
namespace QuipClash.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zacha\source\repos\QuipClash\QuipClash\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zacha\source\repos\QuipClash\QuipClash\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zacha\source\repos\QuipClash\QuipClash\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zacha\source\repos\QuipClash\QuipClash\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zacha\source\repos\QuipClash\QuipClash\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zacha\source\repos\QuipClash\QuipClash\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zacha\source\repos\QuipClash\QuipClash\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zacha\source\repos\QuipClash\QuipClash\_Imports.razor"
using QuipClash;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zacha\source\repos\QuipClash\QuipClash\_Imports.razor"
using QuipClash.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
using QuipClash.Server.Hubs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n\t* {\r\n\t\tcolor: #2d232e;\r\n\t\tfont-size: 24px;\r\n\t\tfont-family: sans-serif;\r\n\t}\r\n\r\n\tbody {\r\n\t\tbackground-color: #30bced;\r\n\t}\r\n\r\n\tp {\r\n\t\tmargin: 0;\r\n\t}\r\n\r\n\t\tp.centered, h2.centered, h3.centered {\r\n\t\t\twidth: 100%;\r\n\t\t\ttext-align: center;\r\n\t\t}\r\n\r\n\t\tp.game-id-display {\r\n\t\t\tfont-weight: bold;\r\n\t\t}\r\n\r\n\t.element-container {\r\n\t\tmargin: 0;\r\n\t\tpadding: 0;\r\n\t\twidth: 100%;\r\n\t\theight: 100%;\r\n\t}\r\n\r\n\tdiv.centered {\r\n\t\theight: 100%;\r\n\t\tdisplay: flex;\r\n\t\tflex-direction: column;\r\n\t\talign-items: center;\r\n\t\tjustify-content: center;\r\n\t}\r\n\r\n\tform.center-content {\r\n\t\tdisplay: flex;\r\n\t\tflex-direction: column;\r\n\t\talign-content: center;\r\n\t}\r\n\r\n\t.lobby, .leaderboard {\r\n\t\tpadding: 18px;\r\n\t\twidth: 48vw;\r\n\t\theight: fit-content;\r\n\t\tborder: dashed;\r\n\t\tborder-color: #f7d43b;\r\n\t\tbackground-color: white;\r\n\t\tdisplay: flex;\r\n\t\tflex-direction: column;\r\n\t\talign-content: center;\r\n\t}\r\n\r\n\tul, ol {\r\n\t\tpadding: 14px;\r\n\t\tborder-radius: 4px;\r\n\t\tbackground-color: lightgray;\r\n\t\tlist-style: none;\r\n\t\toverflow: hidden;\r\n\t}\r\n\r\n\tol {\r\n\t\tlist-style: upper-roman;\r\n\t}\r\n\r\n\tinput[type=text] {\r\n\t\tmargin-bottom: 8px;\r\n\t\tbackground-color: white;\r\n\t\tborder: dashed;\r\n\t\tborder-color: #f7d53c;\r\n\t}\r\n\r\n\t\tinput[type=text]:scope {\r\n\t\t\tborder: dashed;\r\n\t\t\tborder-color: #f7d53c;\r\n\t\t}\r\n\r\n\tinput[type=button], button {\r\n\t\tpadding: 4px;\r\n\t\tborder-radius: 2px;\r\n\t\tborder-color: #f7d43b;\r\n\t\tfont-weight: bold;\r\n\t\tborder: none;\r\n\t\tbackground-color: #f7d43b;\r\n\t\tmargin-bottom: 5px;\r\n\t}\r\n\r\n\t\tinput[type=button]:disabled, button:disabled {\r\n\t\t\tborder-color: #c4a108;\r\n\t\t\tbackground-color: #c4a108;\r\n\t\t}\r\n\r\n\t\tbutton.cancel {\r\n\t\t\tmargin-right: 5px;\r\n\t\t\twidth: 50%;\r\n\t\t\tbackground-color: #e34543;\r\n\t\t}\r\n\r\n\th1 {\r\n\t\tmargin: 0;\r\n\t\tfont-family: \'Fredoka One\';\r\n\t\tfont-size: 128px;\r\n\t\tcolor: #f7d53c;\r\n\t\t-webkit-text-stroke-width: 2px;\r\n\t\t-webkit-text-stroke-color: black;\r\n\t}\r\n\r\n\th2 {\r\n\t\tmargin: 0;\r\n\t\tfont-family: \'Fredoka One\';\r\n\t\tfont-size: 56px;\r\n\t\tcolor: #f7d53c;\r\n\t\t-webkit-text-stroke-width: 2px;\r\n\t\t-webkit-text-stroke-color: black;\r\n\t}\r\n\r\n\th3 {\r\n\t\tfont-size: 24px;\r\n\t\tfont-weight: bold;\r\n\t}\r\n\r\n\t.title-underline {\r\n\t\tmargin-top: -16px;\r\n\t\twidth: 713px;\r\n\t\theight: 17px;\r\n\t\tborder-radius: 7px;\r\n\t\tborder-width: 7px;\r\n\t\tbackground-color: #e34543;\r\n\t}\r\n\r\n\tdiv.align-content-horizontal {\r\n\t\tdisplay: flex;\r\n\t\tflex-direction: row;\r\n\t}\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "element-container");
            __builder.AddAttribute(3, "hidden", 
#nullable restore
#line 148 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                         currentPlayerState != PlayerInfo.PlayerState.Menu

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n\t");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "centered");
            __builder.AddMarkupContent(7, "\r\n\t\t");
            __builder.AddMarkupContent(8, "<h1 class=\"title\">QUIPCLASH</h1>\r\n\t\t<div class=\"title-underline\"></div>\r\n\t\t<br>\r\n\t\t");
            __builder.OpenElement(9, "form");
            __builder.AddMarkupContent(10, "\r\n\t\t\t");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "maxlength", "32");
            __builder.AddAttribute(14, "placeholder", "Username");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 154 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                  username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\t\t\t<br>\r\n\t\t\t");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "maxlength", "4");
            __builder.AddAttribute(21, "placeholder", "Game ID");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 156 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                gameIDInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => gameIDInput = __value, gameIDInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\t\t\t<br>\r\n\t\t\t");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "button");
            __builder.AddAttribute(27, "value", "Join game");
            __builder.AddAttribute(28, "disabled", 
#nullable restore
#line 158 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                               username == "" || !QuipClashHub.ActiveGames.ContainsKey(gameIDInput.ToLower())

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 158 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                                                                                          JoinGame

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\t\t\t");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "style", "float:right;");
            __builder.AddAttribute(33, "type", "button");
            __builder.AddAttribute(34, "value", "Create game");
            __builder.AddAttribute(35, "disabled", 
#nullable restore
#line 159 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                      username == ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 159 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                                                 CreateGame

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "element-container");
            __builder.AddAttribute(43, "hidden", 
#nullable restore
#line 163 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                         currentPlayerState != PlayerInfo.PlayerState.Lobby

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 164 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
     if (QuipClashHub.ActiveGames.Count > 0 && gameID != "" && QuipClashHub.ActiveGames.ContainsKey(gameID.ToLower()))
	{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "\t\t");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "centered");
            __builder.AddMarkupContent(48, "\r\n\t\t\t");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "lobby");
            __builder.AddMarkupContent(51, "\r\n\t\t\t\t");
            __builder.AddMarkupContent(52, "<h2 style=\"color: #e34543;\" class=\"centered\">Lobby</h2>\r\n\t\t\t\t");
            __builder.OpenElement(53, "p");
            __builder.AddAttribute(54, "class", "centered game-id-display");
            __builder.OpenElement(55, "b");
            __builder.AddContent(56, "Game ID: ");
            __builder.OpenElement(57, "span");
            __builder.AddAttribute(58, "style", "color: #e34543");
            __builder.AddContent(59, 
#nullable restore
#line 169 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                              gameID.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\t\t\t\t");
            __builder.OpenElement(61, "ul");
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 171 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                     foreach (PlayerInfo _info in QuipClashHub.ActiveGames[gameID].players.Values)
					{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(63, "\t\t\t\t\t\t");
            __builder.OpenComponent<QuipClash.Shared.PlayerListItem>(64);
            __builder.AddAttribute(65, "Username", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 173 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                   _info.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "MascottIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 173 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                  _info.mascottNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 174 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
					}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\t\t\t\t");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "align-content-horizontal");
            __builder.AddMarkupContent(72, "\r\n");
#nullable restore
#line 177 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                     if (isPartyLeader)
					{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "\t\t\t\t\t\t");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "class", "cancel");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 179 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                         LeaveGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(77, "Cancel game");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 180 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
					}
					else
					{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(79, "\t\t\t\t\t\t");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "class", "cancel");
            __builder.AddAttribute(82, "style", "float:right;");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 183 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                              LeaveGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, "Leave game");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 184 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
					}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(86, "\t\t\t\t\t");
            __builder.OpenElement(87, "button");
            __builder.AddAttribute(88, "style", "width: 50%; margin-left: 5px; ");
            __builder.AddAttribute(89, "hidden", 
#nullable restore
#line 185 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                             !isPartyLeader

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(90, "disabled", 
#nullable restore
#line 185 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                                          QuipClashHub.ActiveGames[gameID].players.Count < 3

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(91, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 185 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                                                                                                         StartGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(92, "Start game");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 189 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "element-container");
            __builder.AddAttribute(100, "hidden", 
#nullable restore
#line 191 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                         currentPlayerState == PlayerInfo.PlayerState.Lobby || currentPlayerState == PlayerInfo.PlayerState.Menu

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(101, "\r\n\t");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "centered");
            __builder.AddAttribute(104, "hidden", 
#nullable restore
#line 192 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                    currentPlayerState != PlayerInfo.PlayerState.Responding

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(105, "\r\n\t\t");
            __builder.OpenElement(106, "form");
            __builder.AddAttribute(107, "class", "center-content");
            __builder.AddAttribute(108, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 193 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                SendResponse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(109, "\r\n\t\t\t");
            __builder.OpenElement(110, "h2");
            __builder.AddContent(111, 
#nullable restore
#line 194 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                 currentPrompt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\t\t\t");
            __builder.OpenElement(113, "input");
            __builder.AddAttribute(114, "type", "text");
            __builder.AddAttribute(115, "maxlength", "64");
            __builder.AddAttribute(116, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 195 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                           responseInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => responseInput = __value, responseInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\t");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "centered");
            __builder.AddAttribute(123, "hidden", 
#nullable restore
#line 198 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                    currentPlayerState != PlayerInfo.PlayerState.Waiting

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(124, "\r\n\t\t");
            __builder.AddMarkupContent(125, "<h1>Please wait</h1>\r\n\t\t<div class=\"title-underline\"></div>\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n\t");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "centered");
            __builder.AddAttribute(129, "hidden", 
#nullable restore
#line 202 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                    currentPlayerState != PlayerInfo.PlayerState.Voting

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(130, "\r\n\t\t");
            __builder.OpenElement(131, "h2");
            __builder.AddContent(132, 
#nullable restore
#line 203 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
             currentPrompt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n");
#nullable restore
#line 204 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
         if (currentResponses != null)
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(134, "\t\t\t");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "align-content-horizontal");
            __builder.AddMarkupContent(137, "\r\n");
#nullable restore
#line 207 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                 foreach (ResponseInfo _response in currentResponses)
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(138, "\t\t\t\t\t");
            __builder.OpenComponent<QuipClash.Shared.ResponseVoteOption>(139);
            __builder.AddAttribute(140, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 209 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                    !isVoting

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 209 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                         async() => await SendVote(_response.optionNumber)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(142, "Votes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 209 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                                                                   _response.votes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(144, 
#nullable restore
#line 209 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                                                                                     _response.response

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(145, "\r\n");
#nullable restore
#line 210 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
				}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(146, "\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n");
#nullable restore
#line 212 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
		}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(148, "\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n\t");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "class", "centered");
            __builder.AddAttribute(152, "hidden", 
#nullable restore
#line 214 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                    currentPlayerState != PlayerInfo.PlayerState.EndGame

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(153, "\r\n\t\t");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "leaderboard");
            __builder.AddMarkupContent(156, "\r\n\t\t\t");
            __builder.AddMarkupContent(157, "<h2 style=\"color: #e34543;\" class=\"centered\">Leaderboard</h2>\r\n");
#nullable restore
#line 217 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
             if (currentLeaderboard != null)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(158, "\t\t\t\t");
            __builder.OpenElement(159, "h3");
            __builder.AddAttribute(160, "class", "centered");
            __builder.AddContent(161, "You placed #");
            __builder.AddContent(162, 
#nullable restore
#line 219 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                  currentLeaderboard.IndexOf(currentLeaderboard.Find(p => p.username == username))

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n\t\t\t\t");
            __builder.OpenElement(164, "ol");
            __builder.AddMarkupContent(165, "\r\n");
#nullable restore
#line 221 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                     for (int i = 0; i < 3; i++)
					{
						var _info = currentLeaderboard[i];

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(166, "\t\t\t\t\t\t");
            __builder.OpenComponent<QuipClash.Shared.PlayerListItem>(167);
            __builder.AddAttribute(168, "Username", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 224 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                   _info.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(169, "MascottIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 224 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                  _info.mascottNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(170, "\r\n");
#nullable restore
#line 225 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
					}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(171, "\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n");
#nullable restore
#line 227 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
			}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(173, "\t\t\t");
            __builder.OpenElement(174, "button");
            __builder.AddAttribute(175, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 228 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                              () => UpdatePlayerState(PlayerInfo.PlayerState.Menu)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(176, "Return to menu");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 233 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
       
	//local variables
	string gameIDInput = "";
	string responseInput = "";

	readonly int mascottCount = 7;

	//game variables
	string gameID = "";
	string username = "";
	bool isPartyLeader = false;

	string currentPrompt;
	int currentDuelIndex;
	List<ResponseInfo> currentResponses;
	bool isVoting;
	List<PlayerInfo> currentLeaderboard;
	int currentPlacing;
	PlayerInfo.PlayerState currentPlayerState;

	HubConnection hubConnection;

	protected override async Task OnInitializedAsync()
	{
		//creates the hub connection
		hubConnection = new HubConnectionBuilder()
			.WithUrl(NavigationManager.ToAbsoluteUri($"/quipclashhub"))
			.Build();

		//adds handlers
		hubConnection.On<string>("CompleteCreateGame", async (g) => await CompleteCreateGame(g));
		hubConnection.On<string, List<ResponseInfo>, bool>("BeginVote", (p, r, i) => BeginVote(p, r, i));
		hubConnection.On<int>("UpdateVote", (v) => UpdateVote(v));
		hubConnection.On<string, int>("BeginRespond", (p, d) => BeginRespond(p, d));
		hubConnection.On<PlayerInfo.PlayerState>("UpdatePlayerState", (s) => UpdatePlayerState(s));
		hubConnection.On<List<PlayerInfo>>("GameEnded", (l) => GameEnded(l));
		hubConnection.On("UpdateUI", StateHasChanged);

		//initiates the connection
		await hubConnection.StartAsync();

		//brings you to the menu
		UpdatePlayerState(PlayerInfo.PlayerState.Menu);
	}

	// outbound logic //

	async Task JoinGame()
	{
		gameID = gameIDInput.ToLower();

		var random = new Random();
		await hubConnection.SendAsync("RegisterPlayer", gameID, username, random.Next(1, mascottCount));
	}

	async Task LeaveGame()
	{
		await hubConnection.SendAsync("RemovePlayer", gameID);
	}

	async Task CreateGame()
	{
		isPartyLeader = true;
		await hubConnection.SendAsync("CreateGame");
	}

	async Task StartGame()
	{
		await hubConnection.SendAsync("StartGame", gameID);
	}

	async Task SendResponse()
	{
		await hubConnection.SendAsync("SendResponse", gameID, responseInput, currentDuelIndex);

		UpdatePlayerState(PlayerInfo.PlayerState.Waiting);
	}

	async Task SendVote(int voteOption)
	{
		await hubConnection.SendAsync("SendVote", gameID, voteOption);

		isVoting = false;

		StateHasChanged();
	}

	public void Dispose()
	{
		hubConnection.DisposeAsync();
	}
	public async ValueTask DisposeAsync()
	{
		await hubConnection.DisposeAsync();
	}

	// inbound logic //

	public async Task CompleteCreateGame(string _gameID)
	{
		gameIDInput = _gameID;
		await JoinGame();
	}

	public void BeginRespond(string prompt, int duelIndex)
	{
		currentPrompt = prompt;
		currentDuelIndex = duelIndex;

		UpdatePlayerState(PlayerInfo.PlayerState.Responding);

		//do timer stuff here
	}

	public void BeginVote(string prompt, List<ResponseInfo> responses, bool isVoter)
	{
		currentPrompt = prompt;
		currentResponses = responses;
		isVoting = isVoter;

		//do timer stuff here
	}

	public void UpdateVote(int voteOption)
	{
		currentResponses[voteOption].votes++;

		StateHasChanged();
	}

	public void GameEnded(List<PlayerInfo> leaderboard)
	{
		currentLeaderboard = leaderboard;
	}

	public void UpdatePlayerState(PlayerInfo.PlayerState state)
	{
		currentPlayerState = state;

		StateHasChanged();
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
