using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shownext : MonoBehaviour
{
    public Image image;
    public Sprite[] sprites; 

    void Start()
    {
        if (image == null)
        {
            Debug.LogError("Image component ไม่ถูกกำหนดให้เรียกใช้งาน");
            return;
        }

        if (sprites == null || sprites.Length == 0)
        {
            Debug.LogError("ไม่มีรูปภาพในตัวแปร sprites");
            return;
        }

        image.sprite = sprites[0];
    }

    public void ShowImage(int imageIndex)
    {
        if (imageIndex < 0 || imageIndex > 5)
        {
            Debug.LogError("Index ไม่ถูกต้อง");
            return;
        }

        image.sprite = sprites[imageIndex - 1];
    }
}
