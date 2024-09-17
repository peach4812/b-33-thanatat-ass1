using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class IronMan : SuperHero
{
    public IronMan(string newName, int newHp, string newSuitColor) : base(newName, newHp, newSuitColor)
    {

    }

    public void Fly()
    {
        Debug.Log($"--------{GetName()} is Flying!!!");
    }
    public void ShootLaser()
    {
        Debug.Log($"========{name} is Shooting Lasers!");
    }
}