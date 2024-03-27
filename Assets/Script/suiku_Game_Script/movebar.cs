using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebar : MonoBehaviour
{
    private bool isDragging = false;

    public float moveSpeed = 2f;

    public Rigidbody2D rb;

    private Vector2 lastPosition;

    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 currentPosition = transform.position;
        Vector2 deltaPosition = currentPosition - lastPosition;

        float deltaX = deltaPosition.x;
        float deltay = deltaPosition.y;

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);

            if (hitCollider != null && hitCollider.gameObject == gameObject)
            {
                isDragging = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            Vector2 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (targetPosition - (Vector2)transform.position).normalized;

            rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

}
