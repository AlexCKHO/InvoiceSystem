using Microsoft.AspNetCore.Identity;
using IdentityApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace IdentityApp.Authorization
{
    public class InvoiceCreatorAuthorizationHandler : 
        AuthorizationHandler<OperationAuthorizationRequirement, Invoice>
    {

        UserManager<IdentityUser> _userManager;
        public InvoiceCreatorAuthorizationHandler(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context, 
            OperationAuthorizationRequirement requirement, 
            Invoice invoice)
        {
            if(context.User == null || invoice == null) //no user login or no invoice
            { return Task.CompletedTask; } //return Task.CompletedTask; will reject the request, 
                                           //because this Authorization is a the http pipeline, 
                                           //by returning the request, the request will be futher processed 
                                           //Thus, it is a reject

            if (requirement.Name != Constants.CreateOperationName &&
                requirement.Name != Constants.ReadOperationName &&
                requirement.Name != Constants.UpdateOperationName &&
                requirement.Name != Constants.DeleteOperationName
                ) // Because in this class we aim to handle CRUD operation only,
                  // so this step, we are filtering out the none CRUD operation requests
            {
                return Task.CompletedTask;
            }

            if(invoice.CreatorId == _userManager.GetUserId(context.User)) 
                //In this if statement, we are checking if the invoice creator is the
                //current user by comparing the ID
            {
                context.Succeed(requirement);
            }

            //Anything else, we reject it
            return Task.CompletedTask;
        }
    }
}
