using Microsoft.EntityFrameworkCore;
using IdentityApp.Data;
using IdentityApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using IdentityApp.Authorization;

namespace IdentityApp.Pages.Invoices
{
   // [AllowAnonymous] // Allow user access without login 
    
    public class IndexModel : DI_BasePageModel
    {


        public IndexModel(ApplicationDbContext context, IAuthorizationService authorizationService, UserManager<IdentityUser> userManager)
            : base(context, authorizationService, userManager)
        {
        }

        public IList<Invoice> Invoice { get;set; } = default!;

        public async Task OnGetAsync()
        {
            //Manager call view all the invoices, and creator can only see their own invoices
            if (Context.Invoice != null)
            {
                var invoices = from i in Context.Invoice
                                select i;

                var isManager = User.IsInRole(Constants.InvoiceManagersRole);
                var isAdmin = User.IsInRole(Constants.InvoiceAdminsRole);

                var currentUserId = UserManager.GetUserId(User);

                if (!isManager && !isAdmin)
                {
                    invoices = invoices.Where(i => i.CreatorId == currentUserId);
                }

                Invoice = await invoices.ToListAsync();
            }
        }
    }
}
