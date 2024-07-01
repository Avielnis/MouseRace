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
        public static List<Element> Create(out int totalToCollect)
        {

            Random random = new Random();

            int numCollect = random.Next(Config.MIN_ELEMENTS_EACH, Config.MAX_ELEMENTS_EACH);
            int numAvoid = random.Next(Config.MIN_ELEMENTS_EACH, Config.MAX_ELEMENTS_EACH);
            int numChange = random.Next(Config.MIN_ELEMENTS_EACH, Config.MAX_ELEMENTS_EACH);
            int numTriang = random.Next(Config.MIN_ELEMENTS_EACH, Config.MAX_ELEMENTS_EACH);

            List<Element> elements = new List<Element>();
            int i = 0;
            while (i < numCollect || i < numAvoid || i < numChange || i < numTriang)
            {
                if (i < numCollect)
                {
                    elements.Add(new CollectType(new CollectStrategy()));
                }
                if (i < numAvoid)
                {
                    elements.Add(new AvoidType(new AvoidStrategy()));
                }
                if (i < numChange)
                {
                    elements.Add(new ChangeType(new ChangeStrategy()));
                }
                if(i < numTriang)
                {
                    elements.Add(new TriangType(new CollectStrategy()));
                }
                i++;
            }
            totalToCollect = numCollect + numChange+numTriang;
            return elements;
        }
    }
}
