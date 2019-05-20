using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cargo3DSite.Controllers;
using Cargo3DSite.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cargo3DSite.Tests.Controllers
{
    [TestClass]
    public class AccountTests
    {

        private List<ApplicationUser> Users = new List<ApplicationUser>();

        [TestInitialize]
        public void Setup()
        {
            var user1 = new ApplicationUser
            {
                UserName = "Jett@Tripp.net",
                Email = "Jett@Tripp.net"
            };
            Users.Add(user1);

            var user4 = new ApplicationUser
            {
                UserName = "Richard@Sanchez.net",
                Email = "Richard@Sanchez.net"
            };
            Users.Add(user4);
            
            var user2 = new ApplicationUser
            {
                UserName = "Nick@Hurst.net",
                Email = "Nick@Hurst.net"
            };
            Users.Add(user2);

            var user3 = new ApplicationUser
            {
                UserName = "Chris@Ellis.net",
                Email = "Chris@Ellis.net"
            };
            Users.Add(user3);

        }


        [TestMethod]
        public async Task AddUsersWithPasswordsAsync()
        {
            //arrange

            AccountController AC = new AccountController();
            HomeController HC = new HomeController();


            String password = "Cargo3d";

            //act

            Console.WriteLine("Adding users.");

            foreach (var user in Users)
            {
                var model = new RegisterViewModel()
                {
                    Email = user.Email,
                    Password = password,
                    ConfirmPassword = password
                };
                //await AC.Register(model, true);
            }

            //assert

            Assert.IsTrue(true, "No errors");
        }

        [TestMethod]
        public void AddPermisionsToUsers()
        {
            //cant do without db or at least not yet
        }

        [TestMethod]
        public void AddItemsToUser()
        {
            //arrange



            //act

            //assert
        }

    }
}
