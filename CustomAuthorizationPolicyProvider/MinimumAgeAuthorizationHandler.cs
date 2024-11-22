using Microsoft.AspNetCore.Authorization;

namespace CustomAuthorizationPolicyProvider
{
    public class MinimumAgeAuthorizationHandler : AuthorizationHandler<MinimumAgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAgeRequirement requirement)
        {
            // TODO: Implement the logic to handle the requirement

            if (1 == 1)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
