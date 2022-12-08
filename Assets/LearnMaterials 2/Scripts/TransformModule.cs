using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformModule : AbstractSampleScript
{
    [SerializeField]
    float speed = 1;
    bool sgatie = false;

    

    // Update is called once per frame
    void Update()
    {
        if (sgatie) 
        {
            for (int i = 0; i < transform.childCount; i++) 
            {
                Transform chaid = transform.GetChild(i);

                chaid.localScale -= Vector3.one * speed * Time.deltaTime;

                if (chaid.localScale.magnitude <= speed * Time.deltaTime) 
                {
                    Destroy(chaid.gameObject); 
                }
            }

            if (transform.childCount == 0) 
            sgatie = false;


        }
    }

    [ContextMenu("Активировать")]
    public override void Use()
    {
        sgatie = true;
    }
}
