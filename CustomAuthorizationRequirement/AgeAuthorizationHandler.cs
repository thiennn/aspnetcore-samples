using Microsoft.AspNetCore.Authorization;

namespace CustomAuthorizationRequirement
{
    public class AgeAuthorizationHandler : AuthorizationHandler<AgeRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AgeRequirement requirement)
        {
            if(1 == 1)
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
