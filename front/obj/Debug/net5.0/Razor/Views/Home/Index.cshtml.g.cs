#pragma checksum "C:\Users\Никита\Desktop\c#\front\front\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ac4f1c998a9dceb0ee47d841d7c6aa27fd6fe6"
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
#line 1 "C:\Users\Никита\Desktop\c#\front\front\Views\_ViewImports.cshtml"
using front;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Никита\Desktop\c#\front\front\Views\_ViewImports.cshtml"
using front.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ac4f1c998a9dceb0ee47d841d7c6aa27fd6fe6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd102fc9ec28beb58196f58b009bd99257526cc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<front.Models.ViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-md-inline-block form-inline ms-auto me-0 me-md-3 my-2 my-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "newElement", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sb-nav-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Никита\Desktop\c#\front\front\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!DOCTYPE html>\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ac4f1c998a9dceb0ee47d841d7c6aa27fd6fe65361", async() => {
                WriteLiteral("\r\n        <meta charset=\"utf-8\" />\r\n        <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n        <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 380, "\"", 390, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 423, "\"", 433, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
        <title>FullTextSearch</title>
        <link href=""https://cdn.jsdelivr.net/npm/simple-datatables@latest/dist/style.css"" rel=""stylesheet"" />
        <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
        <script src=""https://use.fontawesome.com/releases/v6.1.0/js/all.js"" crossorigin=""anonymous""></script>
    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ac4f1c998a9dceb0ee47d841d7c6aa27fd6fe67433", async() => {
                WriteLiteral(@"
        <nav class=""sb-topnav navbar navbar-expand navbar-dark bg-dark"">
            <a class=""navbar-brand ps-3"">FullTextSearch</a>   
        </nav>
        <div id=""layoutSidenav"">    
            <div id=""layoutSidenav_content"">
                <main>
                    <div class=""container-fluid px-4"">
                        <h3>База данных</h3>
                        <div class=""card mb-4"">
                            <div class=""card-header"">
                                <div class=""row"">                              
                                    <div class=""col-md-2"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ac4f1c998a9dceb0ee47d841d7c6aa27fd6fe68357", async() => {
                    WriteLiteral(@"
                                            <div class=""input-group"">
                                                <input name=""name"" class=""form-control"" type=""text"" placeholder=""Search for Id"" aria-label=""Search for Id"" aria-describedby=""btnNavbarSearch"" />
                                                <input type=""submit"" value=""Поиск"" class=""btn btn-default"" />
                                            </div>
                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col-md-4\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ac4f1c998a9dceb0ee47d841d7c6aa27fd6fe610584", async() => {
                    WriteLiteral(@"
                                            <div class=""input-group"">
                                                <input name=""_text"" class=""form-control"" type=""text"" placeholder=""New Element"" aria-label=""New Element"" aria-describedby=""btnNavbarSearch""/>
                                                <input type=""submit"" value=""Добавить в базу данных"" class=""btn btn-default"" />
                                            </div>
                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                            </div>
                            <div class=""card-body"">
                                <table id=""datatablesSimple"">
                                    <thead>
                                        <tr>
                                            <th>Id</th>
                                            <th>Text</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 58 "C:\Users\Никита\Desktop\c#\front\front\Views\Home\Index.cshtml"
                                         foreach (var item in Model.Texts)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n\r\n                                                <td>");
#nullable restore
#line 62 "C:\Users\Никита\Desktop\c#\front\front\Views\Home\Index.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 63 "C:\Users\Никита\Desktop\c#\front\front\Views\Home\Index.cshtml"
                                               Write(item.text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Никита\Desktop\c#\front\front\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </main>               
            </div>
        </div>
        <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" crossorigin=""anonymous""></script>
        <script src=""js/scripts.js""></script>
        <script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js"" crossorigin=""anonymous""></script>
        <script src=""assets/demo/chart-area-demo.js""></script>
        <script src=""assets/demo/chart-bar-demo.js""></script>
        <script src=""https://cdn.jsdelivr.net/npm/simple-datatables@latest"" crossorigin=""anonymous""></script>
        <script src=""js/datatables-simple-demo.js""></script>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<front.Models.ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591