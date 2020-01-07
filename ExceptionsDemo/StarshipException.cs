using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
	[Serializable]
	class StarshipException : ApplicationException
	{
		public StarshipException() : base(String.Format("Oh no! Something went wrong! Exception!")) { }
		public StarshipException(string message) : base(String.Format("Oh no! {0} could not be added to the roster!", message))	{ }
	}
}
