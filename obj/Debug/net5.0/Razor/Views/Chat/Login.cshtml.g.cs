#pragma checksum "D:\Study\Sum22\PRN291\ProjectPRN211\ProjectPRN211\Views\Chat\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78a522219d95ba9d3fe2af427c2a4bc9e7128da5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Login), @"mvc.1.0.view", @"/Views/Chat/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a522219d95ba9d3fe2af427c2a4bc9e7128da5", @"/Views/Chat/Login.cshtml")]
    #nullable restore
    public class Views_Chat_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
            WriteLiteral("\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78a522219d95ba9d3fe2af427c2a4bc9e7128da52736", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"">
    <title>JSP Page</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    <style>
        /* Please ❤ this if you like it! */

        ");
                WriteLiteral(@"@import url(""https://fonts.googleapis.com/css?family=Poppins:400,500,600,700,800,900"");

        body {
            font-family: ""Poppins"", sans-serif;
            font-weight: 300;
            font-size: 15px;
            line-height: 1.7;
            color: #c4c3ca;
            background-color: #e3e3e3;
            overflow-x: hidden;
        }

        a {
            cursor: pointer;
            transition: all 200ms linear;
        }

            a:hover {
                text-decoration: none;
            }

        .link {
            color: #c4c3ca;
        }

            .link:hover {
                color: #ffeba7;
            }

        p {
            font-weight: 500;
            font-size: 14px;
            line-height: 1.7;
        }

        h4 {
            font-weight: 600;
        }

        h6 span {
            padding: 0 20px;
            text-transform: uppercase;
            font-weight: 700;
        }

        .section {
            posit");
                WriteLiteral(@"ion: relative;
            width: 100%;
            display: block;
        }

        .full-height {
            min-height: 100vh;
        }

        [type=""checkbox""]:checked,
        [type=""checkbox""]:not(:checked) {
            position: absolute;
            left: -9999px;
        }

        .checkbox:checked + label,
        .checkbox:not(:checked) + label {
            position: relative;
            display: block;
            text-align: center;
            width: 60px;
            height: 16px;
            border-radius: 8px;
            padding: 0;
            margin: 10px auto;
            cursor: pointer;
            background-color: #ffeba7;
        }

            .checkbox:checked + label:before,
            .checkbox:not(:checked) + label:before {
                position: absolute;
                display: block;
                width: 36px;
                height: 36px;
                border-radius: 50%;
                color: #ffeba7;
                ");
                WriteLiteral(@"background-color: #102770;
                font-family: ""unicons"";
                content: ""\eb4f"";
                z-index: 20;
                top: -10px;
                left: -10px;
                line-height: 36px;
                text-align: center;
                font-size: 24px;
                transition: all 0.5s ease;
            }

            .checkbox:checked + label:before {
                transform: translateX(44px) rotate(-270deg);
            }

        .card-3d-wrap {
            position: relative;
            width: 440px;
            max-width: 100%;
            height: 400px;
            -webkit-transform-style: preserve-3d;
            transform-style: preserve-3d;
            perspective: 800px;
            margin-top: 60px;
        }

        .card-3d-wrapper {
            width: 100%;
            height: 100%;
            position: absolute;
            top: 0;
            left: 0;
            -webkit-transform-style: preserve-3d;
            tr");
                WriteLiteral(@"ansform-style: preserve-3d;
            transition: all 600ms ease-out;
        }

        .card-front,
        .card-back {
            width: 100%;
            height: 100%;
            background-color: #2a2b38;
            background-image: url(""https://s3-us-west-2.amazonaws.com/s.cdpn.io/1462889/pat.svg"");
            background-position: bottom center;
            background-repeat: no-repeat;
            background-size: 300%;
            position: absolute;
            border-radius: 6px;
            left: 0;
            top: 0;
            -webkit-transform-style: preserve-3d;
            transform-style: preserve-3d;
            -webkit-backface-visibility: hidden;
            -moz-backface-visibility: hidden;
            -o-backface-visibility: hidden;
            backface-visibility: hidden;
        }

        .card-back {
            transform: rotateY(180deg);
        }

        .checkbox:checked ~ .card-3d-wrap .card-3d-wrapper {
            transform: rotateY(180");
                WriteLiteral(@"deg);
        }

        .center-wrap {
            position: absolute;
            width: 100%;
            padding: 0 35px;
            top: 50%;
            left: 0;
            transform: translate3d(0, -50%, 35px) perspective(100px);
            z-index: 20;
            display: block;
        }

        .form-group {
            position: relative;
            display: block;
            margin: 0;
            padding: 0;
        }

        .form-style {
            padding: 13px 20px;
            padding-left: 55px;
            height: 48px;
            width: 100%;
            font-weight: 500;
            border-radius: 4px;
            font-size: 14px;
            line-height: 22px;
            letter-spacing: 0.5px;
            outline: none;
            color: #c4c3ca;
            background-color: #1f2029;
            border: none;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
            box-shadow: 0 4px 8px 0 rg");
                WriteLiteral(@"ba(21, 21, 21, 0.2);
        }

            .form-style:focus,
            .form-style:active {
                border: none;
                outline: none;
                box-shadow: 0 4px 8px 0 rgba(21, 21, 21, 0.2);
            }

        .input-icon {
            position: absolute;
            top: 0;
            left: 18px;
            height: 48px;
            font-size: 24px;
            line-height: 48px;
            text-align: left;
            color: #ffeba7;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
        }

        .form-group input:-ms-input-placeholder {
            color: #c4c3ca;
            opacity: 0.7;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
        }

        .form-group input::-moz-placeholder {
            color: #c4c3ca;
            opacity: 0.7;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
        }");
                WriteLiteral(@"

        .form-group input:-moz-placeholder {
            color: #c4c3ca;
            opacity: 0.7;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
        }

        .form-group input::-webkit-input-placeholder {
            color: #c4c3ca;
            opacity: 0.7;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
        }

        .form-group input:focus:-ms-input-placeholder {
            opacity: 0;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
        }

        .form-group input:focus::-moz-placeholder {
            opacity: 0;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
        }

        .form-group input:focus:-moz-placeholder {
            opacity: 0;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
        }

        .form-group input:focus::-w");
                WriteLiteral(@"ebkit-input-placeholder {
            opacity: 0;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
        }

        .btn {
            border-radius: 4px;
            height: 44px;
            font-size: 13px;
            font-weight: 600;
            text-transform: uppercase;
            -webkit-transition: all 200ms linear;
            transition: all 200ms linear;
            padding: 0 30px;
            letter-spacing: 1px;
            display: -webkit-inline-flex;
            display: -ms-inline-flexbox;
            display: inline-flex;
            -webkit-align-items: center;
            -moz-align-items: center;
            -ms-align-items: center;
            align-items: center;
            -webkit-justify-content: center;
            -moz-justify-content: center;
            -ms-justify-content: center;
            justify-content: center;
            -ms-flex-pack: center;
            text-align: center;
            border:");
                WriteLiteral(@" none;
            background-color: #ffeba7;
            color: #102770;
            box-shadow: 0 8px 24px 0 rgba(255, 235, 167, 0.2);
        }

            .btn:active,
            .btn:focus {
                background-color: #102770;
                color: #ffeba7;
                box-shadow: 0 8px 24px 0 rgba(16, 39, 112, 0.2);
            }

            .btn:hover {
                background-color: #102770;
                color: #ffeba7;
                box-shadow: 0 8px 24px 0 rgba(16, 39, 112, 0.2);
            }

        .logo {
            position: absolute;
            top: 30px;
            right: 30px;
            display: block;
            z-index: 100;
            transition: all 250ms linear;
        }

            .logo img {
                height: 26px;
                width: auto;
                display: block;
            }

    </style>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78a522219d95ba9d3fe2af427c2a4bc9e7128da513549", async() => {
                WriteLiteral(@"
    <div class=""section"">
        <div class=""container"">
            <div class=""row full-height justify-content-center"">
                <div class=""col-12 text-center align-self-center py-5"">
                    <div class=""section pb-5 pt-5 pt-sm-2 text-center"">
                        <h6 class=""mb-0 pb-3""><span>Log In </span><span>Sign Up</span></h6>
                        <input class=""checkbox"" type=""checkbox"" id=""reg-log"" name=""reg-log"" />
                        <label for=""reg-log""></label>
                        <div class=""card-3d-wrap mx-auto"">
                            <div class=""card-3d-wrapper"">
                                <div class=""card-front"">
                                    <div class=""center-wrap"">
                                        <div class=""section text-center"">
                                            <h4 class=""mb-4 pb-3"">Log In</h4>
                                            <div class=""form-group"">
                                          ");
                WriteLiteral(@"      <input type=""email"" name=""logemail"" class=""form-style"" placeholder=""Your Email"" id=""logemail"" autocomplete=""off"">
                                                <i class=""input-icon uil uil-at""></i>
                                            </div>
                                            <div class=""form-group mt-2"">
                                                <input type=""password"" name=""logpass"" class=""form-style"" placeholder=""Your Password"" id=""logpass"" autocomplete=""off"">
                                                <i class=""input-icon uil uil-lock-alt""></i>
                                            </div>
                                            <a href=""#"" class=""btn mt-4"">submit</a>
                                            <p class=""mb-0 mt-4 text-center""><a href=""#0"" class=""link"">Forgot your password?</a></p>
                                        </div>
                                    </div>
                                </div>
                          ");
                WriteLiteral(@"      <div class=""card-back"">
                                    <div class=""center-wrap"">
                                        <div class=""section text-center"">
                                            <h4 class=""mb-4 pb-3"">Sign Up</h4>
                                            <div class=""form-group"">
                                                <input type=""text"" name=""logname"" class=""form-style"" placeholder=""Your Full Name"" id=""logname"" autocomplete=""off"">
                                                <i class=""input-icon uil uil-user""></i>
                                            </div>
                                            <div class=""form-group mt-2"">
                                                <input type=""email"" name=""logemail"" class=""form-style"" placeholder=""Your Email"" id=""logemail"" autocomplete=""off"">
                                                <i class=""input-icon uil uil-at""></i>
                                            </div>
                       ");
                WriteLiteral(@"                     <div class=""form-group mt-2"">
                                                <input type=""password"" name=""logpass"" class=""form-style"" placeholder=""Your Password"" id=""logpass"" autocomplete=""off"">
                                                <i class=""input-icon uil uil-lock-alt""></i>
                                            </div>
                                            <a href=""#"" class=""btn mt-4"">submit</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2"" crossorigin=""anonymous""></script>
");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
