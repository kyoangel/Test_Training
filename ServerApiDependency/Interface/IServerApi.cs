using ServerApiDependency.Enum;

namespace ServerApiDependency.Interface
{
    public interface IServerApi
    {
        ServerResponse CancelGame();

        ServerResponse GameResult();

        ServerResponse StartGame();
    }
}