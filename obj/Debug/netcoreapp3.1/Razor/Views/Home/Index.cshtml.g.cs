#pragma checksum "C:\Users\ASUS\Desktop\упр.Уеб програмиран\Sample exam\Sample exam\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a199daae5c938140eaaaff9abdf6c14042ad2497"
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
#line 2 "C:\Users\ASUS\Desktop\упр.Уеб програмиран\Sample exam\Sample exam\Views\Home\Index.cshtml"
using Sample_exam.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a199daae5c938140eaaaff9abdf6c14042ad2497", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sample_exam.ViewModels.Reservations.IndexVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\упр.Уеб програмиран\Sample exam\Sample exam\Views\Home\Index.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Reservations";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<a href=""/Home/Create"" type=""button"" class=""btn btn-danger btn-lg btn-block"">Add new reservations</a>

<table class=""table table-striped table-dark"">
    <thead>
    <th colspan=""5"" class=""text-center"">Reservations</th>
    <tr>
        <th scope=""col"">Full Name</th>
        <th scope=""col"">Table Size</th>
        <th scope=""col"">Date</th>
        <th scope=""col""></th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\ASUS\Desktop\упр.Уеб програмиран\Sample exam\Sample exam\Views\Home\Index.cshtml"
         foreach (Reservation item in Model.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\ASUS\Desktop\упр.Уеб програмиран\Sample exam\Sample exam\Views\Home\Index.cshtml"
                           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\упр.Уеб програмиран\Sample exam\Sample exam\Views\Home\Index.cshtml"
               Write(item.TableSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\упр.Уеб програмиран\Sample exam\Sample exam\Views\Home\Index.cshtml"
               Write(item.DateTime.ToString("dd.MM.yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 880, "\"", 909, 2);
            WriteAttributeValue("", 887, "/Home/Edit?id=", 887, 14, true);
#nullable restore
#line 30 "C:\Users\ASUS\Desktop\упр.Уеб програмиран\Sample exam\Sample exam\Views\Home\Index.cshtml"
WriteAttributeValue("", 901, item.Id, 901, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Edit</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 967, "\"", 998, 2);
            WriteAttributeValue("", 974, "/Home/Delete?id=", 974, 16, true);
#nullable restore
#line 31 "C:\Users\ASUS\Desktop\упр.Уеб програмиран\Sample exam\Sample exam\Views\Home\Index.cshtml"
WriteAttributeValue("", 990, item.Id, 990, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\упр.Уеб програмиран\Sample exam\Sample exam\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sample_exam.ViewModels.Reservations.IndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591