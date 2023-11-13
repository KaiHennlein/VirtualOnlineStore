using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class InteractibleFunctions
{
    public static Product GetProductInformation(string category)
    {
        Product productInformation = ProductList.products.First<Product>();

        foreach (Product p in ProductList.products)
        {
            if (p.Category == category)
            {
                productInformation = p;
                break;
            }
        }

        //ProductList.products.Remove(productInformation);

        return productInformation;
    }
}
