using Duende.IdentityServer.Models;
using Duende.IdentityServer.Test;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
        {
            new ApiScope("student.read","student read scope"),
            new ApiScope("department.read","department read scope")
        };

        public static IEnumerable<Client> Clients => new List<Client>
        {
            new Client
            {
                ClientId = "client1",
                ClientSecrets = {new Secret("secretKey".Sha256())},
                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                AllowedScopes = { "student.read", "department.read" }
            },

        };

        public static List<TestUser> TestUsers => new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "26c742ad-10e9-4727-b9eb-da166ef19086",
                Username = "mostafa_elnady",
                Password = "123",
            }
        };
    }
}
