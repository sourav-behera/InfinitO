using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerController : MonoBehaviour
{   
    Vector2 dirX;
    Rigidbody2D rb;
    public float movespeed = 10f;
    float factor; 

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = new Vector2(Input.acceleration.x, 0);
        dirX = dirX.normalized;
        factor = Input.acceleration.x;
        factor = Mathf.Clamp(factor, -1, 1);
        if (transform.position.x > 2.2f){
            this.transform.position = new Vector2(-2.2f, transform.position.y);
        }
        else if(transform.position.x < -2.2f){
            this.transform.position = new Vector2(2.2f, transform.position.y);
        }
        //transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2.3f, 2.3f), transform.position.y);
        //rb.drag = 3f;
        //rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -3f, 3f), rb.velocity.y);

    }
    void FixedUpdate() {
        //float factor = 1f;
        if (Input.acceleration.x > 0){
            if (rb.velocity.x < 0) rb.velocity = new Vector2(0, rb.velocity.y);
            else {
                //factor = 0.6f; 
                //rb.AddForce(dirX.normalized * movespeed * factor);
                if (this.transform.position.x < 2.29f)
                rb.velocity = new Vector2(10f*factor , rb.velocity.y);
            }
        }
        if (Input.acceleration.x < 0){
            if (rb.velocity.x > 0) rb.velocity = new Vector2(0, rb.velocity.y);
            else{
                //factor = 0.6f; 
                //rb.AddForce(dirX.normalized * movespeed * factor);
                if (this.transform.position.x > -2.29f)
                rb.velocity = new Vector2(10f*factor , rb.velocity.y);
            } 
        }
        
    }
}
