#pragma checksum "C:\Users\mimburu\Documents\.NET\AutoMobileService\AutoMobileService.Web\Views\Shared\_SecureLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9921fda5a87efeda9d9e6a3e4d1b9d501ed20b81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SecureLayout), @"mvc.1.0.view", @"/Views/Shared/_SecureLayout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9921fda5a87efeda9d9e6a3e4d1b9d501ed20b81", @"/Views/Shared/_SecureLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a8a425c9eac0e6ed7f382afb7d8bfef631c1e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SecureLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/male.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\mimburu\Documents\.NET\AutoMobileService\AutoMobileService.Web\Views\Shared\_SecureLayout.cshtml"
  
    Layout = "_MasterLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Header -->
<header class=""secureLayout"">
    <nav class=""top-nav blue-grey lighten-1"">
        <div class=""nav-wrapper row valign-wrapper"">
            <div class=""col s12 valign-wrapper"">
                <a href=""#"" data-activates=""nav-mobile"" class=""button-collapse top-nav full hide-on-large-only white-text""><i class=""material-icons"">menu</i></a>
                <h5><a class=""page-title"">Automobile Service Center</a></h5>
            </div>
        </div>
    </nav>

    <!-- Side NavBar -->
    <ul id=""nav-mobile"" class=""side-nav fixed"">
        <li>
            <div class=""userView"">
                <div class=""background blue-grey lighten-1""></div>
                <a href=""#!user"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9921fda5a87efeda9d9e6a3e4d1b9d501ed20b814878", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</a>
                <a href=""#!name""><span class=""white-text name"">John Doe</span></a>
                <a href=""#!email""><span class=""white-text email"">jdandturk@gmail.com</span></a>
            </div>
        </li>
        <li><a class=""collapsible-header"" href=""#!""><i class=""material-icons"">dashboard</i>Dashboard</a></li>

        <li>
            <ul class=""collapsible collapsible-accordion"">
                <li>
                    <a class=""collapsible-header"">User Administration<i class=""material-icons"">supervisor_account</i></a>
                    <div class=""collapsible-body"">
                        <ul>
                            <li><a href=""#!"">Customers<i class=""material-icons"">account_box</i></a></li>
                            <li><a href=""#!"">Provision User<i class=""material-icons"">person_add</i></a></li>
                            <li><a href=""#!"">Deactivate User<i class=""material-icons"">remove_circle</i></a></li>
                        </ul>
                    </div>");
            WriteLiteral(@"
                </li>
            </ul>
        </li>
        <li><a class=""collapsible-header"" href=""#!""><i class=""material-icons"">perm_data_setting</i>Service Requests</a></li>
        <li><a class=""collapsible-header"" href=""#!""><i class=""material-icons"">message</i>Service Notifications</a></li>
        <li><a class=""collapsible-header"" href=""#!""><i class=""material-icons"">inbox</i>Promotions</a></li>
        <li><a class=""collapsible-header"" href=""#!""><i class=""material-icons"">settings</i>Settings</a></li>
        <li><a class=""collapsible-header"" href=""#!""><i class=""material-icons"">exit_to_app</i>Logout</a></li>
    </ul>
</header>

<!-- Render Body -->
<main class=""secureLayout"">
    <div class=""row margin-bottom-0px"">
        <div class=""col s12"">
            ");
#nullable restore
#line 54 "C:\Users\mimburu\Documents\.NET\AutoMobileService\AutoMobileService.Web\Views\Shared\_SecureLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
</main>

<!-- Footer -->
<footer class=""page-footer blue-grey lighten-1 secureLayout"">
    <div class=""row"">
        <div class=""col l6 s12"">
            <h5 class=""white-text"">About Us</h5>
            <p class=""grey-text text-lighten-4"">
                Automobile Service Center is certified Company to perform car services. Our Workshop operations started in the month of October, 2010.
                We primarily focus on providing better services to our customers, and as a result of the hard work we were awarded as the ""Best Service"" for the year 2008 and that too within a short period of time.
            </p>

        </div>
        <div class=""col l3 s12"">
            <h5 class=""white-text"">Additional Services</h5>
            <ul>
                <li><a class=""white-text"" href=""#!"">Services</a></li>
                <li><a class=""white-text"" href=""#!"">Finance</a></li>
                <li><a class=""white-text"" href=""#!"">Used Cars</a></li>
                ");
            WriteLiteral(@"<li><a class=""white-text"" href=""#!"">Insurance</a></li>
                <li><a class=""white-text"" href=""#!"">Driving School</a></li>
            </ul>
        </div>
        <div class=""col l3 s12"">
            <h5 class=""white-text"">Connect</h5>
            <ul>
                <li><a class=""white-text"" href=""#!"">Facebook</a></li>
                <li><a class=""white-text"" href=""#!"">LinkedIn</a></li>
                <li><a class=""white-text"" href=""#!"">Twitter</a></li>
                <li><a class=""white-text"" href=""#!"">Youtube</a></li>
            </ul>
        </div>
    </div>
    <div class=""footer-copyright row margin-bottom-0px"">
        <div class=""col s12"">
            Powered by <a class=""brown-text text-lighten-3"" href=""http://materializecss.com"">Materialize</a>
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
