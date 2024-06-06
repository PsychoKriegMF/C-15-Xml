using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_15_Xml
{
    public class Button
    {
        [XmlAttribute("DockPanel.Dock")]
        public string DockPanelDock {  get; set; }

        [XmlAttribute("Grid.Column")]
        public int GridColumn {  get; set; }

        [XmlAttribute("MaxWidth")]
        public int MaxWidth { get; set; }

        [XmlAttribute("MinHeight")]
        public int MinHeight { get; set; }

        [XmlAttribute("Background")]
        public string Background {  get; set; }

        [XmlAttribute("Margin")]
        public string Margin { get; set; }

        [XmlAttribute("Padding")]
        public int Padding {  get; set; }

        [XmlAttribute("Click")]
        public string Click {  get; set; }

        [XmlText]
        public string Text {  get; set; }

    }
}
