#pragma checksum "D:\WebPractice\WebApplication1\WebApplication1\Views\Home\UploadFile - Copy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ac61adafe42f088ab93079d83f3a57086109bdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UploadFile___Copy), @"mvc.1.0.view", @"/Views/Home/UploadFile - Copy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UploadFile - Copy.cshtml", typeof(AspNetCore.Views_Home_UploadFile___Copy))]
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
#line 1 "D:\WebPractice\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\WebPractice\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ac61adafe42f088ab93079d83f3a57086109bdb", @"/Views/Home/UploadFile - Copy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UploadFile___Copy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadAlbum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(120, 69, true);
            WriteLiteral("\r\n\r\n<div class=\"container\" style=\"margin-top:30px; width:100%\">\r\n    ");
            EndContext();
            BeginContext(189, 5033, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d58b5e4dff4ad7a57c406ae6f9b144", async() => {
                BeginContext(297, 219, true);
                WriteLiteral("\r\n\r\n        <!--input type=\"Text\" name=\"Title\" placeholder=\"Title\" /-->\r\n\r\n        <div class=\"input-group\" style=\"margin:1px\">\r\n\r\n            <label class=\"form-control\" style=\"background-color:green; padding:0px\">\r\n\r\n");
                EndContext();
                BeginContext(700, 71, true);
                WriteLiteral("                <input type=\"file\" name=\"files\" style=\"display:none\">\r\n");
                EndContext();
                BeginContext(800, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(888, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(1096, 348, true);
                WriteLiteral(@"            </label>

            <span class=""input-group-btn"">
                <button class=""btn btn-default delbutton"" type=""button"">
                    <span class=""glyphicon glyphicon-trash""></span>
                </button>
            </span>
        </div>

        <div class=""col-lg-6"">
            <div class=""input-group"">
");
                EndContext();
                BeginContext(1556, 512, true);
                WriteLiteral(@"                <span class=""form-control""></span>
                <span class=""input-group-btn"">
                    <button class=""btn btn-default"" type=""button"">Go!</button>
                </span>
            </div><!-- /input-group -->
        </div><!-- /.col-lg-6 -->


        <br />



        <div class=""input-group"" style=""margin:1px"">

            <span class=""input-group-btn"" style=""width:80%; background-color:green"">
                <span class=""btn btn-default""> Browse </span>
");
                EndContext();
                BeginContext(2379, 110, true);
                WriteLiteral("\r\n                <span class=\"btn btn-default\" style=\"background-color:greenyellow\">\r\n                    x\r\n");
                EndContext();
                BeginContext(2678, 2537, true);
                WriteLiteral(@"                </span>
            </span>

            <span class=""input-group-btn"" style=""width:20%"">
                <button class=""btn btn-default delbutton"" type=""button"">
                    <span class=""glyphicon glyphicon-trash""></span>
                </button>
            </span>
        </div>
        <br />

        <ul id=""fileset"" style=""list-style-type: none;"">
            <li>
                <div class=""col-lg-8"">
                    <div class=""input-group"" style=""margin:1px"">

                        <label class=""input-group-btn"" style=""width:300px;background-color:cornflowerblue"">
                            <span class=""btn btn-default""> Browse </span>
                            <span class=""btn btn-default"" style=""width:300px;background-color:greenyellow"">
                                <span class=""filename"" style=""float:left;"">Choose file</span>
                                <input type=""file"" name=""files"" style=""display:none; background-color:blue"">
       ");
                WriteLiteral(@"                     </span>
                        </label>

                        <span class=""input-group-btn"">
                            <button class=""btn btn-default delbutton"" type=""button"">
                                <span class=""glyphicon glyphicon-trash""></span>
                            </button>
                        </span>
                    </div>
                </div>
            </li>
        </ul>

        <br />

        <ul id=""fileset"" style=""list-style-type: none;"">
            <li>
                <div class=""col-lg-7"">
                    <div class=""input-group"" style=""margin:1px"">
                        <label class=""form-control"" style=""background-color:greenyellow;display:inline-block;overflow:hidden"">
                            <span class=""filename"" style=""float:left;"">Choose file</span>
                            <input type=""file"" name=""files"" style=""display:none"">
                        </label>

                        <span class=""");
                WriteLiteral(@"input-group-btn"">
                            <button class=""btn btn-default delbutton"" type=""button"">
                                <span class=""glyphicon glyphicon-trash""></span>
                            </button>
                        </span>
                    </div>
                </div>
            </li>
        </ul>

        <div class=""col-lg-8"" style=""padding:20px"">
            <button type=""submit"" id=""submit"">Upload File</button>
        </div>

    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5222, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
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
