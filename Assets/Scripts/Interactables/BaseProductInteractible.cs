using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BaseProductInteractible : Interactable
{
    private WebGLPlugin WebGLPlugin;
    [SerializeField] private string category = "Bottle";
    [SerializeField] private Product productInformation;
    private Texture2D texture2D = ImageList.images.First<Texture2D>();

    // Start is called before the first frame update
    void Start()
    {
        WebGLPlugin = GetComponent<WebGLPlugin>();
        productInformation = InteractibleFunctions.GetProductInformation(category);
        MaterialChanger();
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected override void Interact()
    {
        Debug.Log("Interacted with " + gameObject.name);
        InteractibleFunctions.ToggleProductDetailsUI(productInformation, texture2D);
        WebGLPlugin.IncreaseCounterFromCSharp();
    }

    private void MaterialChanger()
    {
        List<Texture2D> list = ImageList.images;

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
    }
}
