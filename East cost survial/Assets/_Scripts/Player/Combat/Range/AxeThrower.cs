using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeThrower : RangeCombat
{
    protected override void Update()
    {
        base.Update();
        if (_attackCooldown < 0)
        {
            Projectile projectile = Instantiate(_projectile, _shotPoint.position, transform.rotation);

            projectile.SetRangeCombat(this);
            //Debug.Log(_targetPoint);
            //Debug.Log(_shotPoint.position);
            projectile.SetTarget(_targetPoint);
            //projectile.AddStartImpulse(_targetPoint/* - _shotPoint.position*/);
            _attackCooldown = 1 / _attackPerSecond;
        }
    }
}