using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeCombat : Combat
{
    private Camera _mainCamera;

    [SerializeField] protected Projectile _projectile;
    [SerializeField] protected Transform _shotPoint;

    // Start is called before the first frame update
    private void Start()
    {
        _mainCamera = Camera.main;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    private void LookAtCursor()
    {
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hittedObject))
        {
            if (hittedObject.transform != transform)
            {
                transform.LookAt(hittedObject.point);
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            }
            //transform.LookAt(hittedObject.point);// - transform.position;
        }
    }
}