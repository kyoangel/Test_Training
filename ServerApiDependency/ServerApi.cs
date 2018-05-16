using System;
using ServerApiDependency.Enums;
using ServerApiDependency.Interface;
using ServerApiDependency.Utility;

namespace ServerApiDependency
{
    public class ServerApi : IServerApi
    {
        public int CancelGame()
        {
            const string apiPage = "cancel.php";
            try
            {
                var response = PostToThirdParty(ApiType.CancelGame, apiPage);
                if (response != 0)
                {
                    TiDebugHelper.Error($"{apiPage} response has error, ErrorCode = {response}");
                    throw new Exception();
                }
                return response;
            }
            catch (Exception e)
            {
                SaveFailRequestToDb(ApiType.CancelGame, apiPage);
                throw e;
            }
        }

        public int GameResult()
        {
            const string apiPage = "result.php";
            try
            {
                var response = PostToThirdParty(ApiType.GameResult, apiPage);
                if (response != 0)
                {
                    TiDebugHelper.Error($"{apiPage} response has error, ErrorCode = {response}");
                    throw new Exception();
                }
                return response;
            }
            catch (Exception e)
            {
                SaveFailRequestToDb(ApiType.GameResult, apiPage);
                throw e;
            }
        }

        public int StartGame()
        {
            const string apiPage = "start.php";
            try
            {
                var response = PostToThirdParty(ApiType.StartGame, apiPage);
                if (response != 0)
                {
                    TiDebugHelper.Error($"{apiPage} response has error, ErrorCode = {response}");
                    throw new Exception();
                }
                return response;
            }
            catch (Exception e)
            {
                SaveFailRequestToDb(ApiType.StartGame, apiPage);
                throw e;
            }
        }

        private int PostToThirdParty(ApiType apiType, string apiPage)
        {
            throw new NotImplementedException();
        }

        private void SaveFailRequestToDb(ApiType apiType, string apiPage)
        {
            throw new NotImplementedException();
        }
    }
}