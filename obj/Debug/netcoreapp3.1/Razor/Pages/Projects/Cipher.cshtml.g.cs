#pragma checksum "C:\Users\Leo Feng\Coding\C#\Portfolio\Portfolio\Pages\Projects\Cipher.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b5bf676997f1d323ab23147a4a366b194110479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Portfolio.Pages.Projects.Pages_Projects_Cipher), @"mvc.1.0.razor-page", @"/Pages/Projects/Cipher.cshtml")]
namespace Portfolio.Pages.Projects
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
#line 1 "C:\Users\Leo Feng\Coding\C#\Portfolio\Portfolio\Pages\_ViewImports.cshtml"
using Portfolio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b5bf676997f1d323ab23147a4a366b194110479", @"/Pages/Projects/Cipher.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb0b91d38f740f858130f6573772cab915b9c278", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Projects_Cipher : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Leo Feng\Coding\C#\Portfolio\Portfolio\Pages\Projects\Cipher.cshtml"
  
  ViewData["Title"] = "Caesar Cipher";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
  <h1 class=""display-3"">Caesar Cipher <a href=""/CSharp"" style=""font-size: 30px;"" class=""badge badge-secondary"">C#</a></h1>
  <p class=""h2"">A Caesar Cipher encoder and decoder</p>
  <br>
  <img src=""https://pages.mtu.edu/~shene/NSF-4/Tutorial/VIG/FIG-Disk.jpg"" alt=""Cipher"">
  <br>
  <hr>
  <br>
  <p style=""font-size: 25px;"">This project is a <a href=""https://en.wikipedia.org/wiki/Caesar_cipher"">Caesar Cipher</a> encoder and decoder. A caesar Cipher is a type of cipher that moves the index of a character and moves it a number of steps.</p>
  <br>
  <a href=""https://en.wikipedia.org/wiki/Caesar_cipher"" target=""_blank""><img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Caesar_cipher_left_shift_of_3.svg/1200px-Caesar_cipher_left_shift_of_3.svg.png"" alt=""Caesar Cipher"" style=""width: 500px;""></a>
  <br>
  <br>
  <p style=""font-size: 30px;"">Here is my project:</p>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Portfolio.Pages.CipherModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Portfolio.Pages.CipherModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Portfolio.Pages.CipherModel>)PageContext?.ViewData;
        public Portfolio.Pages.CipherModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
