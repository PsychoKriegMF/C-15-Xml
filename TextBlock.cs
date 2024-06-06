using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_15_Xml
{
    public class TextBlock
    {
        [XmlAttribute("DockPanel.Dock")]
        public string DockPanelDock {  get; set; }

        [XmlAttribute("FontSize")]
        public int FontSize { get; set; }

        [XmlAttribute("HorizontalAlignment")]
        public string HorizontalAlignment { get; set; }

        [XmlText]
        public string Text {  get; set; }

    }
}
