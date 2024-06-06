using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_15_Xml
{
    public class ColumnDefinitions
    {
        [XmlElement("ColumnDefinition")]
        public List<ColumnDefinition> ColumnDefinitionList {  get; set; }
    }
    public class ColumnDefinition { }
}
