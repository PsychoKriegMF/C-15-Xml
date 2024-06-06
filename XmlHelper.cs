using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace C_15_Xml
{
    public class XmlHelper
    {
        public static Grid DeserializeXml(string xmlPath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Grid));
            using (StreamReader reader = new StreamReader(xmlPath))
            {
                Grid grid = (Grid)serializer.Deserialize(reader);

                //преобразование строк "True" и "False" в булевы зхначения
                foreach(var dockPanel in grid.DockPanels)
                {
                    if(dockPanel.LastChildFill == "True")
                    {
                        dockPanel.LastChildFill = "true";
                    }
                    else if(dockPanel.LastChildFill == "False")
                    {
                        dockPanel.LastChildFill = "false";
                    }
                }
                return grid;
            }
        }
        public static void SerializeXml(Grid grid, string xmlPath)
        {
            XmlSerializer serializer = new XmlSerializer (typeof(Grid));
            using(StreamWriter writer = new StreamWriter(xmlPath))
            { 
                serializer.Serialize(writer, grid); 
            }
        }

        public static void AddTextBlock(Grid grid, string text, string dock,int fontSize,string horizontalAligement)
        {
            TextBlock newTextBlock = new TextBlock
            {
                Text = text,
                DockPanelDock = dock,
                FontSize = fontSize,
                HorizontalAlignment = horizontalAligement
            };

            DockPanel targetDockPanel = grid.DockPanels[0]; //выбираем первый DockPanel для примера
            targetDockPanel.Elements.Add(newTextBlock);
        }

        public static void AddButton(Grid grid, string text, string dock,  int gridColumn, int maxWidth, int minHeight, string background, string margin, int padding,string click)
        {
            Button newButton = new Button
            {
                Text = text,
                DockPanelDock = dock,
                GridColumn = gridColumn,
                MaxWidth = maxWidth,
                MinHeight = minHeight,
                Background = background,
                Margin = margin,
                Padding = padding,
                Click = click
            };
            DockPanel targetDockPAnel = grid.DockPanels[0];
            targetDockPAnel.Elements.Add(newButton);
        }                          
    }
}
