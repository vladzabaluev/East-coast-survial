using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : Projectile
{
    [SerializeField] private int _lives = 5;

    protected override void Update()
    {
        base.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<EnemyStats>(out EnemyStats enemyStats))
        {
            _lives--;
            enemyStats.TakeDamage(_rangeCombat.GetDamageValue());
        }
        if (_lives <= 0)
        {
            Destroy(gameObject);
        }
    }
}