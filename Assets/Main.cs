using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IronMan ironMan = new IronMan("Tony", 100, "Red");
        Debug.Log($"ironMan name: {ironMan.Name}, hp; {ironMan.Hp}, color: {ironMan.SuitColor}");

        ironMan.Fly();
        ironMan.ShootLaser();
        ironMan.UpdateArmorStrength(5.25f);
    }
}
