using UnityEngine;

class IronMan
{
    //Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorStrength = 10;


    //constructor
    public IronMan(string newName, int newHP, string newsuitColor)
    {
        Name = newName;
        Hp = newHP;
        SuitColor = newsuitColor;
        armorStrength = 10;
    }
    public void Fly()
    {
        Debug.Log($"-----------{Name} is flying!");
    }

    public void ShootLaser()
    {
        Debug.Log($"-----------{Name} is Shoot laser!");
    }

    public void UpdateArmorStrength(float armorStrength)
    {
        armorStrength += armorStrength;
        Debug.Log($"{Name}  Updated their armor to {armorStrength}");
    }
}