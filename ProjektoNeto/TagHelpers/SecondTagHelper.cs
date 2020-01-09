using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace ProjektoNeto.TagHelpers
{
    [HtmlTargetElement("second-tag-helper")]
    public class SecondTagHelper : TagHelper
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int RokProdukcji { get; set; }
        public string Przebieg { get; set; }
        public string Pojemnosc { get; set; }
        public string Moc { get; set; }
        public string Opis { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "SecondTagHelper";
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            sb.AppendFormat("<h2>{0} {1}</h2> \n" +
                "<h4>Rok produkcji: {2}</h4> \n" +
                "<h4>Przebieg: {3}</h4> \n" +
                "<h4>Pojemność: {4}</h4> \n" +
                "<h4>Moc: {5}</h4> \n" +
                "<p>Opis: {6}</p>", Marka, Model, RokProdukcji, Przebieg, Pojemnosc, Moc, Opis);

            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}
