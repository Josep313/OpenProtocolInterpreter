﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenProtocolInterpreter.Job.Advanced;

namespace MIDTesters.Job.Advanced
{
    [TestClass]
    public class TestMid0121 : MidTester
    {
        [TestMethod]
        public void Mid0121Revision1()
        {
            string package = "00200121   0        ";
            var mid = _midInterpreter.Parse(package);

            Assert.AreEqual(typeof(MID_0121), mid.GetType());
            Assert.IsNotNull(mid.HeaderData.NoAckFlag);
            Assert.AreEqual(package, mid.Pack());
        }
    }
}