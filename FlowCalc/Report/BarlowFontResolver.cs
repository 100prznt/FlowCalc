using PdfSharp.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.Report
{
    public class BarlowFontResolver : IFontResolver
    {
        public byte[] GetFont(string faceName)
        {
            switch (faceName)
            {
                case "Barlow-Regular":
                    return Properties.Resources.Barlow_Regular;
                case "Barlow-SemiBold":
                    return Properties.Resources.Barlow_SemiBold;
                case "Barlow-Bold":
                    return Properties.Resources.Barlow_Bold;
                case "Barlow-Italic":
                    return Properties.Resources.Barlow_Italic;
                default:
                    return null;
            }
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (string.Equals(familyName, "Barlow-Regular", StringComparison.OrdinalIgnoreCase) || (string.Equals(familyName, "Barlow", StringComparison.OrdinalIgnoreCase) && !isBold && !isItalic))
                return new FontResolverInfo("Barlow-Regular");
            else if (string.Equals(familyName, "Barlow-SemiBold", StringComparison.OrdinalIgnoreCase))
                return new FontResolverInfo("Barlow-SemiBold");
            else if (string.Equals(familyName, "Barlow-Bold", StringComparison.OrdinalIgnoreCase) || (string.Equals(familyName, "Barlow", StringComparison.OrdinalIgnoreCase) && isBold && !isItalic))
                return new FontResolverInfo("Barlow-Bold");
            else if (string.Equals(familyName, "Barlow-Italic", StringComparison.OrdinalIgnoreCase) || (string.Equals(familyName, "Barlow", StringComparison.OrdinalIgnoreCase) && !isBold && isItalic))
                return new FontResolverInfo("Barlow-Italic");
            else
                return null;
        }
    }
}
