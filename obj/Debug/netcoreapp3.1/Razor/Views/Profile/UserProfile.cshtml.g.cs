#pragma checksum "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbaa4a53ebade55378bba99adebcf75a502f8ba8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_UserProfile), @"mvc.1.0.view", @"/Views/Profile/UserProfile.cshtml")]
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
#line 1 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\_ViewImports.cshtml"
using SocialMedia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\_ViewImports.cshtml"
using SocialMedia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
using SocialMedia.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbaa4a53ebade55378bba99adebcf75a502f8ba8", @"/Views/Profile/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f56dfa1dbe8b15121c374dfeed1ad76b13ecb107", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_PostPartial.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
  
	User user = await _user.FindByIdAsync(Model.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"container-profile\">\r\n\t<div class=\"user\">\r\n\t\t<div class=\"form-group\" style=\"display: flex; justify-content: center\">\r\n");
#nullable restore
#line 15 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
             if (Model.Picture != null)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<img id=\"profilePicture\" style=\"width: 200px; height: 200px; object-fit: fill\"");
            BeginWriteAttribute("src", " src=\"", 509, "\"", 575, 2);
            WriteAttributeValue("", 515, "data:image/*;base64,", 515, 20, true);
#nullable restore
#line 17 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
WriteAttributeValue("", 535, Convert.ToBase64String(Model.Picture), 535, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 18 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<img class=\"back-color\" id=\"profilePicture\" style=\"width: 200px; height: 200px;\" />\r\n");
#nullable restore
#line 22 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t\t<h1 style=\"text-align: center\">");
#nullable restore
#line 24 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
                                  Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\t\t<h5 style=\"text-align: center\">Status: ");
#nullable restore
#line 25 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
                                          Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t</div>\r\n\t<div class=\"info\">\r\n\t\t<h5>First Name: ");
#nullable restore
#line 28 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t<h5>Last Name: ");
#nullable restore
#line 29 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
                  Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t<h5>Birth: ");
#nullable restore
#line 30 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
              Write(Model.Birth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t<div class=\"button\">\r\n");
#nullable restore
#line 32 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
              
				if (user.Id == _user.GetUserId(User))
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<input type=\"button\" value=\"Change\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1085, "\"", 1149, 3);
            WriteAttributeValue("", 1095, "location.href=\'", 1095, 15, true);
#nullable restore
#line 35 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
WriteAttributeValue("", 1110, Url.Action("UpdateProfile","Profile"), 1110, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1148, "\'", 1148, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 36 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
				}
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n\r\n\t<div class=\"add-post\">\r\n");
#nullable restore
#line 42 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
         if (user.Id == _user.GetUserId(User))
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fbaa4a53ebade55378bba99adebcf75a502f8ba88548", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 44 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new PostModel();

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</div>\r\n\r\n\r\n</section>\r\n<section class=\"container-post\">\r\n\t<div class=\"profile-links\">\r\n\r\n\t</div>\r\n");
#nullable restore
#line 54 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
     if (_post.GetUserPosts(user.Profile.Id).Count() > 0)
	{
		foreach (var post in _post.GetUserPosts(user.Profile.Id).OrderByDescending(n => n.Id))
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"profile-post\">\r\n");
#nullable restore
#line 59 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
                 if (post.Image != null)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<img style=\"width: 200px; height: 200px; object-fit: fill; max-height: 100%\"");
            BeginWriteAttribute("src", " src=\"", 1737, "\"", 1800, 2);
            WriteAttributeValue("", 1743, "data:image/*;base64,", 1743, 20, true);
#nullable restore
#line 61 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
WriteAttributeValue("", 1763, Convert.ToBase64String(post.Image), 1763, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 62 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<p style=\"text-align: start; padding: 20px 0 0 80px\">");
#nullable restore
#line 63 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
                                                                Write(post.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 65 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
                 if (user.Id == _user.GetUserId(User))
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<input type=\"button\" style=\"display:flex\" value=\"Delete\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2000, "\"", 2083, 3);
            WriteAttributeValue("", 2010, "location.href=\'", 2010, 15, true);
#nullable restore
#line 67 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
WriteAttributeValue("", 2025, Url.Action("RemovePost","Profile", new { id = post.Id }), 2025, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2082, "\'", 2082, 1, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n");
#nullable restore
#line 68 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</div>\r\n");
#nullable restore
#line 70 "C:\Users\ASUS\Documents\GitHub\SocialNetwork\Views\Profile\UserProfile.cshtml"
		}
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public PostRepo _post { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> _user { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
