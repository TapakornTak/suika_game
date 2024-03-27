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
            Debug.LogError("Image component ���١��˹�������¡��ҹ");
            return;
        }

        if (sprites == null || sprites.Length == 0)
        {
            Debug.LogError("������ٻ�Ҿ㹵���� sprites");
            return;
        }

        image.sprite = sprites[0];
    }

    public void ShowImage(int imageIndex)
    {
        if (imageIndex < 0 || imageIndex > 5)
        {
            Debug.LogError("Index ���١��ͧ");
            return;
        }

        image.sprite = sprites[imageIndex - 1];
    }
}
