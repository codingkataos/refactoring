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

		public string ExportToPDF()
		{
			return ConvertToPDF();
		}

		public string Name
		{
			get { return name; }
		}

		public void SendContentTo(string email)
		{
			// send content to email.
		}

		private string ConvertToPDF()
		{
			return content;
		}
	}
}