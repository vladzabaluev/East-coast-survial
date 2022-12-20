using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float _lifeTime;
    private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    protected RangeCombat _rangeCombat;

    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(transform.forward * _speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        _lifeTime -= Time.deltaTime;
        if (_lifeTime < 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetRangeCombat(RangeCombat rangeCombat)
    {
        _rangeCombat = rangeCombat;
    }
}