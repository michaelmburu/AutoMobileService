#pragma checksum "C:\Users\mimburu\Documents\.NET\AutoMobileService\AutoMobileService.Web\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ece258b13f931033f551a387984df212a15992"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\mimburu\Documents\.NET\AutoMobileService\AutoMobileService.Web\Views\_ViewImports.cshtml"
using AutoMobileService.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mimburu\Documents\.NET\AutoMobileService\AutoMobileService.Web\Views\_ViewImports.cshtml"
using AutoMobileService.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ece258b13f931033f551a387984df212a15992", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a8a425c9eac0e6ed7f382afb7d8bfef631c1e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logo.jfif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/background1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Unsplashed background img 1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mimburu\Documents\.NET\AutoMobileService\AutoMobileService.Web\Views\Shared\_Layout.cshtml"
  
Layout = "_MasterLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\r\n<nav class=\"white\" role=\"navigation\">\r\n<div class=\"nav-wrapper container\">\r\n<a id=\"logo-container\" href=\"#\" class=\"brand-logo\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c7ece258b13f931033f551a387984df212a159925332", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</a>\r\n<ul class=\"right hide-on-med-and-down\">\r\n<li><a href=\"#\">Login</a></li>\r\n<li><a href=\"#\">Contact</a></li>\r\n</ul>\r\n");
            WriteLiteral(@"<a href=""#"" data-activates=""nav-mobile"" class=""button-collapse"">
<i class=""material-icons"">menu</i></a>
</div>
</nav>
<div id=""index-banner"" class=""parallax-container"">
<div class=""section no-pad-bot"">
<div class=""container"">
<br><br>
<h1 class=""header center teal-text text-lighten-2"">Automobile Service Center</h1>
<div class=""row center"">
<h5 class=""header col s12 light "">Where Quality meets Safety</h5>
</div>
<div class=""row center"">
<a href=""http://materializecss.com/getting-started.html"" id=""downloadbutton""class=""btn-large waves-effect waves-light teal lighten-1"">Get Started</a>
</div>
<br><br>
</div>
</div>
<div class=""parallax"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c7ece258b13f931033f551a387984df212a159927388", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n</div>\r\n</header>\r\n<!-- Render Body -->\r\n<main>\r\n<div class=\"row margin-bottom-0px\">\r\n<div class=\"col s12 padding-0px\">\r\n");
#nullable restore
#line 43 "C:\Users\mimburu\Documents\.NET\AutoMobileService\AutoMobileService.Web\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
</div>
</main>
<!-- Footer -->
<footer class=""page-footer teal"">
<div class=""container"">
<div class=""row"">
<div class=""col l6 s12"">
<h5 class=""white-text"">About Us</h5>
<p class=""grey-text text-lighten-4"">
Automobile Service Center is certified to perform car services. Our
workshop operations started in October 2010.
We primarily focus on providing better services to our customers, and as
a result of the hard work, we were awarded ""Best Service"" for 2008.
</p>
</div>
<div class=""col l3 s12"">
<h5 class=""white-text"">Additional Services</h5>
<ul>
<li><a class=""white-text"" href=""#!"">Services</a></li>
<li><a class=""white-text"" href=""#!"">Finance</a></li>
<li><a class=""white-text"" href=""#!"">Used Cars</a></li>
<li><a class=""white-text"" href=""#!"">Insurance</a></li>
<li><a class=""white-text"" href=""#!"">Driving School</a></li>
</ul>
</div>
<div class=""col l3 s12"">
<h5 class=""white-text"">Connect</h5>
<ul>
<li><a class=""white-text"" href=""#!"">Facebook</a></li>
<li><a class=""white-text""");
            WriteLiteral(@" href=""#!"">LinkedIn</a></li>
<li><a class=""white-text"" href=""#!"">Twitter</a></li>
<li><a class=""white-text"" href=""#!"">Youtube</a></li>
</ul>
</div>
</div>
</div>
<div class=""footer-copyright"">
<div class=""container"">
Powered by <a class=""brown-text text-lighten-3"" href=""http://materializecss.com"">
Materialize</a>
</div>
</div>
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
