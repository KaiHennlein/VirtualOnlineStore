using System.Collections.Generic;

public static class ShoppingCartList
{
    public static List<ShoppingCartItem> shoppingCartItems = new List<ShoppingCartItem>();

    public static ShoppingCartItem TransformProductToShoppingCartItem(Product product, int amount)
    {
        ShoppingCartItem shoppingCartItem = new ShoppingCartItem();
        shoppingCartItem.ProductName = product.ProductName;
        shoppingCartItem.ProductID = product.ProductID;
        shoppingCartItem.Amount = amount;
        return shoppingCartItem;
    }
}
