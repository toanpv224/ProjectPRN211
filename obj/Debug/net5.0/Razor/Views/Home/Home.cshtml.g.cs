#pragma checksum "D:\Study\Sum22\PRN291\ProjectPRN211\ProjectPRN211\Views\Home\Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5de9d84b157b31b2a4301af0b6572f4c6722e0a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5de9d84b157b31b2a4301af0b6572f4c6722e0a6", @"/Views/Home/Home.cshtml")]
    #nullable restore
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de9d84b157b31b2a4301af0b6572f4c6722e0a62731", async() => {
                WriteLiteral("\r\n    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">\r\n    <title>JSP Page</title>\r\n    <style>\r\n        ");
                WriteLiteral(@"@import url(""https://fonts.googleapis.com/css2?family=Poppins:wght@200;300;400;500;600;700;800&display=swap"");

        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body,
        input {
            font-family: ""Poppins"", sans-serif;
        }

        .container {
            position: relative;
            width: 100%;
            background-color: #fff;
            min-height: 100vh;
            overflow: hidden;
        }

        .forms-container {
            position: absolute;
            width: 100%;
            height: 100%;
            top: 0;
            left: 0;
        }

        .signin-signup {
            position: absolute;
            top: 50%;
            transform: translate(-50%, -50%);
            left: 75%;
            width: 50%;
            transition: 1s 0.7s ease-in-out;
            display: grid;
            grid-template-columns: 1fr;
            z-index: 5;
        }

        f");
                WriteLiteral(@"orm {
            display: flex;
            align-items: center;
            justify-content: center;
            flex-direction: column;
            padding: 0rem 5rem;
            transition: all 0.2s 0.7s;
            display: hidden;
            grid-column: 1 / 2;
            grid-row: 1 / 2;
        }
        
            form.sign-up-form {
                opacity: 0;
                z-index: 1;
            }

            form.sign-in-form {
                z-index: 2;
            }

        .title {
            font-size: 2.2rem;
            color: #444;
            margin-bottom: 10px;
        }

        .input-field {
            max-width: 380px;
            width: 100%;
            background-color: #f0f0f0;
            margin: 10px 0;
            height: 55px;
            border-radius: 55px;
            display: grid;
            grid-template-columns: 15% 85%;
            padding: 0 0.4rem;
            position: relative;
        }

            .input-fi");
                WriteLiteral(@"eld i {
                text-align: center;
                line-height: 55px;
                color: #acacac;
                transition: 0.5s;
                font-size: 1.1rem;
            }

            .input-field input {
                background: none;
                outline: none;
                border: none;
                line-height: 1;
                font-weight: 600;
                font-size: 1.1rem;
                color: #333;
            }

                .input-field input::placeholder {
                    color: #aaa;
                    font-weight: 500;
                }

        .social-text {
            padding: 0.7rem 0;
            font-size: 1rem;
        }

        .social-media {
            display: flex;
            justify-content: center;
        }

        .social-icon {
            height: 46px;
            width: 46px;
            display: flex;
            justify-content: center;
            align-items: center;
            m");
                WriteLiteral(@"argin: 0 0.45rem;
            color: #333;
            border-radius: 50%;
            border: 1px solid #333;
            text-decoration: none;
            font-size: 1.1rem;
            transition: 0.3s;
        }

            .social-icon:hover {
                color: #4481eb;
                border-color: #4481eb;
            }

        .btn {
            width: 150px;
            background-color: #5995fd;
            border: none;
            outline: none;
            height: 49px;
            border-radius: 49px;
            color: #fff;
            text-transform: uppercase;
            font-weight: 600;
            margin: 10px 0;
            cursor: pointer;
            transition: 0.5s;
        }

            .btn:hover {
                background-color: #4d84e2;
            }

        .panels-container {
            position: absolute;
            height: 100%;
            width: 100%;
            top: 0;
            left: 0;
            display: grid;
 ");
                WriteLiteral(@"           grid-template-columns: repeat(2, 1fr);
        }

        .container:before {
            content: """";
            position: absolute;
            height: 2000px;
            width: 2000px;
            top: -10%;
            right: 48%;
            transform: translateY(-50%);
            background-image: linear-gradient(-45deg, #4481eb 0%, #04befe 100%);
            transition: 1.8s ease-in-out;
            border-radius: 50%;
            z-index: 6;
        }

        .image {
            width: 100%;
            transition: transform 1.1s ease-in-out;
            transition-delay: 0.4s;
        }

        .panel {
            display: flex;
            flex-direction: column;
            align-items: flex-end;
            justify-content: space-around;
            text-align: center;
            z-index: 6;
        }

        .left-panel {
            pointer-events: all;
            padding: 3rem 17% 2rem 12%;
        }

        .right-panel {
            ");
                WriteLiteral(@"pointer-events: none;
            padding: 3rem 12% 2rem 17%;
        }

        .panel .content {
            color: #fff;
            transition: transform 0.9s ease-in-out;
            transition-delay: 0.6s;
        }

        .panel h3 {
            font-weight: 600;
            line-height: 1;
            font-size: 1.5rem;
        }

        .panel p {
            font-size: 0.95rem;
            padding: 0.7rem 0;
        }

        .btn.transparent {
            margin: 0;
            background: none;
            border: 2px solid #fff;
            width: 130px;
            height: 41px;
            font-weight: 600;
            font-size: 0.8rem;
        }

        .right-panel .image,
        .right-panel .content {
            transform: translateX(800px);
        }

        /* ANIMATION */

        .container.sign-up-mode:before {
            transform: translate(100%, -50%);
            right: 52%;
        }

        .container.sign-up-mode .left-panel ");
                WriteLiteral(@".image,
        .container.sign-up-mode .left-panel .content {
            transform: translateX(-800px);
        }

        .container.sign-up-mode .signin-signup {
            left: 25%;
        }

        .container.sign-up-mode form.sign-up-form {
            opacity: 1;
            z-index: 2;
        }

        .container.sign-up-mode form.sign-in-form {
            opacity: 0;
            z-index: 1;
        }

        .container.sign-up-mode .right-panel .image,
        .container.sign-up-mode .right-panel .content {
            transform: translateX(0%);
        }

        .container.sign-up-mode .left-panel {
            pointer-events: none;
        }

        .container.sign-up-mode .right-panel {
            pointer-events: all;
        }

        ");
                WriteLiteral(@"@media (max-width: 870px) {
            .container {
                min-height: 800px;
                height: 100vh;
            }

            .signin-signup {
                width: 100%;
                top: 95%;
                transform: translate(-50%, -100%);
                transition: 1s 0.8s ease-in-out;
            }

            .signin-signup,
            .container.sign-up-mode .signin-signup {
                left: 50%;
            }

            .panels-container {
                grid-template-columns: 1fr;
                grid-template-rows: 1fr 2fr 1fr;
            }

            .panel {
                flex-direction: row;
                justify-content: space-around;
                align-items: center;
                padding: 2.5rem 8%;
                grid-column: 1 / 2;
            }

            .right-panel {
                grid-row: 3 / 4;
            }

            .left-panel {
                grid-row: 1 / 2;
            }

           ");
                WriteLiteral(@" .image {
                width: 200px;
                transition: transform 0.9s ease-in-out;
                transition-delay: 0.6s;
            }

            .panel .content {
                padding-right: 15%;
                transition: transform 0.9s ease-in-out;
                transition-delay: 0.8s;
            }

            .panel h3 {
                font-size: 1.2rem;
            }

            .panel p {
                font-size: 0.7rem;
                padding: 0.5rem 0;
            }

            .btn.transparent {
                width: 110px;
                height: 35px;
                font-size: 0.7rem;
            }

            .container:before {
                width: 1500px;
                height: 1500px;
                transform: translateX(-50%);
                left: 30%;
                bottom: 68%;
                right: initial;
                top: initial;
                transition: 2s ease-in-out;
            }

            .conta");
                WriteLiteral(@"iner.sign-up-mode:before {
                transform: translate(-50%, 100%);
                bottom: 32%;
                right: initial;
            }

            .container.sign-up-mode .left-panel .image,
            .container.sign-up-mode .left-panel .content {
                transform: translateY(-300px);
            }

            .container.sign-up-mode .right-panel .image,
            .container.sign-up-mode .right-panel .content {
                transform: translateY(0px);
            }

            .right-panel .image,
            .right-panel .content {
                transform: translateY(300px);
            }

            .container.sign-up-mode .signin-signup {
                top: 5%;
                transform: translate(-50%, 0);
            }
        }

        ");
                WriteLiteral(@"@media (max-width: 570px) {
            form {
                padding: 0 1.5rem;
            }

            .image {
                display: none;
            }

            .panel .content {
                padding: 0.5rem 1rem;
            }

            .container {
                padding: 1.5rem;
            }

                .container:before {
                    bottom: 72%;
                    left: 50%;
                }

                .container.sign-up-mode:before {
                    bottom: 28%;
                    left: 50%;
                }
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de9d84b157b31b2a4301af0b6572f4c6722e0a614669", async() => {
                WriteLiteral(@"

    <div class=""container"">
        <div class=""forms-container"">
            <div class=""signin-signup"">
                <form action=""Home/Signin"" class=""sign-in-form"">
                    <h1 class=""title"">Chat App</h1>
                    <h2 class=""title"">Sign in</h2>
                    <div class=""input-field"">
                        <i class=""fas fa-user""></i>
                        <input type=""text""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 11024, "\"", 11087, 1);
#nullable restore
#line 424 "D:\Study\Sum22\PRN291\ProjectPRN211\ProjectPRN211\Views\Home\Home.cshtml"
WriteAttributeValue("", 11038, ViewBag.User != null?"ViewBag.User":"UserName", 11038, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"user\"");
                BeginWriteAttribute("value", " value=\"", 11100, "\"", 11121, 1);
#nullable restore
#line 424 "D:\Study\Sum22\PRN291\ProjectPRN211\ProjectPRN211\Views\Home\Home.cshtml"
WriteAttributeValue("", 11108, ViewBag.User, 11108, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                    </div>\r\n                    <div class=\"input-field\">\r\n                        <i class=\"fas fa-lock\"></i>\r\n                        <input type=\"password\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 11300, "\"", 11364, 1);
#nullable restore
#line 428 "D:\Study\Sum22\PRN291\ProjectPRN211\ProjectPRN211\Views\Home\Home.cshtml"
WriteAttributeValue("", 11314, ViewBag.Pass != null?"@ViewBag.Pass":"Password", 11314, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"pass\"");
                BeginWriteAttribute("value", " value=\"", 11377, "\"", 11398, 1);
#nullable restore
#line 428 "D:\Study\Sum22\PRN291\ProjectPRN211\ProjectPRN211\Views\Home\Home.cshtml"
WriteAttributeValue("", 11385, ViewBag.Pass, 11385, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
                    </div>
                    <div class=""remember-checkbox"">
                        <label for=""remember"">Remember</label><br>
                        <input type=""checkbox"" id=""remember"" name=""remember"" value=""1""/>
                    </div>
                    <input type=""submit"" value=""Login"" class=""btn solid"" />
                </form>
                <form action=""Home/Signup"" class=""sign-up-form"">
                    <h1 class=""title"">Chat App</h1>
                    <h2 class=""title"">Sign up</h2>
                    <div class=""input-field"">
                        <i class=""fas fa-user""></i>
                        <input type=""text"" placeholder=""Username"" name=""user""/>
                    </div>
                    <div class=""input-field"">
                        <i class=""fas fa-envelope""></i>
                        <input type=""password"" placeholder=""Password"" name=""pass""/>
                    </div>
                    <div class=""input-field"">
       ");
                WriteLiteral(@"                 <i class=""fas fa-lock""></i>
                        <input type=""password"" placeholder=""RePassword"" name=""repass""/>
                    </div>
                    <input type=""submit"" class=""btn"" value=""Sign up"" />
                </form>
            </div>
        </div>

        <div class=""panels-container"">
            <div class=""panel left-panel"">
                <div class=""content"">
                    <h3>Not have an account ?</h3>
                    <p>
                        Go to Sign up
                    </p>
                    <button class=""btn transparent"" id=""sign-up-btn"">
                        Sign up
                    </button>
                </div>
            </div>
            <div class=""panel right-panel"">
                <div class=""content"">
                    <h3>Already have an account ?</h3>
                    <p>
                        Go lo Sign in
                    </p>
                    <button class=""btn transparent""");
                WriteLiteral(@" id=""sign-in-btn"">
                        Sign in
                    </button>
                </div>
            </div>
        </div>
    </div>

    <script>
        const sign_in_btn = document.querySelector(""#sign-in-btn"");
        const sign_up_btn = document.querySelector(""#sign-up-btn"");
        const container = document.querySelector("".container"");

        sign_up_btn.addEventListener(""click"", () => {
            container.classList.add(""sign-up-mode"");
        });

        sign_in_btn.addEventListener(""click"", () => {
            container.classList.remove(""sign-up-mode"");
        });
    </script>
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
