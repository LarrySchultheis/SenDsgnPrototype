#pragma checksum "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\Home\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d943e1cbb8be3098963b8c95091f06e34662bcd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomePage), @"mvc.1.0.view", @"/Views/Home/HomePage.cshtml")]
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
#line 1 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\_ViewImports.cshtml"
using MVCApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\_ViewImports.cshtml"
using MVCApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d943e1cbb8be3098963b8c95091f06e34662bcd4", @"/Views/Home/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffc2c33a2db2f5e09931edba2ebdc432ae0da8c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\Home\HomePage.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n");
#nullable restore
#line 7 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\Home\HomePage.cshtml"
  
    List<DummyData> dataList = new List<DummyData>();
    DummyData data;
    data = new DummyData("Stage", "1234ASD", "3A", "Lars Umlaut", "12:30");
    dataList.Add(data);
    data = new DummyData("UPS", "233FSDF", "3A", "Jethro Abernathy", "12:30");
    dataList.Add(data);
    data = new DummyData("Pallete Picker", "1234DGF", "3A", "Jed Cumberbatch", "12:30");
    dataList.Add(data);
    data = new DummyData("Amazon", "234ERDB", "3A", "Benedict Smith", "12:30");
    dataList.Add(data);
    data = new DummyData("Stage", "233SDCS", "3A", "Gustaf Gundarsonn", "12:30");
    dataList.Add(data);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""text-center"">
    <h2 class=""display-4"">Here's the latest data</h2>
    <br />
    <br />

</div>

<div>
    <table id=""dummyTable"" class=""table table-hover table-bordered table-dark"">
        <thead class=""thead-light"">
            <tr>
                <th>Job Type</th>
                <th>Trip Number</th>
                <th>Stage Number</th>
                <th>Employee Name</th>
                <th>Time</th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 43 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\Home\HomePage.cshtml"
              
                foreach (DummyData d in dataList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 47 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\Home\HomePage.cshtml"
                       Write(d.JobType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\Home\HomePage.cshtml"
                       Write(d.tripNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\Home\HomePage.cshtml"
                       Write(d.stageNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\Home\HomePage.cshtml"
                       Write(d.EmplName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\Home\HomePage.cshtml"
                       Write(d.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 53 "D:\testWebApp\testMVC\MVCApp\MVCApp\Views\Home\HomePage.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
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
