using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        Debug.Log("*** Superheros fight!!!!");

        //Main character
        Cap captainAmerica = new Cap("Roger", 100, "Blue");
        IronMan ironMan = new IronMan("Stark", 100, "Red");

        //Show on screen
        Debug.Log($"IronMan name: {ironMan.IronName}, Hp: {ironMan.IronHp}, Suit Color: {ironMan.IronSuitColor}");
        Debug.Log($"CaptainAmerica name: {captainAmerica.CapName}, Hp: {captainAmerica.CapHp}, Suit Color: {captainAmerica.CapSuitColor}");
        for (int i = 0; i < 5; i++)
        {
            //move
            ironMan.ShootLaser();
            int randomvalue = Random.Range(10, 21);

            captainAmerica.TakeDamage(randomvalue);
            captainAmerica.ThrowShield();

            randomvalue = Random.Range(10, 21);
            ironMan.TakeDamage(randomvalue);
        }

    }
}