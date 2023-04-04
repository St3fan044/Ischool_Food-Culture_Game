using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Dowload_Button : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Download();

    public void Dowload_Image(string src)
    {
        Download();
    }
}
