using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    bool canJump;
    // Start is called before the first frame update
    void Start()
    {

        



    }

    // Update is called once per frame
    void Update()
    {
        // gameObject.transform.position = new Vector3(gameObject.transform.position.x + 50f * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);


        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f *   Time.deltaTime,0));

        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(1000f * Time.deltaTime, 0));
        }


        if (Input.GetKeyDown("up")&& canJump)
        {

            canJump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,500f));
        }



    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag=="piso" || collision.transform.tag=="plataforma")
        {
            canJump = true;
        }
    }




}
