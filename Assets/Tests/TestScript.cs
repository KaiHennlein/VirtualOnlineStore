using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using static UnityEditor.Progress;

public class TestScript
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestShoppingCartList()
    {
        // Use the Assert class to test conditions
        ShoppingCartItem item = new ShoppingCartItem();
        ShoppingCartList.shoppingCartItems.Add(item);

        bool test = false;
        if (ShoppingCartList.shoppingCartItems.Count > 0)
        {
            test = true;
        }
        Assert.IsTrue(test);

        ShoppingCartList.shoppingCartItems.Remove(item);
        if (ShoppingCartList.shoppingCartItems.Count != 0)
        {
            test = false;
        }
        Assert.IsTrue(true);
    }

    [Test]
    public void TestTransformProductToShoppingCartItem()
    {
        // Use the Assert class to test conditions
        Product product = new Product();
        product.ProductName = "Test";
        product.ProductID = "f98g0dgf8d09fg8fd0";
        product.ImageName = "Test";
        product.ProductDescription = "Test";

        int amount = 100;

        ShoppingCartItem item = new ShoppingCartItem();
        item = ShoppingCartList.TransformProductToShoppingCartItem(product, amount);

        Assert.IsNotNull(item);
        Assert.AreEqual(product.ProductName, item.ProductName);
        Assert.AreEqual(item.ProductID, product.ProductID);
        Assert.AreEqual(item.Amount, amount);
    }

    [Test]
    public void TestJSONLoader()
    {
        // Use the Assert class to test conditions
        TextAsset[] jsonFiles = Resources.LoadAll<TextAsset>("JSONFiles");
        bool test = false;

        if (jsonFiles != null && jsonFiles.Length > 0)
        {
            test= true;
        }
        Assert.IsTrue(test);

        //Second Part of the Test
        List<Product> products = new List<Product>();

        foreach (TextAsset jsonFile in jsonFiles)
        {
            Product product = new Product();
            product = JsonUtility.FromJson<Product>(jsonFile.text.Trim());
            products.Add(product);
        }

        ProductList.products = products;

        if (products.Count == 0)
        {
            test = false;
        }
        Assert.IsTrue(test);
    }

    [Test]
    public void TestImageLoader()
    {
        string resourceFolder = "Images";
        List<Texture2D> list = new List<Texture2D>();
        Object[] objects = Resources.LoadAll(resourceFolder, typeof(Texture2D));
        bool test = false;

        if (objects != null )
        {
            test = true;
        }
        Assert.IsTrue(test);

        foreach (Object obj in objects)
        {
            if (obj is Texture2D)
            {
                list.Add(obj as Texture2D);
            }
        }

        if (list.Count == 0)
        {
            test = false;
        }
        Assert.IsTrue(test);

        ImageList.images = list;
    }


    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator TestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
