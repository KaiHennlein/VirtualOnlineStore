using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InteractableBaseFunctions : Interactable
{
    private WebGLPlugin WebGLPlugin;
    [SerializeField] private Product productInformation;

    // Start is called before the first frame update
    void Start()
    {
        WebGLPlugin = GetComponent<WebGLPlugin>();
        GetProductInformation();
        MaterialChanger();
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

    private void MaterialChanger()
    {
        /*
        List<Texture2D> list = ImageList.images;
        Texture2D texture2D = ImageList.images.First<Texture2D>();

        if (list != null && list.Count > 0)
        {
            foreach (Texture2D texture in list)
            {
                if (texture != null)
                {
                    if (texture.name == productInformation.ImageName)
                    {
                        texture2D = texture;
                    }
                }
            }

            Material material = CreateMaterailFromTexture2D.create(texture2D);

            if (material != null)
            {
                Renderer renderer = GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.material = material;
                }
                else
                {
                    Debug.LogError("GameObject hat no renderer component");
                }
            }
        
        }
        */
    }
}