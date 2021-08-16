#pragma checksum "C:\Users\zacha\source\repos\QuipClash\QuipClash\Shared\ResponseVoteOption.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b8604fa027e216d97bd8980b49fe46b9f600afe"
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
    public partial class ResponseVoteOption : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
	div.vote-option {
		width: 256px;
		height: 128px;
		margin-right: 32px;
	}
	.vote-option button {
		width: 256px;
		height: 128px;
		background-color: white;
		border: dashed;
		border-color: #f7d43b;
	}
		.vote-option button:disabled {
			background-color: lightgray;
		}
	.vote-option p {
		margin-top: -24px;
		width: 100%;
		text-align: center;
		font-size: 32px;
		font-weight: bold;
		color: #e34543;
		-webkit-text-stroke-width: 2px;
		-webkit-text-stroke-color: black;
	}
</style>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "vote-option");
            __builder.AddMarkupContent(3, "\r\n\t");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "disabled", 
#nullable restore
#line 30 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Shared\ResponseVoteOption.razor"
                       Disabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Shared\ResponseVoteOption.razor"
                                           (e) => OnClick.InvokeAsync(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n\t\t");
            __builder.AddContent(8, 
#nullable restore
#line 31 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Shared\ResponseVoteOption.razor"
         ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(9, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\t");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 33 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Shared\ResponseVoteOption.razor"
        Votes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\zacha\source\repos\QuipClash\QuipClash\Shared\ResponseVoteOption.razor"
       
	[Parameter]
	public bool Disabled { get; set; }

	[Parameter]
	public EventCallback OnClick { get; set; }

	[Parameter]
	public int Votes { get; set; }

	[Parameter]
	public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
