#pragma checksum "C:\Users\danie\OneDrive\Desktop\PartyRSVPapp2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe9067ec341f6e9c2a67896c64d7e797f072ac54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\danie\OneDrive\Desktop\PartyRSVPapp2\Views\_ViewImports.cshtml"
using PartyRSVPapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danie\OneDrive\Desktop\PartyRSVPapp2\Views\_ViewImports.cshtml"
using PartyRSVPapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9067ec341f6e9c2a67896c64d7e797f072ac54", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e3fcd2c76b9cdb11318fae43a05f6d987d78a0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("myemailform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("form-to-email.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""vh-83"" id=""home1"">
<div class=""col-2-3"">
    <h1 class=""name text-center text-white"">""Having a good functional website will equip your business for the success you have been dreaming of.""<a class=""text-center btn"" href=""../views/contact.cshtml"">Contact me today!</a></h1>



    <p class=""intro text-black text-light "">
        I am a Web Developer in Sacramento, CA.  
       I will help you build your site and keeping it up to date.
        With my search engine optimization experience, I will help you increase traffic to your site.
     </p>
</div>
<div class=""col-1-3"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9067ec341f6e9c2a67896c64d7e797f072ac544815", async() => {
                WriteLiteral(@"
        <h5>Quick Contact Form:</h5>
        <div><label>Name: </label><input placeholder=""type your name here"" required /></div>
        <div>
            <label>Email:</label>
            <input placeholder=""type your email here"" required />
        </div>

        <label>Phone Number: </label>
        <input placeholder=""type your phone number here"" required />

        <label>Best Time to Reach You:</label>
        <div class=""form-check form-check-inline"">

            <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio1"" value=""option1"">
            <label class=""form-check-label"" for=""Mornings"">Mornings</label>
        </div>
        <div class=""form-check form-check-inline"">
            <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio2"" value=""option2"">
            <label class=""form-check-label"" for=""Afternoons"">Afternoons</label>
        </div>
        <div class=""form-check form-check-inline"">
          ");
                WriteLiteral("  <input class=\"form-check-input\" type=\"radio\" name=\"inlineRadioOptions\" id=\"inlineRadio3\" value=\"option3\">\r\n            <label class=\"form-check-label\" for=\"Evenings\">Evenings</label>\r\n        </div>\r\n        <button>Submit</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
    </div>
<!--<div class="""">
        <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">

            <div class=""carousel-inner h-100"">
                <div class=""carousel-item active h-100"" id=""slide1"">
                    <h1 class=""col-1-4"">Do you have an idea for a new website or a new?</h1>


                </div>
                <div class=""carousel-item h-100"" id=""slide2"">

                    <img class=""slideimg"" src=""~/lib/design.jpg"" alt=""First slide"">

                </div>
                <div class=""carousel-item h-100"" id=""slide3"">

                    <img class=""slideimg"" src=""~/lib/socialmedia3.jpg"" alt=""First slide"">

                </div>
                <div class=""carousel-item h-100"" id=""slide4"">

                    <img class=""slideimg"" src=""~/lib/revenue.jpg"" alt=""First slide"">

                </div>
                <div class=""carousel-item h-100"" id=""slide5"">

                    <img class=""slideimg"" src=""~/l");
            WriteLiteral(@"ib/seo.png"" alt=""First slide"">

                </div>
            </div>






            <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
            <ol class=""carousel-indicators bg-dark"" id=""ind"">
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
                <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
                <li data-target=""#carouselExampleIndicators""");
            WriteLiteral(" data-slide-to=\"3\"></li>\r\n                <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"4\"></li>\r\n            </ol>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n</div>-->\r\n");
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
