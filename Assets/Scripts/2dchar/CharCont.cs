using UnityEngine;
using System.Collections;

public class CharCont : MonoBehaviour
{
    Rigidbody rBody;
    public float speed = 5f;
    Animator anim;
    bool walking;
    float scaleX;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        scaleX = transform.localScale.x;
    }

    void FixedUpdate ()
    {
        Vector3 inputDirection = new Vector3(Input.GetAxis("Horizontal"), rBody.velocity.y, Input.GetAxis("Vertical")).normalized;
        rBody.velocity = inputDirection * speed;

        if (Input.GetKeyDown(KeyCode.Space))
            rBody.AddForce(new Vector3(0, 100, 0));

        if (inputDirection.x != 0 || inputDirection.z != 0)
            anim.SetBool("walking", true);
        else
            anim.SetBool("walking", false);

        if (inputDirection.x > 0 && scaleX < 0)
            Flip();
        else if (inputDirection.x < 0 && scaleX > 0)
            Flip();
	}

    void Flip()
    {
        transform.localScale = new Vector3(scaleX * -1, transform.localScale.y, transform.localScale.z);
        scaleX = transform.localScale.x;
    }
}
