using UnityEngine;

public class MagicTower : Tower
{
    void Start()
    {
        range = 8;
        damage = 15;


        Attack();
    }

}