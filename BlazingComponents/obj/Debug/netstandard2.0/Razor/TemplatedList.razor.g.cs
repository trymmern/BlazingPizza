#pragma checksum "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "87365f818296cac77844c080968ba5cbb9e655c181b1d99b942deae8f259f23a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazingComponents
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#line 1 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class TemplatedList<TItem> : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
 if (_items == null)
{
    

#line default
#line hidden
#line 5 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
__builder.AddContent(0, Loading);

#line default
#line hidden
#line 5 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
            
}
else if (!_items.Any())
{
    

#line default
#line hidden
#line 9 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
__builder.AddContent(1, Empty);

#line default
#line hidden
#line 9 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
          
}
else
{

#line default
#line hidden
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "list-group" + " " + (
#line 13 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
                            ListGroupClass

#line default
#line hidden
            ));
            __builder.AddMarkupContent(5, "\n");
#line 14 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
         foreach (var item in _items)
        {

#line default
#line hidden
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "list-group-item");
            __builder.AddMarkupContent(9, "\n                ");
#line 17 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
__builder.AddContent(10, Item(item));

#line default
#line hidden
            __builder.AddMarkupContent(11, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n");
#line 19 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
        }

#line default
#line hidden
            __builder.AddContent(13, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
#line 21 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 23 "/Users/trymrt/dev/blazing-pizza/BlazingComponents/TemplatedList.razor"
       
    IEnumerable<TItem> _items;
    [Parameter] public Func<Task<IEnumerable<TItem>>> Loader { get; set; }
    [Parameter] public RenderFragment Loading { get; set; }
    [Parameter] public RenderFragment Empty { get; set; }
    [Parameter] public RenderFragment<TItem> Item { get; set; }
    [Parameter] public string ListGroupClass { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        _items = await Loader();
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591