using Cargo3DSite.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cargo3DSite.Startup))]
namespace Cargo3DSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            ApplicationDbContext context = new ApplicationDbContext();

            // Setup an initial Admin User if one doesn't already exist?
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                var role1 = new IdentityRole();
                role1.Name = "User";
                roleManager.Create(role1);

                var role2 = new IdentityRole();
                role2.Name = "Anonymous";
                roleManager.Create(role2);

                var user = new ApplicationUser();
                user.UserName = "Jett@Tripp.net";
                user.Email = "Jett@Tripp.net";

                string userPWD = "Cargo3D";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                    var result2 = UserManager.AddToRole(user.Id, "user");
                }


                if (UserManager.GetEmail("Jett@Tripp.net").Equals(null))
                {
                    var checkUser = UserManager.Create(user, userPWD);


                }
            }
        }
    }
}
