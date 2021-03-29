using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperCar_racing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperCar_racing.Tests
{
    [TestClass()]
    public class playgroundTests
    {
        [TestMethod()]
        public void playgroundTest()
        {
            selectPlayer SP = new selectPlayer();
            SP.getNumber();
            int x = SP.Num;

            if (x < 100)
            {
                Assert.IsTrue(true);
            }
            else {
                Assert.IsTrue(false);
            }
        }
        [TestMethod()]
        public void playgroundTest2()
        {
            selectPlayer SP = new selectPlayer();
            
            

            if (SP.betAmount("1","1",10,100)==110)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}