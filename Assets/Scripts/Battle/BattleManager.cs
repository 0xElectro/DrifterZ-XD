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

    public List<Card> hand = new List<Card>();

    void Start()
    {
        Debug.Log("Battle started!");
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
        Debug.Log("Turn " + turn);
    }
}