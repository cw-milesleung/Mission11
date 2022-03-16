// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LmazonBookStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/Admin/_Imports.razor"
using LmazonBookStore.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/create")]
    public partial class Editor : OwningComponentBase<IBookStoreRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "/Users/milesleung/Desktop/413/LmazonBookStore/LmazonBookStore/Pages/Admin/Editor.razor"
       

    public IBookStoreRepository repo => Service;

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public long Id { get; set; } = 0;

    public LmazonBookStore.Models.Books books { get; set; } = new LmazonBookStore.Models.Books();

    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            books = repo.Books.FirstOrDefault(x => x.BookId == Id);
        }
    }

    public void SaveProduct()
    {
        if (Id == 0)
        {
            repo.CreateProduct(books);
        }
        else
        {
            repo.SaveProduct(books);
        }

        NavManager.NavigateTo("/admin/books");
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";

    public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591