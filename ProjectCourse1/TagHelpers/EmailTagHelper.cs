using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ProjectCourse1.TagHelpers
{
    public class EmailTagHelper : TagHelper // <email>
    {
        public string? Address { get; set; }
        public string? Content { get; set; }
        public  void Process (TagHelperContent context, TagHelperOutput output )
        {

            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            output.Content.SetContent(Content);
        }
    }
}
