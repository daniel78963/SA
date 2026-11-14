using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using SA.APILibrary.DTOs;
using System.Security.Cryptography;

namespace SA.APILibrary.Services
{
    public class ServiceHash : IServiceHash
    {
        public ResultHashDTO Hash(string input)
        {
            // Generate a random salt
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            return Hash(input, salt);
        }

        public ResultHashDTO Hash(string input, byte[] salt)
        {
            // Generate a random salt
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: input,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));

            return new ResultHashDTO { Hash = hashed, Sal = salt };
        }
    }
}
