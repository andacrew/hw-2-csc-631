using UnityEngine;

ppublic class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float strafeForce = 500f;


    void FixedUpdate()
    {
        if(Input.GetKey("w")){
            rb.AddForce( 0, 0, forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("a")){
            rb.AddForce( -strafeForce * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("s")){
            rb.AddForce( 0, 0, -forwardForce * Time.deltaTime);
        }
        if(Input.GetKey("d")){
            rb.AddForce( strafeForce * Time.deltaTime, 0, 0);
        }
    }
}
