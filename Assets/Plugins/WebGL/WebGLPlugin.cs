using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class WebGLPlugin : MonoBehaviour
{
    // Dieser Counter wird in Unity verwaltet
    private int counter = 0;

    // Aufrufen der JavaScript-Funktion, um den Counter in der HTML-Oberfläche zu erhöhen
    public void IncreaseCounterFromCSharp()
    {
        counter++;
        SendCounterData(counter); // Aufruf der JavaScript-Funktion
        Debug.Log(counter);
    }

    [DllImport("__Internal")]
    private static extern void SendCounterData(int counterData);
}
