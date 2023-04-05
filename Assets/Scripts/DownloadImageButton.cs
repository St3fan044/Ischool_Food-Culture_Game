using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class DownloadImageButton : MonoBehaviour
{

    [DllImport("__Internal")]
    private static extern void ImageDownloader(string str, string fn);
 
    public static byte[] ssData = null;
    public static string imageFilename = "certificate";
    public void DownloadScreenshot(Texture2D image)
    {
        ssData = image.EncodeToPNG();

        if(ssData != null)
        {
            Debug.Log("Downloading..." + imageFilename);
            ImageDownloader(System.Convert.ToBase64String(ssData), imageFilename);
        }
    }

}
