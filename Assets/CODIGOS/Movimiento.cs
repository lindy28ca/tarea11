using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    BoxCollider2D boxCollider2D;
    Rigidbody2D rigidbody2D;
    public int velocidad;
    public int Xdireccion=1;
    public int Ydireccion=1;
    SpriteRenderer cambio;
    void Awake()
    {
        boxCollider2D = GetComponent<BoxCollider2D>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        cambio = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(velocidad*Xdireccion,velocidad * Ydireccion);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Horizontal")
        {
            if(cambio.flipX == true)
            {
                cambio.flipX = false;
                cambio.flipY =false;
            }
            else
            {
                cambio.flipX = true;
                cambio.flipY = true;
            }
            Xdireccion = Xdireccion * -1;
        }
        if (collision.collider.tag == "Vertical")
        {
            if (cambio.flipX == true)
            {
                cambio.flipX = false;
                cambio.flipY = false;
            }
            else
            {
                cambio.flipX = true;
                cambio.flipY = true;
            }
            Ydireccion = Ydireccion * -1;
        }
    }
}
