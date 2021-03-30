using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_Binary_Conversion
{
	class Program
	{
		static void Main(string[] args)
		{


			bool IsContinue = true;



			while (IsContinue)
			{
				bool IsNumber;
				bool IsInRange;
				Console.WriteLine("Please enter a whole number between 0 and 255 and it will be converted to binary.");


				string _input = Console.ReadLine();


				int _number;

				IsNumber = Int32.TryParse(_input, out _number);


				if (IsNumber == false) { IsContinue = true; }

			

				if (_number <= 255 && _number >= 0) { IsInRange = true; } else { IsInRange = false; }

				if (IsInRange == false) { IsContinue = true; }



				string _binary = Convert.ToString(_number, 2);



				Console.WriteLine("Number {0} converts to {1} in binary.", _number, _binary);

				Console.WriteLine("Press x to exit program or c to continue converting.");

				char _xOrc = Console.ReadKey().KeyChar;

				if (Char.ToLower(_xOrc) == 'x') { IsContinue = false; }


				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();













			}
		}
	}
}
