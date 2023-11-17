using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.UI;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86.Avx;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public GameObject Productdetails;
    private Product product;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            
            Productdetails.SetActive(false);
        }
        else
        {
            Destroy(Productdetails);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleProductdetails(Product product1, Texture2D productImage)
    {
        product = product1;

        if (Productdetails.activeSelf) 
        { 
            Productdetails.SetActive(false);
        }
        else
        {
            Productdetails.SetActive(true);
            GameObject inputfield = GameObject.Find("InputField (TMP)");
            inputfield.GetComponent<TMP_InputField>().text = "1";
            
            GameObject productName = GameObject.Find("ProductName (TMP)");
            TextMeshProUGUI textMeshProProductName = productName.GetComponent<TextMeshProUGUI>();
            textMeshProProductName.text = product.ProductName;
            GameObject productDetailsUI = GameObject.Find("ProductDescription (TMP)");
            TextMeshProUGUI textMeshProProductDetails = productDetailsUI.GetComponent<TextMeshProUGUI>();
            textMeshProProductDetails.text = product.ProductDescription;


            GameObject productImageUI = GameObject.Find("ProductImage");
            Image image = productImageUI.GetComponent<Image>();
            image.material = CreateMaterailFromTexture2D.create(productImage);
        }
    }

    public void CloseUI()
    {
        Productdetails.SetActive(false);
    }

    public void AddToCart()
    {
        GameObject inputfield = GameObject.Find("InputField (TMP)");
        string inputText = inputfield.GetComponent<TMP_InputField>().text;
        try
        {
            int amount = Int32.Parse(inputText);
            if (amount > 0)
            {
                ShoppingCartItem shoppingCartItem = ShoppingCartList.TransformProductToShoppingCartItem(product, amount);
                ShoppingCartList.shoppingCartItems.Add(shoppingCartItem);
                ScrollViewManager.instance.UpdateShoppingCartList();
            }
        }
        catch
        {
            Debug.LogError("Produkt konnte nicht zum Warenkorb hinzugefügt werden.");
        }
    }
}
