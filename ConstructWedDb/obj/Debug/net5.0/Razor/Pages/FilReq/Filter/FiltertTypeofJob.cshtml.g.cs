#pragma checksum "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b77e19067b87f93f2a0941910b43bae38d8e975e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ConstructWedDb.Pages.FilReq.Filter.Pages_FilReq_Filter_FiltertTypeofJob), @"mvc.1.0.razor-page", @"/Pages/FilReq/Filter/FiltertTypeofJob.cshtml")]
namespace ConstructWedDb.Pages.FilReq.Filter
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
#line 1 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\_ViewImports.cshtml"
using ConstructWedDb;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b77e19067b87f93f2a0941910b43bae38d8e975e", @"/Pages/FilReq/Filter/FiltertTypeofJob.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb94684257b908fabed029982a8d6ce66f8ea04c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FilReq_Filter_FiltertTypeofJob : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th scope=\"col\">Вид работы</th>\r\n            <th scope=\"col\">материалы</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
         foreach (var item in Model.TypeOfJob)
        {
            string str = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 17 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
               Write(Html.DisplayFor(modelitem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <ol>\r\n");
#nullable restore
#line 20 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
                          
                            try
                            {
                                str = Model.Material.First(m => m.ID == item.Material1ID).Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
                               Write(str);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 25 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
                            }
                            catch
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>нет</li>\r\n");
#nullable restore
#line 29 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
                            }
                            try
                            {
                                str = Model.Material.First(m => m.ID == item.Material2ID).Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
                               Write(str);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
                            }
                            catch
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>нет</li>\r\n");
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
                            }
                            try
                            {
                                str = Model.Material.First(m => m.ID == item.Material3ID).Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 42 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
                               Write(str);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 43 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
                            }
                            catch
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>нет</li>\r\n");
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ol>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\ASUS\Desktop\ConstructWedDb\ConstructWedDb\Pages\FilReq\Filter\FiltertTypeofJob.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConstructWedDb.Pages.FilReq.Filter.FiltertTypeofJobModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConstructWedDb.Pages.FilReq.Filter.FiltertTypeofJobModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConstructWedDb.Pages.FilReq.Filter.FiltertTypeofJobModel>)PageContext?.ViewData;
        public ConstructWedDb.Pages.FilReq.Filter.FiltertTypeofJobModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
