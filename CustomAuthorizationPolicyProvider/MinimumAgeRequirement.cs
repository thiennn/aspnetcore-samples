using Microsoft.AspNetCore.Authorization;

namespace CustomAuthorizationPolicyProvider
{
    public class MinimumAgeRequirement : IAuthorizationRequirement
    {
        public int Age { get; private set; }

        public MinimumAgeRequirement(int age) { Age = age; }
    }
}
