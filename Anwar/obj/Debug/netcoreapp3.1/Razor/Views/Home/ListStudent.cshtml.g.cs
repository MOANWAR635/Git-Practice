#pragma checksum "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd49b4f0940785cc9e9a43ad5189fbbbfc1757db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListStudent), @"mvc.1.0.view", @"/Views/Home/ListStudent.cshtml")]
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
#line 1 "G:\PracticeProject\Anwar\Anwar\Views\_ViewImports.cshtml"
using Anwar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\PracticeProject\Anwar\Anwar\Views\_ViewImports.cshtml"
using Anwar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd49b4f0940785cc9e9a43ad5189fbbbfc1757db", @"/Views/Home/ListStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdb6ba86895c3c769b15abfeb4cc101f59e4f6f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Anwar.Models.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p>\r\n");
            WriteLiteral(@"    <button class=""btn btn-primary m-2"" id=""btnStudent"">AddStudent</button>

    <div class=""modal fade modal"" id=""Studentmodel"">

        <div class=""modal-dialog"">
            <div class=""modal-content"">

                <div class=""modal-header"">
                    <h1 class=""text-info modal-title""> AddStudent</h1>
");
            WriteLiteral("                </div>\r\n                <div class=\"modal-body\">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd49b4f0940785cc9e9a43ad5189fbbbfc1757db4907", async() => {
                WriteLiteral(@"

                        <div class=""form-group"">

                            <label>ID</label>
                            <input type=""text"" placeholder=""Enter ID"" class=""form-control"" id=""ID"" autocomplete=""off"" />
                        </div>

                        <div class=""form-group"">

                            <label>FName</label>
                            <input type=""text"" placeholder=""Enter Fname"" class=""form-control"" id=""fName"" autocomplete=""off"" />
                        </div>

                        <div class=""form-group"">

                            <label>LName</label>
                            <input type=""text"" placeholder=""Enter Lname"" class=""form-control"" id=""lName""autocomplete=""off"" />
                        </div>

                        <div class=""form-group"">

                            <label>Email</label>
                            <input type=""text"" placeholder=""Enter Email"" class=""form-control"" id=""Email"" autocomplete=""off"" />
        ");
                WriteLiteral(@"                </div>

                        <div class=""form-group"">

                            <label>Password</label>
                            <input type=""password"" placeholder=""Enter Pass"" class=""form-control"" id=""Pass"" autocomplete=""off""/>
                        </div>

                        <div class=""form-group"">

                            <label>FatherName</label>
                            <input type=""text"" placeholder=""Enter FatherName"" class=""form-control"" id=""fathername"" autocomplete=""off""/>
                        </div>


                        <div class=""form-group"">

                            <label>Address</label>
                            <input type=""text"" placeholder=""Enter FatherName"" class=""form-control"" id=""Address"" autocomplete=""off""/>
                        </div>

                        <div class=""form-group"">

                            <label>Pincode</label>
                            <input type=""text"" placeholder=""Enter Pincode""");
                WriteLiteral(" class=\"form-control\" id=\"pincode\" autocomplete=\"off\"/>\r\n                        </div>\r\n\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                
                <div class=""modal-footer"">

                    <button class=""btn btn-primary"" onclick=""AddStudent()"" id=""AddEmployee"">Save</button>
                    <button class=""btn btn-danger btn-default"" onclick=""hidediv()"" id=""AddEmployees"" >Close</button>
                </div>
            </div>

        </div>

    </div>
</p>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd49b4f0940785cc9e9a43ad5189fbbbfc1757db9077", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd49b4f0940785cc9e9a43ad5189fbbbfc1757db10116", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>

    $('#btnStudent').click(function () {

            $('#Studentmodel').modal('show');
    })


    function AddStudent() {
        debugger
        var StudentObject = {
            ID: $('#ID').val(),
            FName: $('#fName').val(),
            LName: $('#lName').val(),
            Email: $('#Email').val(),
            Pass: $('#Pass').val(),
            Fathername: $('#fathername').val(),
            Address: $('#Address').val(),
            Pincode: $('#pincode').val()
        }
    
    $.ajax({

        url: '/Home/Regstration',
            type: 'Post',
            data: StudentObject,
            //contentType: 'application/json;charset=utf-8',
            //dataType: 'json',
        success: function () {
            alert('Data Save');
            cleartextbox();
            hidediv();
            },
        error: function () {
            alert('Error');
            }

        })
    }


    function cleartextbox()
    {
          $('");
            WriteLiteral(@"#ID').val(''),
             $('#fName').val(''),
           $('#lName').val(''),
             $('#Email').val(''),
            $('#Pass').val(''),
             $('#fathername').val(''),
             $('#Address').val(''),
            $('#pincode').val('')

    }

    

    function hidediv() {
        $('#Studentmodel').modal('hide');
    }
</script>

<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
#nullable restore
#line 152 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 155 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 158 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 161 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 164 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.Passwords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 167 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 170 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 173 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
           Write(Html.DisplayNameFor(model => model.Pincode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 179 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 183 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 186 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.DisplayFor(modelItem => item.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 189 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.DisplayFor(modelItem => item.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 192 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 195 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.DisplayFor(modelItem => item.Passwords));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 198 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.DisplayFor(modelItem => item.FatherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 201 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 204 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pincode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 207 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new {  id=item.ID  }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                    ");
#nullable restore
#line 208 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.ActionLink("Details", "Details", new {  id=item. ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 209 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id=item.ID  }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 212 "G:\PracticeProject\Anwar\Anwar\Views\Home\ListStudent.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Anwar.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
