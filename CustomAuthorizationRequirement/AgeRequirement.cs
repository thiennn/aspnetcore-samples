using Microsoft.AspNetCore.Authorization;

namespace CustomAuthorizationRequirement
{
    public class AgeRequirement : IAuthorizationRequirement
    {
        public int Age { get; }

        public AgeRequirement(int age)
        {
            Age = age;
        }
    }
}
