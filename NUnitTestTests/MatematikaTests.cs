﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnitTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTest.Tests
{
    [TestClass()]
    public class MatematikaTests
    {
        [TestMethod()]
        public void UserTest()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual("Ramadana", mtk.User("Winata"));
        }

        [TestMethod()]
        public void TambahTest()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual(20, mtk.Tambah(10, 10));
        }

        [TestMethod()]
        public void KurangTest()
        {
            Matematika mtk = new Matematika();
            Assert.AreEqual(20, mtk.Kurang(30, 10));
        }
    }
}