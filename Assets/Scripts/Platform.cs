using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{   
    [Header("Variables")]
    public float jumpforce = 8f;
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player"){
            other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up* jumpforce, ForceMode2D.Impulse);
        }      
    }
    
}
