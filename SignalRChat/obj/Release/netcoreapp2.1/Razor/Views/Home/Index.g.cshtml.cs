#pragma checksum "C:\Users\hyarimaga\source\worko\SignalRGroupChat\SignalRChat\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74edb8466ff5dda234e0089e6a57bcde18a25e57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\hyarimaga\source\worko\SignalRGroupChat\SignalRChat\Views\Home\Index.cshtml"
using SignalRChat.viewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74edb8466ff5dda234e0089e6a57bcde18a25e57", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/aspnet/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/groupChat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\hyarimaga\source\worko\SignalRGroupChat\SignalRChat\Views\Home\Index.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(108, 97, true);
            WriteLiteral("\r\n<style>\r\n    .right {\r\n        color: blueviolet\r\n    }\r\n</style>\r\n<title class=\"alert-danger\">");
            EndContext();
            BeginContext(206, 15, false);
#line 15 "C:\Users\hyarimaga\source\worko\SignalRGroupChat\SignalRChat\Views\Home\Index.cshtml"
                       Write(Model.groupName);

#line default
#line hidden
            EndContext();
            BeginContext(221, 874, true);
            WriteLiteral(@"</title>
<div class=""row"">
    <div class=""col-6"">&nbsp;</div>
    <div class=""col-6"">
        <ul id=""messagesList""></ul>
    </div>
</div>
<div class=""row"">
    <div class=""col-12"">
        <hr />
    </div>
</div>
<div class=""container"">
    <div class=""row"">&nbsp;</div>
    <div class=""row"">
        <div class=""col-6"">&nbsp;</div>
        <div class=""col-6"">

            <form class=""form-inline"">
                <div class=""input-prepend input-append"">
                    <input type=""text""  name=""group-message"" id=""group-message-text"" placeholder=""Type a message"" />
                    <input type=""button"" id=""groupmsg"" class=""btn"" value=""Send to Group"" />
                    <input type=""button"" id=""leave-group"" class=""btn"" value=""Leave Group"" />

                </div>
            </form>
        </div>
    </div>


</div>
");
            EndContext();
            BeginContext(1095, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b03561809454fcc93443751afec1037", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1163, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1165, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3786116e1de4b14ae3ed790b7cf322d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1206, 55, true);
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var userName = \'");
            EndContext();
            BeginContext(1262, 14, false);
#line 49 "C:\Users\hyarimaga\source\worko\SignalRGroupChat\SignalRChat\Views\Home\Index.cshtml"
               Write(Model.userName);

#line default
#line hidden
            EndContext();
            BeginContext(1276, 25, true);
            WriteLiteral("\';\r\n    var groupName = \'");
            EndContext();
            BeginContext(1302, 15, false);
#line 50 "C:\Users\hyarimaga\source\worko\SignalRGroupChat\SignalRChat\Views\Home\Index.cshtml"
                Write(Model.groupName);

#line default
#line hidden
            EndContext();
            BeginContext(1317, 27, true);
            WriteLiteral("\';\r\n    var currentUser = \'");
            EndContext();
            BeginContext(1345, 16, false);
#line 51 "C:\Users\hyarimaga\source\worko\SignalRGroupChat\SignalRChat\Views\Home\Index.cshtml"
                  Write(ViewBag.userName);

#line default
#line hidden
            EndContext();
            BeginContext(1361, 13, true);
            WriteLiteral("\';\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
