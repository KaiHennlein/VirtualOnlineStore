using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86.Avx;

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

    private void Add()
    {
        GameObject template = (GameObject)Instantiate(ShoppingCartItemTemplate);
        template.transform.SetParent(ShoppingCartListView.transform);
    }

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

    public void UpdateShoppingCartList()
    {
        //ClearAllObjectsFromScrollView();

        if (ShoppingCartList.shoppingCartItems.Count > 0)
        {
            foreach (ShoppingCartItem Item in ShoppingCartList.shoppingCartItems)
            {
                AddItemWithData(Item);
            }
        }
    }

    public void ClearAllObjectsFromScrollView()
    {
        //ScrollRect scrollRect = ShoppingCartListView.GetComponent<ScrollRect>();
        //ebug.Log("");
    }
}
