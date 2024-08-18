using C_15_Xml;
using System.Xml.Linq;

namespace HomeWork_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xmlPath = "XML.xml";
            Grid grid = XmlHelper.DeserializeXml("File.xml");
            XmlHelper xmlHelper = new XmlHelper();
            XmlHelper.AddButton(grid, "Обновить", "Новая", 15, 50, 5, "Чёрный", "08500", "5", "Не понятно что");
            XmlHelper.AddTextBlock(grid, "Новый текстовый блок", "Топ", 20, "Center");
            XmlHelper.SerializeXml(grid, xmlPath);
            Console.WriteLine("Элементы добавлены и XML файл обновлён");

            // Добавляем новый GroupBox в DockPanel            
            Console.WriteLine("\nДобавление нового GroupBox в DockPanel");
            XmlHelper.AddElement(new GroupBox
            {
                Background = "Цвет фона",
                Name = "Имя атрибута",
                BorderBrush = "Заливка границы",
                BorderThickness = "Толщина границы",
                StackPanel = new StackPanel
                {
                    TextBlocks = new List<TextBlock>
                    {
                        new TextBlock{ DockPanelDock = "Низ", FontSize = 46, HorizontalAlignment = "Центр", Text = "Список всего"},
                        new TextBlock{ DockPanelDock = "Середина", FontSize = 37, HorizontalAlignment = "Смещение вверх", Text = "Новое"},
                        new TextBlock{ DockPanelDock = "Верх", FontSize = 28, HorizontalAlignment = "Смещение вниз", Text = "Старое"}
                    }
                }
            }, grid);
            XmlHelper.SerializeXml(grid, xmlPath);
            Console.WriteLine("Элементы добавлены и XML файл обновлён");
            // Добавляем новый ListBox в DockPanel            
            Console.WriteLine("\nДобавление нового ListBox в DockPanel");
            XmlHelper.AddElement(new ListBox
            {
                Background = "Серо-буро-малиновый",
                GridColumnSpan = 10,
                Name = "Лист того, что надо сделать",
                ListBoxItemTemplate = new ListBoxItemTemplate
                {
                    DataTemplate = new DataTemplate
                    {
                        StackPanel = new StackPanel
                        {
                            TextBlocks = new List<TextBlock>
                           {
                               new TextBlock{ DockPanelDock = "Право", FontSize = 46, HorizontalAlignment = "Центр", Text = "Список всего"},
                               new TextBlock{ DockPanelDock = "Середина", FontSize = 37, HorizontalAlignment = "Смещение вверх", Text = "Новое"},
                               new TextBlock{ DockPanelDock = "Лево", FontSize = 28, HorizontalAlignment = "Смещение вниз", Text = "Старое"}
                           }
                        }
                    }
                }
            }, grid);
            XmlHelper.SerializeXml(grid, xmlPath);
            Console.WriteLine("Элементы добавлены и XML файл обновлён");
        }
    }
}