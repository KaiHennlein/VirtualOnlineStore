[System.Serializable]
public class Product
{
    //Cant use getter and setter because JsonUtility from Unity doesnt work with them implemented
    public string ProductName;
    public string ProductID;
    public string Category;
    public string ImageName;
    public string ProductDescription;
}
