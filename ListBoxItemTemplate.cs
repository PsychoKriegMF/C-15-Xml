﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_15_Xml
{
    public class ListBoxItemTemplate
    {
        [XmlElement("DataTemplate")]
        public DataTemplate DataTemplate {  get; set; }

    }
}
