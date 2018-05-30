using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson
{
	class Program
	{

		struct gamer
		{
			public string name;
			public string favnbr;
		}

		static void Main(string[] args)
		{

			int year = 365;
			int age = 36;
			int Jan = 31;
			int Feb = 28;
			int Mar = 31;
			int Apr = 30;
			int May = 29;
			int daysalive = (year * age) + Jan + Feb + Mar + Apr + May;
			Console.WriteLine(daysalive);

			int[] frames = new int[10];
			frames[0] = 30;
			frames[1] = 17;
			frames[2] = 10;
			frames[3] = 15;
			frames[4] = 26;
			frames[5] = 7;
			frames[6] = 28;
			frames[7] = 20;
			frames[8] = 6;
			frames[9] = 4;
			int game = 0;
			foreach (int frm in frames) {
				game = game + frm;
			}
			Console.WriteLine(game);

			string[] names = {
				"greg", "micheal", "dan", "anna",
				"marcus", "foster", "jermaion", "mitchell",
				"jon", "larry", "william"
			};
			foreach (string aname in names) {
				Console.WriteLine("hi " + aname);	

			};
			string[] self = {
				"Dan",
				"Lebanon, OH",
				"loughry_d@yahoo.com"
			};

			foreach (string str in self) {
				Console.WriteLine(str);
			}

					gamer ken;
					ken.name = "Ken";
					ken.favnbr = "10";

					gamer nick;
					nick.name = "Nick";
					nick.favnbr = "12";

					gamer[] gamers = { ken, nick };

					foreach (gamer gmr in gamers) {
						Console.WriteLine("0", "1", gmr.name, gmr.favnbr);

					}







				
			
		}
	}
}
