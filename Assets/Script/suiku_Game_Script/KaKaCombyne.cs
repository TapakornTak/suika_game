using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaKaCombyne : MonoBehaviour
{
    private int _layerIndex;
    private KaKaInfo _info;

    private void Awake()
    {
        _info = GetComponent<KaKaInfo>(); 
        _layerIndex = gameObject.layer;
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.layer == _layerIndex)
    //    {
    //        KaKaInfo info = collision.gameObject.GetComponent<KaKaInfo>(); 

    //        if (info != null)
    //        {
    //            if (info.KaKaIndex == _info.KaKaIndex)
    //            {
    //                int thisID = gameObject.GetInstanceID();
    //                int otherID = collision.gameObject.GetInstanceID();
    //                if (thisID > otherID)
    //                {
    //                    if (_info.KaKaIndex == FruitSelector.instance.Fruits.Length - 1)
    //                    {
    //                        Destroy(collision.gameObject);
    //                        Destroy(gameObject);
    //                    }
    //                    else
    //                    {
    //                        Vector3 middlePosition = (transform.position + collision.transform.position) / 2f ;
    //                    }
    //                }
    //            }
    //        }
    //    }
    //}
}