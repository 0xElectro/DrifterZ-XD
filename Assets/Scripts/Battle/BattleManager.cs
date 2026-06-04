using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class BattleManager : MonoBehaviour
{
    public int drifterHP = 18;
    public int companionHP = 28;
    public int enemyHP = 100;
    public int grit = 3;
    public int turn = 1;
    public Card[] allCards;
    public List<Card> hand = new List<Card>();

    void Start()
    {
    if (allCards == null || allCards.Length == 0)
    {
        Debug.LogWarning("No cards assigned to All Cards!");
        return;
    }

    Debug.Log("Loading " + allCards.Length + " cards");
    DrawCards(5);
    } 
   public void DrawCards(int count)
    {
    for (int i = 0; i < count; i++)
        {
        if (allCards.Length == 0)
            break;

        Card randomCard =
            allCards[Random.Range(0, allCards.Length)];

        hand.Add(randomCard);

        Debug.Log("Drew: " + randomCard.data.cardName);
        }
    }
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            EndTurn();
        }
    }

    public void EndTurn()
{
    turn++;

    grit = 3;

    hand.Clear();

    DrawCards(2);

    Debug.Log("Turn " + turn);
    Debug.Log("Enemy HP: " + enemyHP);
}
}