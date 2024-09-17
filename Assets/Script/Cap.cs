using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class CaptainAmerica : SuperHero
{
    public CaptainAmerica(string newName, int newHp, string newSuitColor) : base(newName, newHp, newSuitColor)
    {

    }

    public void LeapAndJump()
    {
        Debug.Log($"--------{Name} is Leap and Jump!!!");

    }
    public void ThrowShield()
    {
        Debug.Log($"========={Name} is Trowing Shield!!!");

    }
}