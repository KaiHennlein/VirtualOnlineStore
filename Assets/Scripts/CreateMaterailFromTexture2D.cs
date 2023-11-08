using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CreateMaterailFromTexture2D
{
    //Create a Unity material from a Texture2D
    public static Material create(Texture2D texture)
    {
        Material mat = new Material(Shader.Find("Standard"));
        mat.mainTexture = texture;

        return mat;
    } 
}
