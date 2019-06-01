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

                string userPWD1 = "Cargo3D";

                var user1 = new ApplicationUser();
                user1.UserName = "Chris@Ellis.net";
                user1.Email = "Chris@Ellis.net";

                var user2 = new ApplicationUser();
                user2.UserName = "Richard@Sanchez.net";
                user2.Email = "Richard@Sanchez.net";

                var user3 = new ApplicationUser();
                user3.UserName = "Nick@Hurst.net";
                user3.Email = "Nick@Hurst.net";


                var checkUser1 = UserManager.Create(user1, userPWD1);
                var checkUser2 = UserManager.Create(user2, userPWD1);
                var checkUser3 = UserManager.Create(user3, userPWD1);

                var resultA1 = UserManager.AddToRole(user1.Id, "Admin");
                var resultB1 = UserManager.AddToRole(user1.Id, "user");

                var resultA2 = UserManager.AddToRole(user2.Id, "Admin");
                var resultB2 = UserManager.AddToRole(user2.Id, "user");

                var resultA3 = UserManager.AddToRole(user3.Id, "Admin");
                var resultB3 = UserManager.AddToRole(user3.Id, "user");

                //Add default User to Role Admin   
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");
                    var result2 = UserManager.AddToRole(user.Id, "user");
                }
                
            }

            
        }
    }
}
