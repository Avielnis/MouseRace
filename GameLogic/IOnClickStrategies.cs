using System.Media;
using System.Security.Cryptography.Xml;

namespace GameLogic
{
    public interface IOnClickStrategies
    {
        void Invoke(Element element);
        void PlaySound();

    }

    public class CollectStrategy : IOnClickStrategies
    {
        public void Invoke(Element element)
        {
            PlaySound();
            GameEngine.Instance.AddCollected(element);
            element.Parent.Controls.Remove(element);
        }

        public void PlaySound()
        {
            string filePath = string.Format("{0}\\GameLogic\\Resources\\CollectSound.wav", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName);
            SoundPlayer player = new SoundPlayer(filePath);
            player.Play();

        }
    }

    public class AvoidStrategy : IOnClickStrategies
    {
        public void Invoke(Element element)
        {
            PlaySound();
            GameEngine.Instance.LoseGame();
        }

        public void PlaySound()
        {
            string filePath = string.Format("{0}\\GameLogic\\Resources\\AvoidSound.wav", Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName);
            SoundPlayer player = new SoundPlayer(filePath);
            player.Play();
        }
    }

    public class ChangeStrategy : IOnClickStrategies
    {
        private ChangeType elem = null;
        public void Invoke(Element element)
        {
            elem = (ChangeType)(element);
            if (elem.isCollect())
            {
                new CollectStrategy().Invoke(elem);
                return;
            }
            new AvoidStrategy().Invoke(elem);
        }
        
        public void PlaySound()
        {
            if(elem == null)
            {
                return;
            }
            if (elem.isCollect())
            {
                new CollectStrategy().PlaySound();
            }
            else
            {
                new AvoidStrategy().PlaySound();
            }
        }

    }
}
