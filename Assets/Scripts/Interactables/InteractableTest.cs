using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTest : Interactable
{
    private WebGLPlugin WebGLPlugin;
    // Start is called before the first frame update
    void Start()
    {
        WebGLPlugin = GetComponent<WebGLPlugin>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        WebGLPlugin.IncreaseCounterFromCSharp();
        //Must be removed before publishing
        Application.ExternalEval("IncreaseCounter();");
    }
}
