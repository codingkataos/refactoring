namespace Refactoring.move
{

	public class Book
	{
		private string name;
		private string author;
		private string content;

		public bool Contains(string word)
		{
			return content.Contains(word);
		}

		public string Author
		{
			get{ return author; }
		}

		public string exportToPDF()
		{
			return convertToPDF();
		}

		public string Name
		{
			get { return name; }
		}

		public void sendContentTo(string email)
		{
			// send content to email.
		}

		private string convertToPDF()
		{
			return content;
		}
	}
}