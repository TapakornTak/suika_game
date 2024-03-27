using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kakacon : MonoBehaviour
{
    private string intheplayer = "y";
    //public Button yourButton;

    void Start()
    {
         if (transform.position.y <2.7)
        {
            intheplayer = "n";
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
    }

   
    void Update()
    {
        if (intheplayer=="y") 
        {
            GetComponent<Transform>().position = movespawn.playerxPos;
        }

        if (movespawn.cbot == "n")
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            intheplayer = "n";
            
            //movespawn.spawnedYet = "n";
        }

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    GetComponent<Rigidbody2D>().gravityScale = 1;
        //    intheplayer = "n";
        //    //movespawn.spawnedYet = "n";
        //}
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "10")
        {
            Debug.Log("kaka");
        }

        else if (collision.gameObject.tag == gameObject.tag)
        { 
            movespawn.spawnPos = transform.position;
            movespawn.newkaka = "y";
            movespawn.whichkaka = int.Parse(gameObject.tag);
            Destroy(gameObject); 
        } 
    }

}
