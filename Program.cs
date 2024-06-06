
using System.Xml;

namespace C_15_Xml
{

    
    internal class Program
    {
        static void Main(string[] args)
        {
            string xmlPath = "file.xml";
            Grid grid = XmlHelper.DeserializeXml(xmlPath);

            XmlHelper.AddTextBlock(grid, "Новый текстовый блок", "Top",20, "Center");
            XmlHelper.AddButton(grid, "Новая кнопка", "Buttom", 1, 100, 20, "FF0000", "0 5 0 0", 5, "NewButton_Click");

            XmlHelper.SerializeXml(grid, xmlPath);
            Console.WriteLine("Элементы добавлены и XML файл обновлён.");

            
        }
    }
}
