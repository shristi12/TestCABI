using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Tests.SDET.BusinessLogic
{
    public class OurProcessor
    {
        private readonly ILogger<OurProcessor> _logger;

        public OurProcessor(ILogger<OurProcessor> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Generates a hash for a password
        /// </summary>
        /// <param name="plainTextPassword">The password to generate the hash for</param>
        /// <returns>A hash based upon the entered password</returns>
        public string GetHash(string plainTextPassword)
        {
            if (plainTextPassword.Length < 8)
            {
                throw new Exception("Password needs to be at least 8 characters");
            }
            else if (plainTextPassword.Contains("password", StringComparison.InvariantCultureIgnoreCase))
            {
                throw new Exception("Password cannot contain word password");
            }
            else
            {
                var hash = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(plainTextPassword));
                StringBuilder hashAsString = new StringBuilder();
                foreach (var t in hash)
                {
                    hashAsString.Append(t.ToString("x2"));
                }

                return hashAsString.ToString();
            }
        }
    }
}
