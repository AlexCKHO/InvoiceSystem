using IdentityApp.Authorization;
using IdentityApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IdentityApp.Data
{
    public class SeedData
    {
        public static async Task Initialize(

            IServiceProvider serviceProvider,
            string password)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // User
                var creatorUid = await EnsureUser(serviceProvider, password, "creator@demo.com");

                await CreateInvoice(context, creatorUid);
                // Manager
                var managerUid = await EnsureUser(serviceProvider, password, "manager@demo.com");
                await EnsureRole(serviceProvider, managerUid, Constants.InvoiceManagersRole);

                // Administrator
                var adminUid = await EnsureUser(serviceProvider, password, "admin@demo.com");
                await EnsureRole(serviceProvider, adminUid, Constants.InvoiceAdminsRole);
            }
        }
        private static async Task CreateInvoice(ApplicationDbContext context, string CreatorUid)
        {
            if (context.Invoice.Any())
            {
                context.RemoveRange(context.Invoice);
            }

            List<Invoice> invoices = new List<Invoice>();

            //January
            Invoice invoice = new Invoice();
            invoice.CreatorId = CreatorUid;
            invoice.InvoiceAmount = 394;
            invoice.InvoiceMonth = "January";
            invoice.InvoiceOwner = "M. ZuckerFiend";
            invoices.Add(invoice);

            // February
            Invoice februaryInvoice = new Invoice();
            februaryInvoice.CreatorId = CreatorUid;
            februaryInvoice.InvoiceAmount = 450;
            februaryInvoice.InvoiceMonth = "February";
            februaryInvoice.InvoiceOwner = "A. Johnson";
            invoices.Add(februaryInvoice);

            // March
            Invoice marchInvoice = new Invoice();
            marchInvoice.CreatorId = CreatorUid;
            marchInvoice.InvoiceAmount = 620;
            marchInvoice.InvoiceMonth = "March";
            marchInvoice.InvoiceOwner = "B. Thompson";
            invoices.Add(marchInvoice);

            // April
            Invoice aprilInvoice = new Invoice();
            aprilInvoice.CreatorId = CreatorUid;
            aprilInvoice.InvoiceAmount = 270;
            aprilInvoice.InvoiceMonth = "April";
            aprilInvoice.InvoiceOwner = "C. Davis";
            invoices.Add(aprilInvoice);

            // May
            Invoice mayInvoice = new Invoice();
            mayInvoice.CreatorId = CreatorUid;
            mayInvoice.InvoiceAmount = 890;
            mayInvoice.InvoiceMonth = "May";
            mayInvoice.InvoiceOwner = "D. Martinez";
            invoices.Add(mayInvoice);

            // June
            Invoice juneInvoice = new Invoice();
            juneInvoice.CreatorId = CreatorUid;
            juneInvoice.InvoiceAmount = 520;
            juneInvoice.InvoiceMonth = "June";
            juneInvoice.InvoiceOwner = "E. Garcia";
            invoices.Add(juneInvoice);

            // July
            Invoice julyInvoice = new Invoice();
            julyInvoice.CreatorId = CreatorUid;
            julyInvoice.InvoiceAmount = 730;
            julyInvoice.InvoiceMonth = "July";
            julyInvoice.InvoiceOwner = "F. Rodriguez";
            invoices.Add(julyInvoice);

            // August
            Invoice augustInvoice = new Invoice();
            augustInvoice.CreatorId = CreatorUid;
            augustInvoice.InvoiceAmount = 180;
            augustInvoice.InvoiceMonth = "August";
            augustInvoice.InvoiceOwner = "G. Wilson";
            invoices.Add(augustInvoice);

            // September
            Invoice septemberInvoice = new Invoice();
            septemberInvoice.CreatorId = CreatorUid;
            septemberInvoice.InvoiceAmount = 980;
            septemberInvoice.InvoiceMonth = "September";
            septemberInvoice.InvoiceOwner = "H. Anderson";
            invoices.Add(septemberInvoice);

            // October
            Invoice octoberInvoice = new Invoice();
            octoberInvoice.CreatorId = CreatorUid;
            octoberInvoice.InvoiceAmount = 310;
            octoberInvoice.InvoiceMonth = "October";
            octoberInvoice.InvoiceOwner = "I. Taylor";
            invoices.Add(octoberInvoice);

            // November
            Invoice novemberInvoice = new Invoice();
            novemberInvoice.CreatorId = CreatorUid;
            novemberInvoice.InvoiceAmount = 740;
            novemberInvoice.InvoiceMonth = "November";
            novemberInvoice.InvoiceOwner = "J. Thomas";
            invoices.Add(novemberInvoice);

            // December
            Invoice decemberInvoice = new Invoice();
            decemberInvoice.CreatorId = CreatorUid;
            decemberInvoice.InvoiceAmount = 580;
            decemberInvoice.InvoiceMonth = "December";
            decemberInvoice.InvoiceOwner = "K. Hernandez";
            invoices.Add(decemberInvoice);

            //January
            Invoice januaryInvoice = new Invoice();
            januaryInvoice.CreatorId = CreatorUid;
            januaryInvoice.InvoiceAmount = 394;
            januaryInvoice.InvoiceMonth = "January";
            januaryInvoice.InvoiceOwner = "M. ZuckerFiend";
            januaryInvoice.Status = InvoiceStatus.Approved;
            invoices.Add(januaryInvoice);

            // February
            Invoice februaryInvoiceApproved = new Invoice();
            februaryInvoiceApproved.CreatorId = CreatorUid;
            februaryInvoiceApproved.InvoiceAmount = 520;
            februaryInvoiceApproved.InvoiceMonth = "February";
            februaryInvoiceApproved.InvoiceOwner = "A. Johnson";
            februaryInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(februaryInvoiceApproved);

            // March
            Invoice marchInvoiceApproved = new Invoice();
            marchInvoiceApproved.CreatorId = CreatorUid;
            marchInvoiceApproved.InvoiceAmount = 610;
            marchInvoiceApproved.InvoiceMonth = "March";
            marchInvoiceApproved.InvoiceOwner = "B. Thompson";
            marchInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(marchInvoiceApproved);

            // April
            Invoice aprilInvoiceApproved = new Invoice();
            aprilInvoiceApproved.CreatorId = CreatorUid;
            aprilInvoiceApproved.InvoiceAmount = 480;
            aprilInvoiceApproved.InvoiceMonth = "April";
            aprilInvoiceApproved.InvoiceOwner = "C. Davis";
            aprilInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(aprilInvoiceApproved);

            // May
            Invoice mayInvoiceApproved = new Invoice();
            mayInvoiceApproved.CreatorId = CreatorUid;
            mayInvoiceApproved.InvoiceAmount = 730;
            mayInvoiceApproved.InvoiceMonth = "May";
            mayInvoiceApproved.InvoiceOwner = "D. Martinez";
            mayInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(mayInvoiceApproved);

            // June
            Invoice juneInvoiceApproved = new Invoice();
            juneInvoiceApproved.CreatorId = CreatorUid;
            juneInvoiceApproved.InvoiceAmount = 410;
            juneInvoiceApproved.InvoiceMonth = "June";
            juneInvoiceApproved.InvoiceOwner = "E. Garcia";
            juneInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(juneInvoiceApproved);

            // July
            Invoice julyInvoiceApproved = new Invoice();
            julyInvoiceApproved.CreatorId = CreatorUid;
            julyInvoiceApproved.InvoiceAmount = 820;
            julyInvoiceApproved.InvoiceMonth = "July";
            julyInvoiceApproved.InvoiceOwner = "F. Rodriguez";
            julyInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(julyInvoiceApproved);

            // August
            Invoice augustInvoiceApproved = new Invoice();
            augustInvoiceApproved.CreatorId = CreatorUid;
            augustInvoiceApproved.InvoiceAmount = 330;
            augustInvoiceApproved.InvoiceMonth = "August";
            augustInvoiceApproved.InvoiceOwner = "G. Wilson";
            augustInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(augustInvoiceApproved);

            // September
            Invoice septemberInvoiceApproved = new Invoice();
            septemberInvoiceApproved.CreatorId = CreatorUid;
            septemberInvoiceApproved.InvoiceAmount = 970;
            septemberInvoiceApproved.InvoiceMonth = "September";
            septemberInvoiceApproved.InvoiceOwner = "H. Anderson";
            septemberInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(septemberInvoiceApproved);

            // October
            Invoice octoberInvoiceApproved = new Invoice();
            octoberInvoiceApproved.CreatorId = CreatorUid;
            octoberInvoiceApproved.InvoiceAmount = 270;
            octoberInvoiceApproved.InvoiceMonth = "October";
            octoberInvoiceApproved.InvoiceOwner = "I. Taylor";
            octoberInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(octoberInvoiceApproved);

            // November
            Invoice novemberInvoiceApproved = new Invoice();
            novemberInvoiceApproved.CreatorId = CreatorUid;
            novemberInvoiceApproved.InvoiceAmount = 620;
            novemberInvoiceApproved.InvoiceMonth = "November";
            novemberInvoiceApproved.InvoiceOwner = "J. Thomas";
            novemberInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(novemberInvoiceApproved);

            // December
            Invoice decemberInvoiceApproved = new Invoice();
            decemberInvoiceApproved.CreatorId = CreatorUid;
            decemberInvoiceApproved.InvoiceAmount = 510;
            decemberInvoiceApproved.InvoiceMonth = "December";
            decemberInvoiceApproved.InvoiceOwner = "K. Hernandez";
            decemberInvoiceApproved.Status = InvoiceStatus.Approved;
            invoices.Add(decemberInvoiceApproved);

            Invoice januaryInvoiceRejected = new Invoice();
            januaryInvoiceRejected.CreatorId = CreatorUid;
            januaryInvoiceRejected.InvoiceAmount = 20;
            januaryInvoiceRejected.InvoiceMonth = "January";
            januaryInvoiceRejected.InvoiceOwner = "M. Someone";
            januaryInvoiceRejected.Status = InvoiceStatus.Rejected;



            // March
            Invoice marchInvoiceRejected = new Invoice();
            marchInvoiceRejected.CreatorId = CreatorUid;
            marchInvoiceRejected.InvoiceAmount = 50;
            marchInvoiceRejected.InvoiceMonth = "March";
            marchInvoiceRejected.InvoiceOwner = "B. Thompson";
            marchInvoiceRejected.Status = InvoiceStatus.Rejected;
            invoices.Add(marchInvoiceRejected);

            // April
            Invoice aprilInvoiceRejected = new Invoice();
            aprilInvoiceRejected.CreatorId = CreatorUid;
            aprilInvoiceRejected.InvoiceAmount = 36;
            aprilInvoiceRejected.InvoiceMonth = "April";
            aprilInvoiceRejected.InvoiceOwner = "C. Davis";
            aprilInvoiceRejected.Status = InvoiceStatus.Rejected;
            invoices.Add(aprilInvoiceRejected);

            // May
            Invoice mayInvoiceRejected = new Invoice();
            mayInvoiceRejected.CreatorId = CreatorUid;
            mayInvoiceRejected.InvoiceAmount = 90;
            mayInvoiceRejected.InvoiceMonth = "May";
            mayInvoiceRejected.InvoiceOwner = "D. Martinez";
            mayInvoiceRejected.Status = InvoiceStatus.Rejected;
            invoices.Add(mayInvoiceRejected);

            // June
            Invoice juneInvoiceRejected = new Invoice();
            juneInvoiceRejected.CreatorId = CreatorUid;
            juneInvoiceRejected.InvoiceAmount = 20;
            juneInvoiceRejected.InvoiceMonth = "June";
            juneInvoiceRejected.InvoiceOwner = "E. Garcia";
            juneInvoiceRejected.Status = InvoiceStatus.Rejected;
            invoices.Add(juneInvoiceRejected);

            // July
            Invoice julyInvoiceRejected = new Invoice();
            julyInvoiceRejected.CreatorId = CreatorUid;
            julyInvoiceRejected.InvoiceAmount = 0;
            julyInvoiceRejected.InvoiceMonth = "July";
            julyInvoiceRejected.InvoiceOwner = "F. Rodriguez";
            julyInvoiceRejected.Status = InvoiceStatus.Rejected;
            invoices.Add(julyInvoiceRejected);

            // November
            Invoice novemberInvoiceRejected = new Invoice();
            novemberInvoiceRejected.CreatorId = CreatorUid;
            novemberInvoiceRejected.InvoiceAmount = 30;
            novemberInvoiceRejected.InvoiceMonth = "November";
            novemberInvoiceRejected.InvoiceOwner = "J. Thomas";
            novemberInvoiceRejected.Status = InvoiceStatus.Rejected;
            invoices.Add(novemberInvoiceRejected);

            // December
            Invoice decemberInvoiceRejected = new Invoice();
            decemberInvoiceRejected.CreatorId = CreatorUid;
            decemberInvoiceRejected.InvoiceAmount = 100;
            decemberInvoiceRejected.InvoiceMonth = "December";
            decemberInvoiceRejected.InvoiceOwner = "K. Hernandez";
            decemberInvoiceRejected.Status = InvoiceStatus.Rejected;
            invoices.Add(decemberInvoiceRejected);

            context.Invoice.AddRange(invoices);
            await context.SaveChangesAsync();
        }


        private static async Task<string> EnsureUser(
            IServiceProvider serviceProvider, 
            string initPw, string userName)
        {

            //Check if that user exist in the database already, if yes 
            //if no, create it base on the arugements 
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();


            //UserManager<IdentityUser>, UserManager manage user

            var user = await userManager.FindByNameAsync(userName);

            if(user == null)
            {
                user = new IdentityUser
                {
                    UserName = userName,
                    Email = userName,
                    EmailConfirmed = true 
                };

                var result = await userManager.CreateAsync(user, initPw);
            }

            if(user == null) //if the user account failed to be created in above process,
                             //because of some reason, then throw an exception.

            {
                throw new Exception("User did not get created. Password policy problem?");
            }

            return user.Id;
        }

        public static async Task<IdentityResult> EnsureRole(
            IServiceProvider serviceProvider, string uid, string role)
        {
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

            //RoleManager<IdentityUser>, RoleManager manage
            IdentityResult ir;
            if(await roleManager.RoleExistsAsync(role) == false)
            {
                ir = await roleManager.CreateAsync(new IdentityRole(role));
            }
            //Do we have that role? If not, create that role.

            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByIdAsync(uid);

            if(user == null)
            {
                throw new Exception("User not existing");
            }

            ir = await userManager.AddToRoleAsync(user, role);
            //Add that user into that role

            return ir;
        }
    }
}
