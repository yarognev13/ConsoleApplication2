﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2 {
    [TestFixture]
    public class Tests {
        [Test]
        public void MainTest() {
            Assert.AreEqual(1, 1);
        }
        [Test]
        public void NewTest() {
            Assert.AreEqual(2, 2);
        }
    }
}
