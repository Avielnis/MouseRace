using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GameLogic
{
    public interface IOnClickStrategies
    {
        void Invoke(Element element);
    }

    public class CollectStrategy : IOnClickStrategies
    {
        public void Invoke(Element element)
        {
            GameEngine.Instance.AddCollected(element);
            element.Parent.Controls.Remove(element);
        }
    }

    public class AvoidStrategy : IOnClickStrategies
    {
        public void Invoke(Element element)
        {
            GameEngine.Instance.LoseGame();
        }
    }
}
