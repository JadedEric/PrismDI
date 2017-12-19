namespace PrismDependency.DependencyServices
{
    public interface IConnectivity
    {
        bool IsConnected { get; }

        bool IsWifi { get; }
    }
}
