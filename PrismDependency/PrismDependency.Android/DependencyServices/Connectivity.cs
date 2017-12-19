using Android.Net;
using PrismDependency.DependencyServices;
using PrismDependency.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(Connectivity))]
namespace PrismDependency.Droid.DependencyServices
{
    public class Connectivity: IConnectivity
    {
        private NetworkInfo _info;

        public bool IsConnected
        {
            get
            {
                var app = Android.App.Application.Context;
                var manager = (ConnectivityManager) app.GetSystemService("connectivity");

                _info = manager.ActiveNetworkInfo;

                return _info.IsConnected;
            }
            
        }

        public bool IsWifi
        {
            get
            {
                if (IsConnected)
                {
                    return _info.Type == ConnectivityType.Wifi;
                }

                return false;
            }
        }
    }
}