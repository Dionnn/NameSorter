using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NameSorter;
using NameSorter.InterFaces;
using NameSorter.Implementations;

namespace NameSorterUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateMethod()
        {
            CreateTxt create = new CreateTxt("test");
            var result = create.Create();
        }
    }
}
