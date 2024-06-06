using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_15_Xml
{
    public class StackPanel
    {
        [XmlElement("TextBlock", typeof(TextBlock))]
        public List<TextBlock> TextBlocks { get; set; }
    }
}
