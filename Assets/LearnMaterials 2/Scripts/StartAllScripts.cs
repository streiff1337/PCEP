using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StartAllScripts : MonoBehaviour
{
    public List<AbstractSampleScript> sampleScripts;
    [ContextMenu("Активировать")]
    public void StartAllScript()
    {
        foreach(var sampleScript in sampleScripts)
        {
            sampleScript.Use();
        }
    }
}
