#pragma checksum "C:\Dev\CSharpDotNet\CamtosoUniversity_Razor_Pages_EF\ContosoUniversity\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "479c49569a8bac3663ae8dc71a74fb961dcc2fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoUniversity.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContosoUniversity.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Dev\CSharpDotNet\CamtosoUniversity_Razor_Pages_EF\ContosoUniversity\Pages\_ViewImports.cshtml"
using ContosoUniversity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"479c49569a8bac3663ae8dc71a74fb961dcc2fd2", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4c0473ebe7d620ab1ae06d83bc5bc87bf314407", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Dev\CSharpDotNet\CamtosoUniversity_Razor_Pages_EF\ContosoUniversity\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mb-auto"">
    <div class=""col-md-4"">
        <div class=""row no-gutters border mb-4"">
            <div class=""col p-4 mb-4"">
                <p class=""card-text"">
                    Contoso University is Nigeria's best university in computing and 
                    artificial intelligence (AI) learning. We rank number 1 in the 
                    Nigerian Universities Commission (NUC) webometrics ranking for 
                    3 years straight and we're not stopping....anytime soon....
                    THis is made with Entity Framework cum Razor pages...
                </p>
            </div>
        </div>
    </div><!--end first column -->
    <div class=""col-md-4"">
        <div class=""row no-gutters border mb-4"">
            <div class=""col p-4 d-flex flex-column position-static"">
                <p class=""card-text mb-auto"">
                    We are going to build amazing applications in this Entity Framework
                    and Razor pages series... J");
            WriteLiteral(@"ust patiently and consciously follow me on this journey

                </p>
                <p>
                    <a href=""https://docs.microsoft.com/aspent/core/data/ef-rp/into"" class=""stretched-link"">See the tutorial here</a>
                </p>
            </div>
        </div>
    </div><!--close 2nd column...-->
    <div class=""col-md-4"">
        <div class=""row no-gutters border mb-4"">
            <div class=""col p-4 d-flex flex-column"">
                <p class=""card-text mb-auto"">
                    You can download the completed project from GitHub.
                </p>
                <p>
                    <a href=""https://github.com/dotnet/AspNetCore.Docs/tree/master/aspnetcore/data/ef-rp/intro/samples"" class=""stretched-link"">See project source code</a>
                </p>
            </div>
        </div>
    </div><!-- close 3rd column here -->
</div><!-- Close row --!
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
