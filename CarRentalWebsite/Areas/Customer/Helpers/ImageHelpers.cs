using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;

namespace CarRentalWebsite.Areas.Customer.Helpers
{
    public static class ImageHelpers
    {
        public static IHtmlContent ImageWithSize(this IHtmlHelper htmlHelper, string imagePath, int width = 398, int height = 246, string alt = "Image")
        {
            var imgTag = new TagBuilder("img");
            imgTag.Attributes["src"] = imagePath;
            imgTag.Attributes["alt"] = alt;
            imgTag.Attributes["width"] = width.ToString();
            imgTag.Attributes["height"] = height.ToString();

            using (var writer = new StringWriter())
            {
                imgTag.WriteTo(writer, HtmlEncoder.Default);
                return new HtmlString(writer.ToString());
            }
        }
    }
}