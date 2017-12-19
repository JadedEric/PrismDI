using Android.Content;
using PrismDependency.DependencyServices;

namespace PrismDependency.Droid.DependencyServices
{
    public class Player: IPlayer
    {
        public string PlayerId
        {
            get
            {
                var settings =
                    ((MainActivity) MainApplication.CurrentContext).GetSharedPreferences("googleplayservicessettings",
                        FileCreationMode.Private);
                var id = settings.GetString("playerid", string.Empty);

                return "";
            }
        }
    }
}