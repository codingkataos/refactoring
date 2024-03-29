namespace Refactoring.DI
{
	using System.Collections.Generic;



	public class Manager
	{
		private readonly List<Developer> developers = new List<Developer>();
		private readonly List<Tester> testers = new List<Tester>();

		public List<Developer> GetDevelopers() {
			return developers;
		}

		public void AddDeveloper(Developer developer) {
			this.developers.Add(developer);
		}

		public List<Tester> GetTesters() {
			return testers;
		}

		public void AddTester(Tester tester) {
			this.testers.Add(tester);
		}
	}
}