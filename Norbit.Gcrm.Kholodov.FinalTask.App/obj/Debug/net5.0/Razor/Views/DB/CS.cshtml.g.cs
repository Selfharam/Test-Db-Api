#pragma checksum "C:\Prog\VSprojects\Probation\Belgorod\Anton.Kholodov\FinalTask\Norbit.Gcrm.Kholodov.FinalTask.App\Views\DB\CS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4aaeffd0be5fe6077ad1cf8bf25257f99f3a28c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DB_CS), @"mvc.1.0.view", @"/Views/DB/CS.cshtml")]
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
#line 1 "C:\Prog\VSprojects\Probation\Belgorod\Anton.Kholodov\FinalTask\Norbit.Gcrm.Kholodov.FinalTask.App\Views\_ViewImports.cshtml"
using Norbit.Gcrm.Kholodov.FinalTask.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Prog\VSprojects\Probation\Belgorod\Anton.Kholodov\FinalTask\Norbit.Gcrm.Kholodov.FinalTask.App\Views\_ViewImports.cshtml"
using Norbit.Gcrm.Kholodov.FinalTask.App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Prog\VSprojects\Probation\Belgorod\Anton.Kholodov\FinalTask\Norbit.Gcrm.Kholodov.FinalTask.App\Views\DB\CS.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Prog\VSprojects\Probation\Belgorod\Anton.Kholodov\FinalTask\Norbit.Gcrm.Kholodov.FinalTask.App\Views\DB\CS.cshtml"
using Norbit.Gcrm.Kholodov.Final.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4aaeffd0be5fe6077ad1cf8bf25257f99f3a28c", @"/Views/DB/CS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db06fd560880feeeb723ff6ce154cd0386725c10", @"/Views/_ViewImports.cshtml")]
    public class Views_DB_CS : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Prog\VSprojects\Probation\Belgorod\Anton.Kholodov\FinalTask\Norbit.Gcrm.Kholodov.FinalTask.App\Views\DB\CS.cshtml"
  
    string result = ViewBag.Message;
    TransactionEntity transaction = JsonConvert.DeserializeObject<TransactionEntity>(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!doctype html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4aaeffd0be5fe6077ad1cf8bf25257f99f3a28c4261", async() => {
                WriteLiteral("\r\n    <title>Final</title>\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4aaeffd0be5fe6077ad1cf8bf25257f99f3a28c5352", async() => {
                WriteLiteral("\r\n    <p>Последней сделка: </p>\r\n    <p>Дата: </p>\r\n    <label>");
#nullable restore
#line 21 "C:\Prog\VSprojects\Probation\Belgorod\Anton.Kholodov\FinalTask\Norbit.Gcrm.Kholodov.FinalTask.App\Views\DB\CS.cshtml"
      Write(transaction.Created.ToLocalTime());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n    <p>Сумма: </p>\r\n<label>");
#nullable restore
#line 23 "C:\Prog\VSprojects\Probation\Belgorod\Anton.Kholodov\FinalTask\Norbit.Gcrm.Kholodov.FinalTask.App\Views\DB\CS.cshtml"
  Write(transaction.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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