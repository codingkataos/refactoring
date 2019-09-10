namespace Refactoring.Tell

{
	public class MediaController
	{

		public void isAppropriate(Person viewer)
		{
			int age = viewer.Age;

			if (age >= 18)
			{
				ViewHorror();
			}

			if (age < 18)
			{
				SorryNotAllowed();
			}
		}

		private void ViewHorror() { }

		private void SorryNotAllowed() { }
	}
}