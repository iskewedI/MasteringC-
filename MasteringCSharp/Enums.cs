using System;

namespace MasteringCSharp
{
	public class Enums
	{
        public enum EnumExample
		{
			PropertyOne = 1,
			PropertyTwo = 2
		}
		
		public void Main()
		{
			var propertyOneValue = EnumExample.PropertyOne;
			Console.WriteLine((int)propertyOneValue); //1
			Console.WriteLine(propertyOneValue.ToString()); //"PropertyOne"

			int propertyNumber = 2;
			Console.WriteLine((EnumExample)propertyNumber); // "PropertyTwo"

		}

	}
}

