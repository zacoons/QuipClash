#pragma checksum "C:\Users\zacha\source\repos\QuipClash\QuipClash\Shared\PlayerListItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "281270f5b8ad6f3f7161045ecdfb814ecfa1e5b6"
// <auto-generated/>
#pragma warning disable 1591
namespace QuipClash.Shared
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
    public partial class PlayerListItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n\tp.player-list-item {\r\n\t\tmargin: 0;\r\n\t\tmargin-right: 24vw;\r\n\t\toverflow: hidden;\r\n\t}\r\n\tspan {\r\n\t\toverflow: hidden;\r\n\t\tcolor: #e34543;\r\n\t}\r\n\timg {\r\n\t\twidth: 32px;\r\n\t\theight: 32px;\r\n\t}\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "class", "player-list-item");
            __builder.OpenElement(3, "img");
            __builder.AddAttribute(4, "src", 
#nullable restore
#line 17 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Shared\PlayerListItem.razor"
                                       $"/images/mascotts/{MascottIndex}.png"

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(5, " ");
            __builder.AddContent(6, 
#nullable restore
#line 17 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Shared\PlayerListItem.razor"
                                                                                   Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Shared\PlayerListItem.razor"
       
	[Parameter]
	public string Username { get; set; }

	[Parameter]
	public int MascottIndex { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
