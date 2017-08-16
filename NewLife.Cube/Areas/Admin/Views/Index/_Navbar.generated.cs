﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 1 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    
    #line 2 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/_Navbar.cshtml")]
    public partial class _Areas_Admin_Views_Index__Navbar_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index__Navbar_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;
    var uid = 0;
    if (user != null) { uid = user.ID; }
    var cfg = ViewBag.Config as SysConfig;
    var name = cfg == null ? "" : cfg.DisplayName;

            
            #line default
            #line hidden
WriteLiteral("\r\n<!-- #section:basics/navbar.layout -->\r\n<div");

WriteLiteral(" id=\"navbar\"");

WriteLiteral(" class=\"navbar navbar-default\"");

WriteLiteral(">\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        try { ace.settings.check(\'navbar\', \'fixed\') } catch (e) { }\r\n    </scr" +
"ipt>\r\n\r\n    <div");

WriteLiteral(" class=\"navbar-container\"");

WriteLiteral(" id=\"navbar-container\"");

WriteLiteral(">\r\n        <!-- #section:basics/sidebar.mobile.toggle -->\r\n        <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"navbar-toggle menu-toggler pull-left\"");

WriteLiteral(" id=\"menu-toggler\"");

WriteLiteral(" data-target=\"#sidebar\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">Toggle sidebar</span>\r\n            <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n            <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n            <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\r\n        </button>\r\n\r\n        <!-- /section:basics/sidebar.mobile.toggle" +
" -->\r\n        <div");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">\r\n            <!-- #section:basics/navbar.layout.brand -->\r\n            <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"navbar-brand\"");

WriteLiteral(">\r\n                <small>\r\n");

WriteLiteral("                    ");

            
            #line 30 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
               Write(name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </small>\r\n            </a>\r\n        </div>\r\n\r\n        <!-- #sec" +
"tion:basics/navbar.dropdown -->\r\n        <div");

WriteLiteral(" class=\"navbar-buttons navbar-header pull-right\"");

WriteLiteral(" role=\"navigation\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"nav ace-nav\"");

WriteLiteral(">\r\n                <!-- #section:basics/navbar.user_menu -->\r\n                <li" +
"");

WriteLiteral(" class=\"light-blue\"");

WriteLiteral(">\r\n                    <a");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteAttribute("href", Tuple.Create(" href=\"", 1554), Tuple.Create("\"", 1583)
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create<System.Object, System.Int32>(Href("~/Admin/User/Info/")
, 1561), false)
            
            #line 40 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
, Tuple.Create(Tuple.Create("", 1579), Tuple.Create<System.Object, System.Int32>(uid
            
            #line default
            #line hidden
, 1579), false)
);

WriteLiteral(" class=\"dropdown-toggle\"");

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                        ");

WriteLiteral("\r\n                        <span");

WriteLiteral(" class=\"user-info\"");

WriteLiteral(">\r\n                            ");

WriteLiteral("\r\n");

WriteLiteral("                            ");

            
            #line 44 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
                       Write(user);

            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("\r\n                        </span>\r\n\r\n                        <i");

WriteLiteral(" class=\"ace-icon fa fa-caret-down\"");

WriteLiteral("></i>\r\n                    </a>\r\n\r\n                    <ul");

WriteLiteral(" class=\"user-menu dropdown-menu-right dropdown-menu dropdown-yellow dropdown-care" +
"t dropdown-close\"");

WriteLiteral(">\r\n                        <li>\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2220), Tuple.Create("\"", 2229)
, Tuple.Create(Tuple.Create("", 2227), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 2227), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"ace-icon fa fa-cog\"");

WriteLiteral("></i>\r\n                                网站首页\r\n                            </a>\r\n  " +
"                      </li>\r\n\r\n");

            
            #line 58 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 58 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
                         if (user.Has("Admin/Sys", PermissionFlags.Detail))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2594), Tuple.Create("\"", 2612)
, Tuple.Create(Tuple.Create("", 2601), Tuple.Create<System.Object, System.Int32>(Href("~/Admin/Sys")
, 2601), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                                    <i");

WriteLiteral(" class=\"ace-icon fa fa-cog\"");

WriteLiteral("></i>\r\n                                    设置\r\n                                </" +
"a>\r\n                            </li>\r\n");

            
            #line 66 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n                        <li>\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2904), Tuple.Create("\"", 2933)
, Tuple.Create(Tuple.Create("", 2911), Tuple.Create<System.Object, System.Int32>(Href("~/Admin/User/Info/")
, 2911), false)
            
            #line 69 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
, Tuple.Create(Tuple.Create("", 2929), Tuple.Create<System.Object, System.Int32>(uid
            
            #line default
            #line hidden
, 2929), false)
);

WriteLiteral(" target=\"main\"");

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"ace-icon fa fa-user\"");

WriteLiteral("></i>\r\n                                个人信息\r\n                            </a>\r\n  " +
"                      </li>\r\n\r\n                        <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n\r\n                        <li>\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3238), Tuple.Create("\"", 3264)
, Tuple.Create(Tuple.Create("", 3245), Tuple.Create<System.Object, System.Int32>(Href("~/Admin/User/Logout")
, 3245), false)
);

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"ace-icon fa fa-power-off\"");

WriteLiteral(@"></i>
                                注销
                            </a>
                        </li>
                    </ul>
                </li>

                <!-- /section:basics/navbar.user_menu -->
            </ul>
        </div>

        <!-- /section:basics/navbar.dropdown -->
    </div>
    <!-- /.navbar-container -->
</div>
<!-- /section:basics/navbar.layout -->");

        }
    }
}
#pragma warning restore 1591
