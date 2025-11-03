using Engine.ViewModels;
using System.Diagnostics;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Clicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static System.Timers.Timer _autoClickers = new System.Timers.Timer(1000);

        private GameSession _gameSession;

        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession();

            DataContext = _gameSession;

            _autoClickers.Elapsed += AutoClickerTick;
            _autoClickers.Enabled = true;
        }

        private void Button_AddClick(object sender, RoutedEventArgs e)
        {
            _gameSession.CurrentPlayer.CurrentPoints += 1.0f;
        }

        private void Button_BuyAutoClicker(object sender, RoutedEventArgs e)
        {
            if (_gameSession.CurrentPlayer.CurrentPoints >= 10.0f)
            {
                _gameSession.CurrentPlayer.CurrentPoints -= 10.0f;
                _gameSession.CurrentPlayer.NumberOfAutoClickers += 1;
            }
        }
        
        private void AutoClickerTick(object sender, ElapsedEventArgs e)
        {
            _gameSession.CurrentPlayer.CurrentPoints += 0.2f * _gameSession.CurrentPlayer.NumberOfAutoClickers;
        }
    }
}