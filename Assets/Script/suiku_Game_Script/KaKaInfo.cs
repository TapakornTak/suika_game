using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaKaInfo : MonoBehaviour
{
    public int KaKaIndex = 0;
    public int PointsWhenAnnihilated = 1; 

    public float KaKaMass = 1f;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.mass = KaKaMass;
    }
}
