#pragma checksum "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "247698617d9265b4326f456b5c52317df61a5516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pokemon_Index), @"mvc.1.0.view", @"/Views/Pokemon/Index.cshtml")]
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
#line 1 "C:\Users\joshu\source\repos\DiarsT2\Views\_ViewImports.cshtml"
using DiarsT2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\joshu\source\repos\DiarsT2\Views\_ViewImports.cshtml"
using DiarsT2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247698617d9265b4326f456b5c52317df61a5516", @"/Views/Pokemon/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e05baa478203e1e483160d0f96ffab950123374a", @"/Views/_ViewImports.cshtml")]
    public class Views_Pokemon_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DiarsT2.Models.Pokemon>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Pokemon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Pokemon/Capture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<h1>Pokemones</h1>\n\n<div class=\"row\">\n    <div class=\"col-4\">\n        <!-- FORMULARIO DE BUSQUEDA -->\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "247698617d9265b4326f456b5c52317df61a55164599", async() => {
                WriteLiteral("\n            <div class=\"form-row\">\n                <div class=\"form-group col-auto\">\n                    <input type=\"text\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 320, "\"", 345, 1);
#nullable restore
#line 11 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 328, ViewBag.Busqueda, 328, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" />\n                </div>\n                <div class=\"col-2\">\n                    <button type=\"submit\" class=\"btn btn-info\">Buscar</button>\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-8"">
        <a style=""margin-right:40px;"" href=""/Pokemon/Register"" class=""btn btn-outline-primary"">Registra un Pokemon</a>
        <a href=""/Type"" class=""btn btn-outline-primary"">Tipos de Pokemones</a>
        <a style=""margin-left:80px; margin-top:-120px;"" href=""/Auth/Login"" class=""btn btn-success"">Inicia Sesión</a>
    </div>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Nombre</th>
            <th>Tipo</th>
            <th>Imagen</th>
");
#nullable restore
#line 33 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
             if (ViewBag.UserId != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th></th>\n");
#nullable restore
#line 36 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 40 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
         foreach (var pokemon in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 43 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
               Write(pokemon.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                <td>");
#nullable restore
#line 44 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
               Write(pokemon.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                <td>");
#nullable restore
#line 45 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
               Write(pokemon.Type.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                <td>\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1459, "\"", 1483, 1);
#nullable restore
#line 47 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 1465, pokemon.ImagePath, 1465, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"50\" width=\"50\" />\n                </td>\n");
#nullable restore
#line 49 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
                 if (ViewBag.UserId != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <th>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "247698617d9265b4326f456b5c52317df61a55169578", async() => {
                WriteLiteral("\n                            <input type=\"hidden\" name=\"PokemonId\"");
                BeginWriteAttribute("value", " value=\"", 1757, "\"", 1776, 1);
#nullable restore
#line 53 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 1765, pokemon.Id, 1765, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                            <input type=\"hidden\" name=\"UserId\"");
                BeginWriteAttribute("value", " value=\"", 1843, "\"", 1866, 1);
#nullable restore
#line 54 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
WriteAttributeValue("", 1851, ViewBag.UserId, 1851, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                            <button type=\"submit\" class=\"btn btn-outline-success\">Capturar</button>\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </th>\n");
#nullable restore
#line 58 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n");
#nullable restore
#line 60 "C:\Users\joshu\source\repos\DiarsT2\Views\Pokemon\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DiarsT2.Models.Pokemon>> Html { get; private set; }
    }
}
#pragma warning restore 1591
