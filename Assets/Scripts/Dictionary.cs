using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static Card;

public class Dictionary : MonoBehaviour
{
    private List<Card> Cards;
    private int CardCount = 0;

    public Dictionary(List<Card> c)
    {
        Cards = c;
        CardCount = Cards.Count;
    }

    public void AddCard(Card card)
    {
        Cards.Add(card);
        CardCount += 1;
    }

    public void Alphabetize()
    {
        Cards = Cards.OrderBy(card => card.GetText()).ToList();
    }

    public void LogCards(bool full_info)
    {
        foreach (Card c in Cards) 
        {
            c.LogCard(full_info);
        }
    }

    public int GetCardCount()
    {
        return CardCount;
    }

    public List<Card> GetAllCards()
    {
        return Cards;
    }
}
