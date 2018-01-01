using System.Xml.Linq;

namespace DFe.Print.Core
{
    public interface IHtmlRawGenerator
    {
        XElement GetHeader(NFe data);
        XElement GetContent(NFe data);
        XElement GetFooter(NFe data);
        XDocument ToHtml(NFe data);
    }
}
