using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movespawn : MonoBehaviour
{
    private bool isDragging = false;

    public float moveSpeed = 2f;

    public Rigidbody2D rb;

    private Vector2 lastPosition;

    Vector2 movement;
    public AudioClip clickSound;
    private AudioSource audioSource;


    public Transform[] kakaobj;
    static public string spawnedYet = "n";
    static public Vector2 playerxPos;
    static public Vector2 spawnPos;
    static public string newkaka = "n";
    static public int whichkaka = 0;
    static public string cbot = "y";

    public Button yourButton;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        Spawnkaka();
        replaceKaka(); 

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

        playerxPos = transform.position;

        yourButton.onClick.AddListener(TaskOnClick);
        

        if ((cbot == "n") && (spawnedYet == "y"))
        {
            spawnedYet = "n";
        }

        //if ((Input.GetKeyDown(KeyCode.Space)) && (spawnedYet == "y"))
        //{
        //    spawnedYet = "n";
        //}
    }

    void replaceKaka()
    {
        if(newkaka == "y")
        {
            newkaka = "n";
            Instantiate(kakaobj[whichkaka + 1], spawnPos, kakaobj[0].rotation);
        }
    }

    void Spawnkaka()
    {
        if (spawnedYet == "n")
        {
            StartCoroutine(spawntimer());
            cbot = "y";
            spawnedYet = "w";
        }
    }

    IEnumerator spawntimer()
    {
        yield return new WaitForSeconds(.75f);
        Instantiate(kakaobj[Random.Range(0,5)], transform.position, kakaobj[0].rotation);
        spawnedYet = "y";
    }

    void TaskOnClick()
    {
        cbot = "n";
        //audioSource.PlayOneShot(clickSound);
    }
}
