#pragma checksum "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5d9c76cb8b04521d447de25e7cae4dcf8627ebf"
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
            __builder.AddMarkupContent(0, "<style>\r\n\tol.leaderboard {\r\n\t\tlist-style: upper-roman;\r\n\t}\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "menu");
            __builder.AddAttribute(3, "hidden", 
#nullable restore
#line 13 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                            currentPlayerState != PlayerInfo.PlayerState.Menu

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, "\r\n\t");
            __builder.OpenElement(5, "form");
            __builder.AddMarkupContent(6, "\r\n\t\t");
            __builder.AddMarkupContent(7, "<p>Username</p>\r\n\t\t");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "maxlength", "32");
            __builder.AddAttribute(11, "placeholder", "epic_username_69");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                      username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\t\t<br>\r\n\t\t<br>\r\n\t\t");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "type", "text");
            __builder.AddAttribute(17, "maxlength", "4");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                      gameIDInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => gameIDInput = __value, gameIDInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\t\t");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "button");
            __builder.AddAttribute(23, "value", "Join hub");
            __builder.AddAttribute(24, "disabled", 
#nullable restore
#line 20 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                          username == "" || gameIDInput.Length != 4 || !QuipClashHub.ActiveGames.ContainsKey(gameIDInput)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                                                                                                      JoinGame

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\t\t<br>\r\n\t\t<br>\r\n\t\t");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "value", "Create hub");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                          CreateGame

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "lobby");
            __builder.AddAttribute(36, "hidden", 
#nullable restore
#line 26 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                             currentPlayerState != PlayerInfo.PlayerState.Lobby

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 27 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
     if (QuipClashHub.ActiveGames.Count > 0 && gameID != "")
	{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "\t\t");
            __builder.OpenElement(39, "p");
            __builder.AddContent(40, "Game ID: ");
            __builder.AddContent(41, 
#nullable restore
#line 29 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                     gameID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\t\t");
            __builder.OpenElement(43, "ul");
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 31 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
             foreach (PlayerInfo _info in QuipClashHub.ActiveGames[gameID].players.Values)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "\t\t\t\t");
            __builder.OpenComponent<QuipClash.Shared.PlayerListItem>(46);
            __builder.AddAttribute(47, "Username", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                           _info.username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "IsPartyLeader", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                           _info.isPartyLeader

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 34 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
			}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(50, "\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\t\t");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "hidden", 
#nullable restore
#line 36 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                          !isPartyLeader

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(54, "disabled", (
#nullable restore
#line 36 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                      QuipClashHub.ActiveGames[gameID].players.Count

#line default
#line hidden
#nullable disable
            ) + " >=" + " 3");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                                                     StartGame

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(56, "Start game");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 37 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
	}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "game");
            __builder.AddAttribute(61, "hidden", 
#nullable restore
#line 39 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                            currentPlayerState == PlayerInfo.PlayerState.Lobby

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(62, "\r\n\t");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "responding");
            __builder.AddAttribute(65, "hidden", 
#nullable restore
#line 40 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                      currentPlayerState != PlayerInfo.PlayerState.Responding

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(66, "\r\n\t\t");
            __builder.OpenElement(67, "form");
            __builder.AddAttribute(68, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 41 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                         SendResponse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(69, "\r\n\t\t\t");
            __builder.OpenElement(70, "p");
            __builder.OpenElement(71, "b");
            __builder.AddContent(72, 
#nullable restore
#line 42 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                   currentPrompt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\t\t\t");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "text");
            __builder.AddAttribute(76, "maxlength", "64");
            __builder.AddAttribute(77, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                           responseInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => responseInput = __value, responseInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\t");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "waiting");
            __builder.AddAttribute(84, "hidden", 
#nullable restore
#line 46 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                   currentPlayerState != PlayerInfo.PlayerState.Waiting

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(85, "\r\n\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\t");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "voting");
            __builder.AddAttribute(89, "hidden", 
#nullable restore
#line 49 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                  currentPlayerState != PlayerInfo.PlayerState.Voting

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(90, "\r\n\t\t");
            __builder.OpenElement(91, "p");
            __builder.OpenElement(92, "b");
            __builder.AddContent(93, 
#nullable restore
#line 50 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
               currentPrompt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n");
#nullable restore
#line 51 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
         if (currentResponses != null)
		{
			foreach (ResponseInfo _response in currentResponses)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(95, "\t\t\t\t");
            __builder.OpenElement(96, "button");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                  async() => await SendVote(_response.optionNumber)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(98, 
#nullable restore
#line 55 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                      _response.response

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 56 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
			}
		}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(100, "\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n\t");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "voting");
            __builder.AddAttribute(104, "hidden", 
#nullable restore
#line 59 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                  currentPlayerState != PlayerInfo.PlayerState.EndGame

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(105, "\r\n\t\t");
            __builder.OpenElement(106, "ol");
            __builder.AddAttribute(107, "class", "leaderboard");
            __builder.AddMarkupContent(108, "\r\n");
#nullable restore
#line 61 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
             if (currentLeaderboard != null)
			{
				

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                 for (int i = 0; i < 3; i++)
				{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(109, "\t\t\t\t\t");
            __builder.OpenComponent<QuipClash.Shared.PlayerListItem>(110);
            __builder.AddAttribute(111, "Username", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                               currentLeaderboard[i].username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(112, "IsPartyLeader", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 65 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                                                                                               currentLeaderboard[i].isPartyLeader

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 66 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                 
			}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(114, "\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\t\t");
            __builder.OpenElement(116, "button");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 69 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
                          () => UpdatePlayerState(PlayerInfo.PlayerState.Menu)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(118, "Return to menu");
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Pages\Index.razor"
       
	//UI variables
	string gameIDInput = "";
	string responseInput = "";

	//game variables
	string gameID = "";
	string username = "";
	bool isPartyLeader = false;

	string currentPrompt;
	int currentDuelIndex;
	List<ResponseInfo> currentResponses;
	List<PlayerInfo> currentLeaderboard;
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
		hubConnection.On<string, List<ResponseInfo>>("ReceiveResponses", (p, r) => ReceiveResponses(p, r));
		hubConnection.On<string, int>("BeginRespond", (p, d) => BeginRespond(p, d));
		hubConnection.On<PlayerInfo.PlayerState>("UpdatePlayerState", (s) => UpdatePlayerState(s));
		hubConnection.On<List<PlayerInfo>>("GameEnded", (l) => GameEnded(l));
		hubConnection.On("UpdateUI", () => StateHasChanged());

		//initiates the connection
		await hubConnection.StartAsync();

		//brings you to the menu
		UpdatePlayerState(PlayerInfo.PlayerState.Menu);
	}

	// outbound logic //

	async Task JoinGame()
	{
		gameID = gameIDInput;

		await hubConnection.SendAsync("RegisterPlayer", gameID, username);

		UpdatePlayerState(PlayerInfo.PlayerState.Lobby);
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

		StateHasChanged();
	}

	public void ReceiveResponses(string prompt, List<ResponseInfo> responses)
	{
		currentPrompt = prompt;
		currentResponses = responses;
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
