using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseManager.Components
{
    internal class Fonts
    {
        public FontFamily OverpassReg { get; private set; }
        public Fonts()
        {
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile(@"Fonts\overpass-reg.ttf");
            OverpassReg = fontCollection.Families[fontCollection.Families.Length - 1];

        }
    }
}
