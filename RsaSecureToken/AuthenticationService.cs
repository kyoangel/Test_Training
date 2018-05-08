using System;
using System.Collections.Generic;

namespace RsaSecureToken
{
    public class AuthenticationService
    {
        public bool IsValid(string account, string password)
        {
            // 根據 account 取得設定時間
            var profileDao = new ProfileDao();
            var registerMinutes = profileDao.GetRegisterTimeInMinutes(account);

            // 根據 registerMinutes 取得 RSA token 目前的亂數
            var rsaToken = new RsaTokenDao();
            var otp = rsaToken.GetRandom(registerMinutes);

            // 驗證傳入的 password 是否等於 otp
            var isValid = password == otp;

            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class ProfileDao
    {
        public int GetRegisterTimeInMinutes(string account)
        {
            throw new NotImplementedException();
        }
    }

    public class RsaTokenDao
    {
        public string GetRandom(int minutes)
        {
            var seed = new Random((int)DateTimeOffset.Now.ToUnixTimeSeconds()/60 - minutes);
            var result = seed.Next(0, 999999).ToString("000000");
            Console.WriteLine("randomCode:{0}", result);

            return result;
        }
    }
}