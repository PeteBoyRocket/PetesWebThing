using System.Collections.Generic;

namespace BusinessLogic
{
	public interface ICardRepository
	{
		IEnumerable<string> GetBlackCards();

		IEnumerable<string> GetWhiteCards();
	}
}