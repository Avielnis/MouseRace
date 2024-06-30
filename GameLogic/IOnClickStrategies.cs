using System.Media;

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
            element.Parent?.Controls.Remove(element);
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
}
