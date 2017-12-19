using Prism.Navigation;
using PrismDependency.DependencyServices;

namespace PrismDependency.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public string IsConnected { get; set; }
        public string IsWifi { get; set; }

        public string PlayerId { get; set; }

        public MainPageViewModel(INavigationService navigationService, IConnectivity connectivity, IPlayer player) 
            : base (navigationService)
        {
            Title = "Main Page";

            IsConnected = $"Am I connected: {connectivity.IsConnected}";
            IsWifi = $"Am I connected via WIFI: {connectivity.IsWifi}";

            PlayerId = $"My player id is: {player.PlayerId}";
        }
    }
}
