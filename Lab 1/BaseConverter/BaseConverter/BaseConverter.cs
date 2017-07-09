using System;
namespace BaseConverter
{
	public class BaseConverter
	{
		int number, fromBaseNum, toBaseNum;
		string fromBase, toBase;
		public BaseConverter()
		{
			number = 0;
			fromBase = "Decimal";
			toBase = "Binary";
		}

		public string FromBase
		{
			set
			{
				fromBase = value;
			}
			get
			{
				return fromBase;
			}
		}

		public string ToBase
		{
			set
			{
				toBase = value;
			}
			get
			{
				return toBase;
			}
		}

		public int Number
		{
			set
			{
				number = value;
			}
			get
			{
				return number;
			}
		}

		int FromBaseNum
		{
			get
			{
				if (FromBase == "Decimal")
				{
					fromBaseNum = 10;
				}
				else if (FromBase == "Binary")
				{
					fromBaseNum = 2;
				}
				else if (FromBase == "Hexadecimal")
				{
					fromBaseNum = 16;
				}
				else {
					fromBaseNum = 8;
				}
				return fromBaseNum;
			}
		}

		int ToBaseNum
		{
			get
			{
				if (toBase == "Decimal")
				{
					toBaseNum = 10;
				}
				else if (toBase == "Binary")
				{
					toBaseNum = 2;
				}
				else if (toBase == "Hexadecimal")
				{
					toBaseNum = 16;
				}
				else {
					toBaseNum = 8;
				}
				return toBaseNum;
			}
		}

		public override string ToString()
		{
			return string.Format("[BaseConverter: FromBase={0}, ToBase={1}, Number={2}, FinalResult = {3}]", FromBase, ToBase, Number, FinalResult);
		}

		string FinalResult
		{
			get
			{
				return Convert.ToString(Convert.ToInt32(Number.ToString(), FromBaseNum), ToBaseNum);
			}
		}

		public void printResult()
		{
			Console.WriteLine("Initial Number: " + Number);
			Console.WriteLine("Initial Base: " + FromBase);
			Console.WriteLine("Final Base: " + ToBase);
			Console.WriteLine("Final Base: " + FinalResult);
		}

		public void clear()
		{
			number = 0;
			fromBase = "Decimal";
			toBase = "Binary";
		}
	}
}

