namespace ServerApiDependency.Interface
{
    public interface IServerApi
    {
        int CancelGame();

        int GameResult();

        int StartGame();
    }
}