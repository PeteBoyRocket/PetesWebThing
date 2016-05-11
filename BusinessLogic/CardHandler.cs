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
	}
}
