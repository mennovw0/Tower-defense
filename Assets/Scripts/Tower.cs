using UnityEngine;

public class Tower : MonoBehaviour
{
    protected int damage;
    protected float range;
    protected float attackSpeed;

    protected float cooldown = 2;

    private float nextAttackTime;

    protected LayerMask enemyLayer;

    private void Update()
    {
        if (Time.time < nextAttackTime) 
        {
            return;
        }

        Transform targetTransform = GetTarget();

        if (targetTransform != null)
        {
            Attack(targetTransform);
        }

        nextAttackTime = Time.time + cooldown;
    }

    protected virtual void Attack(Transform target)
    {
        Debug.Log("attack target: " + transform.name);
    }

    private Transform GetTarget()
    {
        Collider[] enemies = Physics.OverlapSphere(transform.position, range, enemyLayer);
        if (enemies.Length > 0)
        {
            return enemies[0].transform;
        }
        else 
        {
        return null;
        }
    }
}
