using System;

//Reference Pg. 272 of the C# 7 book for custom exceptions
namespace ExceptionsDemo
{
	[Serializable]
	class StarshipException : ApplicationException
	{
		public StarshipException() { }
		public StarshipException(string message) : base(message) { }
		public StarshipException(string message,
			System.Exception inner) : base(message, inner) { }
		protected StarshipException(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }

	}
}
