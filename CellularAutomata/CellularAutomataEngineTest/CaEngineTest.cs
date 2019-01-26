using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CellularAutomataEngine;

namespace CellularAutomataEngineTest
{
    [TestClass]
    public class CaEngineTest
    {
        [TestMethod]
        public void NewEngineEmptyIsOK()
        {
            var caEngine = new CAEngine(0);
            // minimum 3 row length
            var expected = 3;
            Assert.AreEqual(expected, caEngine.RowLength);
        }

        [TestMethod]
        public void EmptyEngineCurrentRow()
        {
            var caEngine = new CAEngine(0);
            var expected = new int[3] { 0, 0, 0 };
            CollectionAssert.AreEqual(expected, caEngine.CurrentRow);
        }

        [TestMethod]
        public void NewEngineHasRowLength()
        {
            var caEngine = new CAEngine(10);
            Assert.AreEqual(10, caEngine.RowLength);
        }

        [TestMethod]
        public void NewEngineHasDefaultRule()
        {
            var caEngine = new CAEngine(10);
            Assert.AreEqual(110, caEngine.RuleNumber);
        }

        [TestMethod]
        public void SetRuleWorks()
        {
            var caEngine = new CAEngine(10);
            caEngine.RuleNumber = 25;
            Assert.AreEqual(25, caEngine.RuleNumber);
        }

        [TestMethod]
        public void SetRuleOutOfBoundsGivesDefaultRule()
        {
            var caEngine = new CAEngine(10);
            caEngine.RuleNumber = 254;
            Assert.AreEqual(110, caEngine.RuleNumber);
            caEngine.RuleNumber = 1;
            Assert.AreEqual(110, caEngine.RuleNumber);
        }

        [TestMethod]
        public void SetNullRowReturnsUninitializedRow()
        {
            var caEngine = new CAEngine(10);
            caEngine.CurrentRow = null;
            var expected = new int[10];
            CollectionAssert.AreEqual(expected, caEngine.CurrentRow);
        }

        [TestMethod]
        public void SetRowZerosSetsRowZeros()
        {
            var caEngine = new CAEngine(10);
            caEngine.CurrentRow = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            var expected = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            CollectionAssert.AreEqual(expected, caEngine.CurrentRow);
        }

        [TestMethod]
        public void SetRowWrongSizeDoesntChangeRow()
        {
            var caEngine = new CAEngine(10);
            caEngine.CurrentRow = new int[] { 0 };
            var expected = new int[10];
            CollectionAssert.AreEqual(expected, caEngine.CurrentRow);
        }

        [TestMethod]
        public void GetNextRowSuccess()
        {
            var caEngine = new CAEngine(3);
            caEngine.CurrentRow = new[] { 0, 0, 0 };
            caEngine.RuleNumber = 30;
            var expected = new[] { 0, 0, 0 };
            CollectionAssert.AreEqual(expected, caEngine.GetNextRow());
        }
    }
}
