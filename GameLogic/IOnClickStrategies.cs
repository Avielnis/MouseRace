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
