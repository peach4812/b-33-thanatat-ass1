using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cap
{
    public string CapName;
    public int CapHp;
    public string CapSuitColor;
    private float capArmorStrength = 10f;

    public Cap(string newName, int newHp, string newSuitColor)

    //Attributes
    {
        CapName = newName;
        CapHp = newHp;
        CapSuitColor = newSuitColor;
    }

    //constructor
    public void LeapAndJump()
    {
        Debug.Log($"--------{CapName} is Leap and Jump!!!");
    }
    public void ThrowShield()
    {
        Debug.Log($"========={CapName} is Trowing Shield!!!");
    }
    public void TakeDamage(int damage)
    {
        CapHp -= damage;
        Debug.Log($"{CapName} take {damage} damage hp: {CapHp}");
    }
}