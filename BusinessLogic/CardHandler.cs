using System.Linq;

namespace BusinessLogic
{
	public class CardHandler
	{
		private readonly ICardRepository _cardRepository;

		public CardHandler(ICardRepository cardRepository)
		{
			_cardRepository = cardRepository;
		}

		public string GetBlackCard()
		{
			return _cardRepository.GetBlackCards().FirstOrDefault();
		}

		public string GetWhiteCard()
		{
			return _cardRepository.GetWhiteCards().FirstOrDefault();
		}

		public void AddBlackCard(string sentence)
		{
			_cardRepository.AddOrUpdateBlackCard(null, sentence);
		}

		public void AddWhiteCard(string sentence)
		{
			_cardRepository.AddOrUpdateWhiteCard(null, sentence);
		}

		public void UpdateBlackCard(string originalSentence, string newSentence)
		{
			_cardRepository.AddOrUpdateBlackCard(originalSentence, newSentence);
		}

		public void UpdateWhiteCard(string originalSentence, string newSentence)
		{
			_cardRepository.AddOrUpdateWhiteCard(originalSentence, newSentence);
		}
	}
}