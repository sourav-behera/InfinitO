using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{   
    Rigidbody2D rb;
    CircleCollider2D circleCollider2D;
    // Start is called before the first frame update

    public static Player player;
    void Start()
    {   if (player == null) player = this;
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        circleCollider2D = this.gameObject.GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        {
            if (rb.velocity.y > 0) circleCollider2D.enabled = false;
            else circleCollider2D.enabled = true;
        }
    
    }
    
    public void Die(){
        StartCoroutine(End());
        GameOver.gameover.Over();
    }
    IEnumerator End(){
        Destroy(this.gameObject);
        yield return new WaitForSeconds(2);
        
    }
    
}
