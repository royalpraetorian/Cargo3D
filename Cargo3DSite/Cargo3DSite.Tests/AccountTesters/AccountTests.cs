using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var user = new ApplicationUser
            {
                UserName = "Jett@Tripp.net",
                Email = "Jett@Tripp.net"
            };
            Users.Add(user);


        }

        [TestMethod]
        public void AddPermisionsToUsers()
        {
            Console.WriteLine("Adding permissions to users.");
        }

    }
}
