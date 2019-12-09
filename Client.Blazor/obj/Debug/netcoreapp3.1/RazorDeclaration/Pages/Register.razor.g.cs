#pragma checksum "D:\NET\TrotIS\Client.Blazor\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0b48edc2de909345e44dc1731707ce6f9ffe82b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Client.Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\NET\TrotIS\Client.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NET\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NET\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\NET\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NET\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\NET\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\NET\TrotIS\Client.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\NET\TrotIS\Client.Blazor\_Imports.razor"
using Client.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\NET\TrotIS\Client.Blazor\_Imports.razor"
using Client.Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NET\TrotIS\Client.Blazor\Pages\Register.razor"
using TrotIS.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "D:\NET\TrotIS\Client.Blazor\Pages\Register.razor"
       

    private string apiUrl = "https://localhost:5010/api/user";
    private User user = new User();
    private void RegisterUser(EventArgs args)
    {
        user.UserId = Guid.NewGuid();
        user.Address = null;
        Http.PostAsJsonAsync(apiUrl, user);
        navManager.NavigateTo("/", true);
    }

    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public EnumLists.SocialClass SocialClass { get; set; }
        public virtual Address Address { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
