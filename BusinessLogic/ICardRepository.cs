using System.Collections.Generic;

namespace BusinessLogic
{
	public interface ICardRepository
	{
		IEnumerable<string> GetBlackCards();

		IEnumerable<string> GetWhiteCards();

		void AddOrUpdateBlackCard(string originalSentence, string newSentence);

		void AddOrUpdateWhiteCard(string originalSentence, string newSentence);
	}
}