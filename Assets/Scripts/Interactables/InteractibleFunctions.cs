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

    public static void ToggleProductDetailsUI(Product product, Texture2D productImage)
    {
        UIController.instance.ToggleProductdetails(product, productImage);
    }
}
