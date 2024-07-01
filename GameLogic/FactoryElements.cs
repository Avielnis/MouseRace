using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameLogic
{
    public class FactoryElements
    {
        public static List<Element> Create_v1(out int totalToCollect)
        {

            Random random = new Random();

            int numCollect = random.Next(Config.MIN_ELEMENTS_EACH, Config.MAX_ELEMENTS_EACH);
            int numAvoid = random.Next(Config.MIN_ELEMENTS_EACH, Config.MAX_ELEMENTS_EACH);
            int numChange = random.Next(Config.MIN_ELEMENTS_EACH, Config.MAX_ELEMENTS_EACH);

            List<Element> elements = new List<Element>();
            int i = 0;
            while (i < numCollect || i < numAvoid || i < numChange)
            {
                if (i < numCollect)
                {
                    elements.Add(new CollectType());
                }
                if (i < numAvoid)
                {
                    elements.Add(new AvoidType());
                }
                if (i < numChange)
                {
                    elements.Add(new ChangeType());
                }
                i++;
            }
            totalToCollect = numCollect + numChange;
            return elements;
        }

        public static List<Element> Create(out int totalToCollect)
        {
            JsonHandler jsonHandler = new JsonHandler(Config.JSON_FILE_PATH);
            List<ElementJsonData> data = jsonHandler.LoadJsonData();

            totalToCollect = 0;
            List<Element> elements = new List<Element>();
            foreach (ElementJsonData dataItem in data)
            {
                Element element = null;
                if (dataItem.Type == "Avoid")
                {
                    element = new AvoidType();
                }
                if (dataItem.Type == "Collect")
                {
                    element= new CollectType();
                    totalToCollect++;
                }
                if (dataItem.Type == "Change")
                {
                    element = new ChangeType();
                    totalToCollect++;
                }

                if(element== null)
                {
                    continue;
                }

                element.setSize(dataItem.Size*2);
                element.setSpeed((int)(dataItem.Speed * 10));
                elements.Add(element);
            }
            return elements;
        }
    }
}
