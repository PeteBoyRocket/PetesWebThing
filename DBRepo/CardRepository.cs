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
				return cardsContext.Blacks.Select(o => o.Sentence);
			}
		}
	}
}
