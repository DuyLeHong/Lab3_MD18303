using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "coin")
        {
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Va cham voi: " + other.gameObject.tag);
    }

    // Start is called before the first frame update
    Rigidbody2D rigidbody2D;
    Transform transform;

    void Start()
    {
        rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        transform = this.gameObject.GetComponent<Transform>();
    }

    float movePrefix = 3;

    float xMove = 0;


    // Update is called once per frame
    void Update()
    {
        //xMove = Input.GetAxisRaw("Horizontal"); // an phim trai phai

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.AddForce(Vector2.up * movePrefix, ForceMode2D.Impulse);
            //rigidbody2D.velocity = Vector2.up * movePrefix;
            //transform.Translate(Vector3.up * movePrefix);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rigidbody2D.AddForce(Vector2.left * movePrefix, ForceMode2D.Impulse);

            transform.localScale = new Vector3(-1, 1, 1);

            //transform.Translate(Vector3.left * movePrefix);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rigidbody2D.AddForce(Vector2.right * movePrefix, ForceMode2D.Impulse);

            transform.localScale = new Vector3(1, 1, 1);

            //transform.Translate(Vector3.right * movePrefix);
        }
    }
}
