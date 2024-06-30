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
            string filePath = @"C:\Users\aviel\IDC\MyProjects\Prismm\MouseRace\GameLogic\Resources\CollectSound.wav";
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
            string filePath = @"C:\Users\aviel\IDC\MyProjects\Prismm\MouseRace\GameLogic\Resources\AvoidSound.wav";
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
