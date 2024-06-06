using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_15_Xml
{
    [XmlRoot("Grid")]
    public class Grid
    {
        [XmlAttribute("Background")]
        public string BackGround {  get; set; }
        [XmlElement("Grid.ColumnDefinitions")]
        public ColumnDefinitions ColumnDefinitions {  get; set; }

        [XmlElement("DockPanel")]
        public List<DockPanel> DockPanels {  get; set; }

    }
}
