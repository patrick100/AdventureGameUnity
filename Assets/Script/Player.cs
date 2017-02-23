using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float speed = 50f,maxVelocity =4f;
    private Rigidbody2D body;
    private Animator anim;


    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        PlayerWalkKeyboard();
    }

    private void PlayerWalkKeyboard()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(body.velocity.x);

        float h = Input.GetAxisRaw("Horizontal");
        if (h > 0)
        {
            if (vel < maxVelocity)
            {
                forceX = speed;
            }

            anim.SetBool("Walk", true);
        }
        else if (h < 0)
        {
            if (vel < maxVelocity)
            {
                forceX = -speed;
            }
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
        
       body.AddForce(new Vector2(forceX, 0));

    }

} // class





































