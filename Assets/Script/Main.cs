using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Main : MonoBehaviour

{
    IronMan ironMan = new IronMan("Tony", 100, "Red");
    CaptainAmerica captainAmerica = new CaptainAmerica("Steven", 100, "Blue");
    void Start()
    {
     
        Debug.Log($"IronMan name: {ironMan.Name}, Hp: {ironMan.Hp}, Suit Color: {ironMan.SuitColor}");
        Debug.Log($"CaptainAmerica name: {captainAmerica.Name}, Hp: {captainAmerica.Hp}, Suit Color: {captainAmerica.SuitColor}");

        ironMan.UpdateArmor(5.25f);
        captainAmerica.UpdateArmor(5.5f);

    }

    private void update()
    {
        

        if (!ironMan.IsDead() && !captainAmerica.IsDead())
        {
            return;
        }
        {

            int randomDamage = Random.Range(10, 21);
            ironMan.ShootLaser();
            captainAmerica.TakeDamage(randomDamage);
            

            randomDamage = Random.Range(10, 21);
            ironMan.TakeDamage(randomDamage);
            captainAmerica.ThrowShield();
        }
    }

