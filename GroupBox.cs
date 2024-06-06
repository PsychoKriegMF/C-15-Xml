using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_15_Xml
{
    public class GroupBox
    {
        [XmlAttribute("Background")]
        public string Background {  get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("BorderBrush")]
        public string BorderBrush { get; set; }

        [XmlAttribute("BorderThickness")]
        public int BorderThickness { get; set; }
        [XmlElement("StackPanel ")]
        public StackPanel StackPanel {  get; set; }
    }
}
