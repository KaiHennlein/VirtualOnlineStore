[System.Serializable]
public class Product
{
    public string ProductName;
    public string ProductID;
    public string Category;
    public string ImageName;
    //Cant use getter and setter because JsonUtility from Unity doesnt work with them implemented
}
