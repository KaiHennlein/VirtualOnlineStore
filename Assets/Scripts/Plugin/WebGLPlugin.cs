using UnityEngine;
using System.Runtime.InteropServices;
using Unity.VisualScripting;

public class WebGLPlugin : MonoBehaviour 
{
    public static WebGLPlugin Instance;
    // Dieser Counter wird in Unity verwaltet
    private int counter = 0;

    // Aufrufen der JavaScript-Funktion, um den Counter in der HTML-Oberfläche zu erhöhen
    public void IncreaseCounterFromCSharp()
    {
        counter++;
        SendCounterData(counter); // Aufruf der JavaScript-Funktion
        Debug.Log(counter);
    }

    public void SendCartDataToHTML(string ProductName, string ProductID, int Amount)
    {
        SendCartData(ProductName, ProductID, Amount);
    }

    [DllImport("__Internal")]
    private static extern void SendCounterData(int counterData);
    [DllImport("__Internal")]
    private static extern void SendCartData(string ProductName, string ProductID, int Amount);

}
