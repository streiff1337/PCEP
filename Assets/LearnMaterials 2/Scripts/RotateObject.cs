using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : AbstractSampleScript
{
    [SerializeField] private int RotationSpeed;
    [SerializeField] private Vector3 RotationDegree;
    private bool Rotation;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Rotation == true)
        {
            if (Quaternion.Angle(Quaternion.Euler(RotationDegree), transform.rotation) > 3)
            {
                transform.Rotate(RotationDegree, RotationSpeed * Time.deltaTime, 0);
            }
            else
            {
                transform.rotation = Quaternion.Euler(RotationDegree);
                Rotation = false;
            }
        }
    }
    
    public override void Use()
    {
        Rotation = true;
    }
}
