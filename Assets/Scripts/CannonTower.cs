using UnityEngine;

public class CannonTower : Tower
{
    void Start()
    {
        range = 3;
        damage = 25;
    }

    protected override void Attack(Transform target)
    {

    }

}