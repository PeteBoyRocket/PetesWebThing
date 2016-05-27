using System.Collections.Generic;
using System.Linq;
using BusinessLogic;

namespace DBRepo
{
	public class CardRepository : ICardRepository
	{
		public IEnumerable<string> GetBlackCards()
		{
			using (var cardsContext = new CardsContext())
			{
				return cardsContext.Blacks.Select(o => o.Sentence).ToList();
			}
		}

		public IEnumerable<string> GetWhiteCards()
		{
			using (var cardsContext = new CardsContext())
			{
				return cardsContext.Whites.Select(o => o.Sentence).ToList();
			}
		}

		public void AddOrUpdateBlackCard(string originalSentence, string newSentence)
		{
			using (var cardsContext = new CardsContext())
			{
				var existingCard = cardsContext.Blacks.SingleOrDefault(o => o.Sentence == originalSentence);
				if (existingCard == null)
				{
					cardsContext.Blacks.Add(new Black { Sentence = newSentence });
				}
				else
				{
					existingCard.Sentence = newSentence;
				}
			}
		}

		public void AddOrUpdateWhiteCard(string originalSentence, string newSentence)
		{
			using (var cardsContext = new CardsContext())
			{
				var existingCard = cardsContext.Whites.SingleOrDefault(o => o.Sentence == originalSentence);
				if (existingCard == null)
				{
					cardsContext.Whites.Add(new White { Sentence = newSentence });
				}
				else
				{
					existingCard.Sentence = newSentence;
				}
			}
		}
	}
}
