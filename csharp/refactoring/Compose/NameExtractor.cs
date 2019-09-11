namespace Refactoring.Compose
{
	using System.Collections.Generic;
	using System.Linq;

	public class NameExtractor {

		public List<string> GetAllNames(string fullName) {
			List<string> allNames = new List<string>();

			if (fullName != null && fullName.Trim().Length > 0) {
				if (fullName.Contains(" ")) {
					string[] names = fullName.Split(' ');
					// identify first, middle and last names
					allNames.Add(names[0]);

					if (names.Length > 2) {
						string[] middleNames = names.Take(names.Length - 1).ToArray();						
						string middleName = string.Join(" ", middleNames.Skip(1));
						allNames.Add(middleName);
					}

					allNames.Add(names[names.Length - 1]);
				} else {
					allNames.Add(fullName);
				}
			}

			return allNames;
		}
	}
}