using System;
using System.Linq;

namespace BusinessLogic
{
    public class CardHandler
    {
        private readonly ICardRepository _cardRepository;
        // private readonly Random _random = new Random();

        public CardHandler(ICardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public string GetBlackCard()
        {
            var cards = _cardRepository.GetBlackCards();
            var index = new Random().Next(cards.Count());

            return cards.ElementAt(index);
        }

        public string GetWhiteCard()
        {
            var cards = _cardRepository.GetWhiteCards();
            var index = new Random().Next(cards.Count());

            return cards.ElementAt(index);
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