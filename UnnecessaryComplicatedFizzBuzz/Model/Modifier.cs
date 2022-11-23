using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnnecessaryComplicatedFizzBuzz.Model
{
	public class Modifier
	{
		private uint _divisor;

		public uint Divisor
		{
			get { return _divisor; }
			private set { _divisor = value; }
		}

		private string _word;

		public string Word
		{
			get { return _word; }
			private set { _word = value; }
		}

		public Modifier(uint divisor, string word)
		{
			if (divisor == uint.MinValue) throw new DivideByZeroException("Divisor cannot be zero");

			Divisor = divisor;
			Word = word;
		}

		public bool CanModify(uint input) => input % Divisor == uint.MinValue;

		public string Replace(uint input) => CanModify(input) ? Word : String.Empty;
	}
}
