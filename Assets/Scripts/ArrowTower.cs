using UnityEngine;

public class ArrowTower : Tower
{
    protected override void Attack(Transform target)
    {
        target.name = "Wonka";
    }

}