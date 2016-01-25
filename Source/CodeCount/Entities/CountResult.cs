namespace CodeCount.Entities
{
	public class CountResult
	{
		public int Code { get; set; }
		public int Comment { get; set; }

		public int Total { get { return Code + Comment; } }
	}
}