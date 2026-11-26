using UnityEngine;

public class MagicTower : Tower
{
    void Start()
    {
        range = 8;
        damage = 15;
    }

    protected override void Attack(Transform target)
    {

    }

}