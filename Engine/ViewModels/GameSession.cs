using Engine.Models;
using System.Security.Cryptography.X509Certificates;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {
        public Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player
            {
                CurrentPoints = 0
            };
        }
    }
}
