#pragma checksum "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "236b39ebb175b6f1fcb07660b31a1b57d741f350"
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
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n\t* {\r\n\t\tcolor: #2d232e;\r\n\t\tfont-size: 24px;\r\n\t\tfont-family: sans-serif;\r\n\t}\r\n\tbody {\r\n\t\tbackground-color: #30bced;\r\n\t}\r\n\tp {\r\n\t\tmargin: 0;\r\n\t}\r\n\t\tp.centered, h2.centered, h3.centered {\r\n\t\t\twidth: 100%;\r\n\t\t\ttext-align: center;\r\n\t\t}\r\n\t\tp.game-id-display {\r\n\t\t\tfont-weight: bold;\r\n\t\t}\r\n\t.element-container {\r\n\t\tmargin: 0;\r\n\t\tpadding: 0;\r\n\t\twidth: 100%;\r\n\t\theight: 100%;\r\n\t}\r\n\tdiv.centered {\r\n\t\theight: 100%;\r\n\t\tdisplay: flex;\r\n\t\tflex-direction: column;\r\n\t\talign-items: center;\r\n\t\tjustify-content: center;\r\n\t}\r\n\tform.center-content {\r\n\t\tdisplay: flex;\r\n\t\tflex-direction: column;\r\n\t\talign-content: center;\r\n\t}\r\n\t.lobby, .leaderboard {\r\n\t\tpadding: 18px;\r\n\t\twidth: 48vw;\r\n\t\theight: fit-content;\r\n\t\tborder-radius: 4px;\r\n\t\tborder-color: white;\r\n\t\tbackground-color: white;\r\n\t\tdisplay: flex;\r\n\t\tflex-direction: column;\r\n\t\talign-content: center;\r\n\t}\r\n\tul, ol {\r\n\t\tpadding: 14px;\r\n\t\tborder-radius: 4px;\r\n\t\tborder-color: lightgray;\r\n\t\tbackground-color: lightgray;\r\n\t\tlist-style: none;\r\n\t\toverflow: hidden;\r\n\t}\r\n\t\tol {\r\n\t\t\tlist-style: upper-roman;\r\n\t\t}\r\n\tinput[type=text] {\r\n\t\tmargin-bottom: 8px;\r\n\t\tbackground-color: white;\r\n\t\tborder: dashed;\r\n\t\tborder-color: #f7d53c;\r\n\t}\r\n\t\tinput[type=text]:scope {\r\n\t\t\tborder: dashed;\r\n\t\t\tborder-color: #f7d53c;\r\n\t\t}\r\n\tinput[type=button], button {\r\n\t\tpadding: 4px;\r\n\t\tborder-radius: 2px;\r\n\t\tborder-color: #f7d43b;\r\n\t\tfont-weight: bold;\r\n\t\tborder: none;\r\n\t\tbackground-color: #f7d43b;\r\n\t}\r\n\t\tinput[type=button]:disabled, button:disabled {\r\n\t\t\tborder-color: #c4a108;\r\n\t\t\tbackground-color: #c4a108;\r\n\t\t}\r\n\th1 {\r\n\t\tmargin: 0;\r\n\t\tfont-family: \'Fredoka One\';\r\n\t\tfont-size: 128px;\r\n\t\tcolor: #f7d53c;\r\n\t\t-webkit-text-stroke-width: 2px;\r\n\t\t-webkit-text-stroke-color: black;\r\n\t}\r\n\th2 {\r\n\t\tmargin: 0;\r\n\t\tfont-family: \'Fredoka One\';\r\n\t\tfont-size: 56px;\r\n\t\tcolor: #f7d53c;\r\n\t\t-webkit-text-stroke-width: 2px;\r\n\t\t-webkit-text-stroke-color: black;\r\n\t}\r\n\th3 {\r\n\t\tfont-size: 24px;\r\n\t\tfont-weight: bold;\r\n\t}\r\n\t.title-underline {\r\n\t\tmargin-top: -12px;\r\n\t\twidth: 713px;\r\n\t\theight: 17px;\r\n\t\tborder-radius: 7px;\r\n\t\tborder-width: 7px;\r\n\t\tbackground-color: #e34543;\r\n\t}\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "element-container");
            __builder.AddAttribute(3, "hidden", 
#nullable restore
#line 118 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
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
#line 124 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
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
#line 126 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
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
#line 128 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                               username == "" || !QuipClashHub.ActiveGames.ContainsKey(gameIDInput.ToLower())

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 128 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
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
#line 129 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                      username == ""

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 129 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
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
#line 133 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                         currentPlayerState != PlayerInfo.PlayerState.Lobby

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 134 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
     if (QuipClashHub.ActiveGames.Count > 0 && gameID != "")
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
            __builder.OpenElement(52, "p");
            __builder.AddAttribute(53, "class", "centered game-id-display");
            __builder.OpenElement(54, "b");
            __builder.AddContent(55, "Game ID: ");
            __builder.OpenElement(56, "span");
            __builder.AddAttribute(57, "style", "color: #e34543");
            __builder.AddContent(58, 
#nullable restore
#line 138 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                              gameID.ToUpper()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\t\t\t\t");
            __builder.OpenElement(60, "ul");
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 140 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                     foreach (PlayerInfo _info in QuipClashHub.ActiveGames[gameID].players.Values)
					{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "\t\t\t\t\t\t");
            __builder.OpenComponent<QuipClash.Shared.PlayerListItem>(63);
            __builder.AddAttribute(64, "Username", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 142 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                   _info.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "MascottIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 142 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                  _info.mascottNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n");
#nullable restore
#line 143 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
					}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, "\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\t\t\t\t");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "hidden", 
#nullable restore
#line 145 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                  !isPartyLeader

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(71, "disabled", 
#nullable restore
#line 145 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                               QuipClashHub.ActiveGames[gameID].players.Count < 3

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 145 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                                                              StartGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(73, "Start game");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 148 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "element-container");
            __builder.AddAttribute(80, "hidden", 
#nullable restore
#line 150 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                         currentPlayerState == PlayerInfo.PlayerState.Lobby || currentPlayerState == PlayerInfo.PlayerState.Menu

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(81, "\r\n\t");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "centered");
            __builder.AddAttribute(84, "hidden", 
#nullable restore
#line 151 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                    currentPlayerState != PlayerInfo.PlayerState.Responding

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(85, "\r\n\t\t");
            __builder.OpenElement(86, "form");
            __builder.AddAttribute(87, "class", "center-content");
            __builder.AddAttribute(88, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 152 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                SendResponse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(89, "\r\n\t\t\t");
            __builder.OpenElement(90, "h2");
            __builder.AddContent(91, 
#nullable restore
#line 153 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                 currentPrompt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\t\t\t");
            __builder.OpenElement(93, "input");
            __builder.AddAttribute(94, "type", "text");
            __builder.AddAttribute(95, "maxlength", "64");
            __builder.AddAttribute(96, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 154 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                           responseInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => responseInput = __value, responseInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\t");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "centered");
            __builder.AddAttribute(103, "hidden", 
#nullable restore
#line 157 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                    currentPlayerState != PlayerInfo.PlayerState.Waiting

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(104, "\r\n\t\t");
            __builder.AddMarkupContent(105, "<h1>Please wait</h1>\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\t");
            __builder.OpenElement(107, "div");
            __builder.AddAttribute(108, "class", "centered");
            __builder.AddAttribute(109, "hidden", 
#nullable restore
#line 160 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                    currentPlayerState != PlayerInfo.PlayerState.Voting

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(110, "\r\n\t\t");
            __builder.OpenElement(111, "h2");
            __builder.AddContent(112, 
#nullable restore
#line 161 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
             currentPrompt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 162 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
         if (currentResponses != null)
		{
			foreach (ResponseInfo _response in currentResponses)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(114, "\t\t\t\t");
            __builder.OpenElement(115, "button");
            __builder.AddAttribute(116, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 166 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                  async() => await SendVote(_response.optionNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(117, 
#nullable restore
#line 166 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                      _response.response

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 167 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
			}
		}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(119, "\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\t");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "centered");
            __builder.AddAttribute(123, "hidden", 
#nullable restore
#line 170 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                    currentPlayerState != PlayerInfo.PlayerState.EndGame

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(124, "\r\n\t\t");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "leaderboard");
            __builder.AddMarkupContent(127, "\r\n\t\t\t");
            __builder.AddMarkupContent(128, "<h2 style=\"color: #e34543;\" class=\"centered\">Leaderboard</h2>\r\n");
#nullable restore
#line 173 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
             if (currentLeaderboard != null)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(129, "\t\t\t\t");
            __builder.OpenElement(130, "h3");
            __builder.AddAttribute(131, "class", "centered");
            __builder.AddContent(132, "You placed #");
            __builder.AddContent(133, 
#nullable restore
#line 175 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                  currentLeaderboard.IndexOf(currentLeaderboard.Find(p => p.username == username))

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n\t\t\t\t");
            __builder.OpenElement(135, "ol");
            __builder.AddMarkupContent(136, "\r\n");
#nullable restore
#line 177 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                     for (int i = 0; i < 3; i++)
					{
						var _info = currentLeaderboard[i];

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(137, "\t\t\t\t\t\t");
            __builder.OpenComponent<QuipClash.Shared.PlayerListItem>(138);
            __builder.AddAttribute(139, "Username", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 180 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                   _info.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(140, "MascottIndex", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 180 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                  _info.mascottNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(141, "\r\n");
#nullable restore
#line 181 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
					}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(142, "\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n");
#nullable restore
#line 183 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
			}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(144, "\t\t\t");
            __builder.OpenElement(145, "button");
            __builder.AddAttribute(146, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 184 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                              () => UpdatePlayerState(PlayerInfo.PlayerState.Menu)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(147, "Return to menu");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 189 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
       
	//local variables
	string gameIDInput = "";
	string responseInput = "";

	readonly int mascottCount = 5;

	//game variables
	string gameID = "";
	string username = "";
	bool isPartyLeader = false;

	string currentPrompt;
	int currentDuelIndex;
	List<ResponseInfo> currentResponses;
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
		hubConnection.On<string, List<ResponseInfo>>("BeginVote", (p, r) => BeginVote(p, r));
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

		var randomm = new Random();
		await hubConnection.SendAsync("RegisterPlayer", gameID, username, randomm.Next(1, mascottCount));
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

		UpdatePlayerState(PlayerInfo.PlayerState.Waiting);
	}

	public async ValueTask DisposeAsync()
	{
		if (hubConnection != null)
		{
			await hubConnection.SendAsync("RemovePlayer", gameID);
			await hubConnection.DisposeAsync();
		}
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

		StateHasChanged();
	}

	public void BeginVote(string prompt, List<ResponseInfo> responses)
	{
		currentPrompt = prompt;
		currentResponses = responses;

		//do timer stuff here
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
