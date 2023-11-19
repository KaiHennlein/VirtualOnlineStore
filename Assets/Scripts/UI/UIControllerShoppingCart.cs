using UnityEngine;

public class UIControllerShoppingCart : MonoBehaviour
{
    public static UIControllerShoppingCart instance;
    private GameObject ShoppingCartUI;

    // Start is called before the first frame update
    void Start()
    {
        ShoppingCartUI = GameObject.Find("ShoppingCart");

        if (instance == null)
        {
            instance = this;

            ShoppingCartUI.SetActive(false);
        }
        else
        {
            Destroy(ShoppingCartUI);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleShoppingCart()
    {
        if (ShoppingCartUI.activeSelf)
        {
            ShoppingCartUI.SetActive(false);
        }
        else
        {
            ShoppingCartUI.SetActive(true);
        }
    }

    public void CloseUI()
    {
        ShoppingCartUI.SetActive(false);
    }

    public void SendCartDataToHTML()
    {
        WebGLPlugin webGLPlugin = WebGLPlugin.Instance;

        foreach (ShoppingCartItem item in ShoppingCartList.shoppingCartItems)
        {
            webGLPlugin.SendCartDataToHTML(item.ProductName, item.ProductID, item.Amount);
        }
    }
}
