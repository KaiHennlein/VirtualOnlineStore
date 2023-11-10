using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONLoader : MonoBehaviour
{
    //Loading JSONs for prototyping. Later data comes from an API

    private List<Product> products = new List<Product>();

    public void Awake()
    {
        TextAsset[] jsonFiles = Resources.LoadAll<TextAsset>("JSONFiles");

        if (jsonFiles != null)
        {
            foreach (TextAsset jsonFile in jsonFiles)
            {
                Product product = new Product();
                product = JsonUtility.FromJson<Product>(jsonFile.text.Trim());
                products.Add(product);
            }

            ProductList.products = products;
        }
        else
        {
            Debug.LogWarning("JSON files could not be loaded");
        }
    }
}
