using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageLoader : MonoBehaviour
{
    //Loads all Images from the resource folder
    private void Awake()
    {
        string resourceFolder = "Images";
        Debug.Log("Loading product pictures");
        List<Texture2D> list = new List<Texture2D>();
        Object[] objects = Resources.LoadAll(resourceFolder, typeof(Texture2D));

        foreach (Object obj in objects)
        {
            if (obj is Texture2D)
            {
                list.Add(obj as Texture2D);
            }
        }

        if (list.Count < 0)
        {
            Debug.Log("Error 404 Images not found!");
        }

        ImageList.images = list;
    }
}
