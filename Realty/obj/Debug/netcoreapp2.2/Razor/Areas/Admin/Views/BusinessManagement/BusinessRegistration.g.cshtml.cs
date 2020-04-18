#pragma checksum "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03555ac02f0b5465e420eb3bdc7e1a93552bf75f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BusinessManagement_BusinessRegistration), @"mvc.1.0.view", @"/Areas/Admin/Views/BusinessManagement/BusinessRegistration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/BusinessManagement/BusinessRegistration.cshtml", typeof(AspNetCore.Areas_Admin_Views_BusinessManagement_BusinessRegistration))]
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
#line 1 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
using Realty.Areas.Admin.Models;

#line default
#line hidden
#line 2 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
using Realty.Areas.Admin.Constants;

#line default
#line hidden
#line 3 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
using Realty.Constants;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03555ac02f0b5465e420eb3bdc7e1a93552bf75f", @"/Areas/Admin/Views/BusinessManagement/BusinessRegistration.cshtml")]
    public class Areas_Admin_Views_BusinessManagement_BusinessRegistration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessInfoFormModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(96, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
  
    ViewData["Title"] = "BusinessRegistration";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(236, 36, true);
            WriteLiteral("\r\n<h1>Business Registration</h1>\r\n\r\n");
            EndContext();
#line 13 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
 using (Html.BeginForm(Realty.Areas.Admin.Constants.ControllerActionConstants.SAVE_BUSINESS_REGISTRATION, Realty.Areas.Admin.Constants.ControllerActionConstants.BUSINESS_MANAGEMENT_CONTROLLER, new { area = AppAreas.Admin }, FormMethod.Post))
{

#line default
#line hidden
            BeginContext(518, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(557, 26, false);
#line 16 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
   Write(Html.LabelFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(583, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(594, 92, false);
#line 17 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
   Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control", placeholder = "Business Name" }));

#line default
#line hidden
            EndContext();
            BeginContext(686, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(697, 74, false);
#line 18 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
   Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(771, 52, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(824, 27, false);
#line 21 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
   Write(Html.LabelFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(851, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(862, 94, false);
#line 22 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", placeholder = "Business Email" }));

#line default
#line hidden
            EndContext();
            BeginContext(956, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(967, 75, false);
#line 23 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
   Write(Html.ValidationMessageFor(m => m.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1058, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1097, 29, false);
#line 27 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
   Write(Html.LabelFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1137, 99, false);
#line 28 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
   Write(Html.TextAreaFor(m => m.Address, new { @class = "form-control", placeholder = "Business Address" }));

#line default
#line hidden
            EndContext();
            BeginContext(1236, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1255, 25, false);
#line 30 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 69, true);
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-primary\">Register</button>\r\n");
            EndContext();
#line 33 "C:\Users\kevin\Desktop\Projects\Realty\Realty\Areas\Admin\Views\BusinessManagement\BusinessRegistration.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessInfoFormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591