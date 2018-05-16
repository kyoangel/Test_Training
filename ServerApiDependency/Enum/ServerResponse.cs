namespace ServerApiDependency.Enum
{
    public enum ServerResponse : int
    {
        Correct = 0,
        FastAction = 1,
        NoGameRunning = 2,
        GameAlreadyRunning = 3,
        DbError = 4,
        WrongState = 5,
        AuthFail = 99
    }
}