using System;

namespace SOLID_Examples
{
	//Definition: No client should be forced to depend on methods it does not use

	//A car can start, move, upshift and downshift, can be fillen
	//and a car is a vechile, and it can implement IVechile interface
	//A bicycle is also a vechile, but it can't implement the IVechile interface
	//because it can't start, upshift or downshift, can't be fillen
	//So if bicycle would use that interface, it would have some extra functions and it would violate the ISP

	#region Bad code
	interface IBook
	{
		string Name { get; set; }
		string Author { get; set; }
		int PagesCount { get; set; }

		int BurrowerId { get; set; }
		string BurrowerName { get; set; }
		DateTime BurrowDate { get; set; }

		int DurationInMinutes { get; set; }
	}

	class Book : IBook
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public int PagesCount { get; set; }

		public int BurrowerId { get; set; }
		public string BurrowerName { get; set; }
		public DateTime BurrowDate { get; set; }

		public int DurationInMinutes { get; set; } //It's only an audiobook which has duration
	}
	class AudioBook : IBook
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public int PagesCount { get; set; } //Audiobook doesn't have pages

		public int BurrowerId { get; set; } //Audiobook is not burrowable
		public string BurrowerName { get; set; }
		public DateTime BurrowDate { get; set; }

		public int DurationInMinutes { get; set; }
	}

	class MyProgram
	{
		public void Main()
		{
			IBook theGreatGatsby = new Book();
			//we have access to
			//theGreatGatsby.DurationInMinutes
			//which a book doesn't have

			IBook theGreatGatsbyAudio = new AudioBook();
			//we have access to
			//theGreatGatsbyAudio.PagesCount
			//which an audio book doesn't have
		}
	}
	#endregion

	#region Good code
	//interface ILibraryItem
	//{
	//	string Name { get; set; }
	//	string Author { get; set; }		
	//}
	//interface IAudioBook
	//{
	//	int DurationInMinutes { get; set; }
	//}
	//interface IBurrowable
	//{
	//	int BurrowerId { get; set; }
	//	string BurrowerName { get; set; }
	//	DateTime BurrowDate { get; set; }
	//}
	//interface IPagedBook
	//{
	//	int PagesCount { get; set; }
	//}

	//class Book : ILibraryItem, IBurrowable, IPagedBook
	//{
	//	public string Name { get; set; }
	//	public string Author { get; set; }
	//	public int PagesCount { get; set; }

	//	public int BurrowerId { get; set; }
	//	public string BurrowerName { get; set; }
	//	public DateTime BurrowDate { get; set; }
	//}
	//class AudioBook : ILibraryItem, IAudioBook
	//{
	//	public string Name { get; set; }
	//	public string Author { get; set; }

	//	public int DurationInMinutes { get; set; }
	//}

	//class MyProgram
	//{
	//	public void Main()
	//	{
	//		ILibraryItem getsby = new Book();
	//		Console.WriteLine($"The author of book {getsby.Name} is {getsby.Author}");

	//		IBurrowable book1 = new Book();
	//		Console.WriteLine($"Book1 is burrowed by {book1.BurrowerName}");

	//		IAudioBook audioBook = new AudioBook();
	//		Console.WriteLine($"This audiobook will take you {audioBook.DurationInMinutes} minutes to listen");
	//	}
	//}
	#endregion

}
