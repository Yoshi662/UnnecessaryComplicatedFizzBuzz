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

		private string _output;

		public string Output
		{
			get { return _output; }
			private set { _output = value; }
		}

		public Modifier(uint divisor, string output)
		{
			if (divisor == uint.MinValue) throw new DivideByZeroException("Divisor cannot be zero");

			Divisor = divisor;
			Output = output;
		}

		public bool CanModify(uint input) => input % Divisor == uint.MinValue;

		public string Replace(uint input) => CanModify(input) ? Output : input.ToString();
	}
}
