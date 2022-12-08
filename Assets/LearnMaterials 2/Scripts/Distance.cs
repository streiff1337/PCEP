using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : AbstractSampleScript
{
    public GameObject prefab;

    [Range(1f, 3f)]
    public int sumCopy;

    [Min((float)0.1)]
    public float distance;

    [ContextMenu("Активировать")]
    public override void Use()
    {
        for (int i = 0; i < sumCopy; i++)
        {
            Instantiate(prefab, transform.position + transform.forward * (i + 1) * distance, Quaternion.identity);
        }
    }
}
