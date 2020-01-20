using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessWithWallMat : MonoBehaviour
{
    public Renderer holoRenderer;

    void Start()
    {
        holoRenderer = GetComponent<Renderer>();
        holoRenderer.material.SetFloat("_Amount", 1f);
    }

    void Update()
    {
        
    }
}
