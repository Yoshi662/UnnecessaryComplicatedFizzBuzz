using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnnecessaryComplicatedFizzBuzz.Model;

namespace UnnecessaryComplicatedFizzBuzz
{
	public class FizzEngine
	{
		private uint _limit;

		public uint Limit
		{
			get { return _limit; }
			private set { _limit = value; }
		}

		private List<Modifier> _modifiers;

		public List<Modifier> Modifiers
		{
			get { return _modifiers; }
			set { _modifiers = value; }
		}

		public FizzEngine(uint limit, List<Modifier> modifiers)
		{
			Limit = limit;
			Modifiers = modifiers ?? throw new ArgumentNullException(nameof(modifiers));

			Modifiers.Sort((d1, d2) => (int)(d1.Divisor - d2.Divisor));
		}

		public string Compute()
		{
			StringBuilder sb = new();
			for (uint i = uint.MinValue; i < Limit; i++)
			{
				bool IsModified = false;

				foreach (var mod in Modifiers)
				{
					if (mod.CanModify(i))
					{
						IsModified = true;
						break;
					}
				}

				if (IsModified)
				{
					foreach (var mod in Modifiers)
					{
						if (mod.CanModify(i)) //Modifer.Replace Includes the CanModify Method. But just in case.
						{
							sb.Append(mod.Replace(i));
						}
					}
					sb.Append("\n");
				}
				else
				{
					sb.AppendLine($"{i}");
				}
			}
			return sb.ToString();
		}

		public override string ToString() => Compute();

	}
}
