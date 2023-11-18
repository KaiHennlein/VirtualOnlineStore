using System.Linq;
using TMPro;
using UnityEngine;

public class ScrollViewManager : MonoBehaviour
{
    public static ScrollViewManager instance;
    public GameObject ShoppingCartListView;
    public GameObject ShoppingCartItemTemplate;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(ShoppingCartListView);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Add items to the shoppingcart
    private void AddItemWithData(ShoppingCartItem item)
    {
        GameObject template = (GameObject)Instantiate(ShoppingCartItemTemplate);

        Transform productNameObject = template.transform.Find("ProductName (TMP)");
        TextMeshProUGUI productName = productNameObject.GetComponent<TextMeshProUGUI>();
        productName.text = item.ProductName;

        Transform amountObject = template.transform.Find("Text (TMP)");
        TextMeshProUGUI amount = amountObject.GetComponent<TextMeshProUGUI>();
        amount.text = item.Amount.ToString();
        
        template.transform.SetParent(ShoppingCartListView.transform);
    }

    //updating scrollview contende be clearing and repopulating 
    public void UpdateShoppingCartList()
    {
        Transform transform = ShoppingCartListView.transform;
        var children = transform.Cast<Transform>().ToArray();
        foreach ( var child in children)
        {
            Object.DestroyImmediate(child.gameObject);
        }

        if (ShoppingCartList.shoppingCartItems.Count > 0)
        {
            foreach (ShoppingCartItem Item in ShoppingCartList.shoppingCartItems)
            {
                AddItemWithData(Item);
            }
        }
    }
}
