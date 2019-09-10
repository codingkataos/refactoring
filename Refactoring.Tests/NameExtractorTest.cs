using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Compose;
using System.Collections.Generic;

namespace Refactoring.Tests
{
	[TestClass]
	public class NameExtractorTest
	{
		readonly NameExtractor nameExtractor = new NameExtractor();

		[TestMethod]
		public void null_name_should_return_empty()
		{
			Assert.IsTrue(nameExtractor.GetAllNames(null).Count == 0);
		}



		[TestMethod]
		public void empty_name_should_return_empty()
		{
			Assert.IsTrue(nameExtractor.GetAllNames("    ").Count == 0);
		}
			   
		[TestMethod]
		public void first_name_only_should_return_same_name()
		{
			CollectionAssert.AreEqual(nameExtractor.GetAllNames("Martin"), new List<string> { "Martin" });
		}

		[TestMethod]
		public void first_and_last_name_should_return_first_and_last_name()
		{
			CollectionAssert.AreEqual(nameExtractor.GetAllNames("Martin Fowler"), new List<string> { "Martin", "Fowler" });
		}
				
		[TestMethod]
		public void first_middle_and_last_name_should_return_first_middle_and_last_name()
		{
			CollectionAssert.AreEqual(nameExtractor.GetAllNames("Mary Elizabeth Smith"), new List<string> { "Mary", "Elizabeth", "Smith" });
		}
	}
}
