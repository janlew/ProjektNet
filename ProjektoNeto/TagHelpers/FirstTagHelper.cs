using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace ProjektoNeto.TagHelpers
{
    [HtmlTargetElement("first-tag-helper")]
    public class FirstTagHelper : TagHelper
    {
        public string Name { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "FirstTagHelper";
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            sb.AppendFormat("<h2>Dziękujemy za złożenie opinii!</h2>");

            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}
