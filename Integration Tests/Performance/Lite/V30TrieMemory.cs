﻿/* *********************************************************************
 * This Source Code Form is copyright of 51Degrees Mobile Experts Limited. 
 * Copyright © 2017 51Degrees Mobile Experts Limited, 5 Charlotte Close,
 * Caversham, Reading, Berkshire, United Kingdom RG4 7BY
 * 
 * This Source Code Form is the subject of the following patent 
 * applications, owned by 51Degrees Mobile Experts Limited of 5 Charlotte
 * Close, Caversham, Reading, Berkshire, United Kingdom RG4 7BY: 
 * European Patent Application No. 13192291.6; and
 * United States Patent Application Nos. 14/085,223 and 14/085,301.
 *
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0.
 * 
 * If a copy of the MPL was not distributed with this file, You can obtain
 * one at http://mozilla.org/MPL/2.0/.
 * 
 * This Source Code Form is “Incompatible With Secondary Licenses”, as
 * defined by the Mozilla Public License, v. 2.0.
 * ********************************************************************* */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiftyOne.Foundation.Mobile.Detection.Factories;
using System.IO;
using FiftyOne.Foundation.Mobile.Detection;

namespace FiftyOne.Tests.Integration.Performance.Lite
{
    [TestClass]
    public class V30TrieMemory : TrieMemory
    {
        protected override int MaxInitializeTime
        {
            get { return 10000; }
        }

        protected override string DataFile
        {
            get { return Utils.GetDataFile(Constants.LITE_TRIE_V30); }
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_InitializeTime()
        {
            base.InitializeTime();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_BadUserAgentsMulti()
        {
            base.BadUserAgentsMulti();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_BadUserAgentsSingle()
        {
            base.BadUserAgentsSingle();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_UniqueUserAgentsMulti()
        {
            base.UniqueUserAgentsMulti();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_UniqueUserAgentsSingle()
        {
            base.UniqueUserAgentsSingle();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_RandomUserAgentsMulti()
        {
            base.RandomUserAgentsMulti();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_RandomUserAgentsSingle()
        {
            base.RandomUserAgentsSingle();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_BadUserAgentsMultiAll()
        {
            base.BadUserAgentsMulti();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_BadUserAgentsSingleAll()
        {
            base.BadUserAgentsSingle();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_UniqueUserAgentsMultiAll()
        {
            base.UniqueUserAgentsMulti();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_UniqueUserAgentsSingleAll()
        {
            base.UniqueUserAgentsSingle();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_RandomUserAgentsMultiAll()
        {
            base.RandomUserAgentsMulti();
        }

        [TestMethod]
        public void LiteV30TrieMemory_Performance_RandomUserAgentsSingleAll()
        {
            base.RandomUserAgentsSingle();
        }
    }
}
