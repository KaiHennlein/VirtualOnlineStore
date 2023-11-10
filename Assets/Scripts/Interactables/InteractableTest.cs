using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InteractableTest : Interactable
{
    private WebGLPlugin WebGLPlugin;
    [SerializeField] private Product productInformation;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(ProductList.products.Count);
        WebGLPlugin = GetComponent<WebGLPlugin>();
        GetProductInformation();
        Debug.Log(productInformation.ProductName);
        Debug.Log(ProductList.products.Count);
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

    private void GetProductInformation()
    {
        Product product = ProductList.products.First<Product>();
        if (product != null)
        {
            productInformation = product;
            ProductList.products.Remove(product);
        }
    }
}
