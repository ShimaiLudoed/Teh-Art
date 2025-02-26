using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    public Material dissolveMaterial;
    public float dissolveSpeed = 1.0f;

    private void Update()
    {
        if (dissolveMaterial != null)
        {
            float currentDissolveAmount = dissolveMaterial.GetFloat("_DissolveAmount");
            currentDissolveAmount += Time.deltaTime * dissolveSpeed;
            if (currentDissolveAmount > 1)
                currentDissolveAmount = 3; 
            dissolveMaterial.SetFloat("_DissolveAmount", currentDissolveAmount);
        }
    }
}
