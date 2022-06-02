using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPlatform : MonoBehaviour
{   
    Vector3 end;
    
    void start(){
        while (true) Oscillate();
    }
    // Update is called once per frame
    
    IEnumerator Oscillate(){
        if (transform.position.x > 0){
            Vector3 end = new Vector3(-2.4f, transform.position.y, 0);
            yield return StartCoroutine(Move(end, -0.005f));
        }
        if (transform.position.x <= 0){
            Vector3 end = new Vector3(2.4f, transform.position.y, 0);
            yield return StartCoroutine(Move(end, 0.005f));
        }
    }
    IEnumerator Move(Vector3 destination, float speed){
        while (this.transform.position != destination){
            //this.transform.position = Vector3.MoveTowards(this.transform.position, destination, speed*Time.deltaTime);
            transform.Translate(Vector2.right*speed*Time.smoothDeltaTime);
            //transform.position = Vector3.Lerp(transform.position, destination, 0.1f);
            yield return new WaitForEndOfFrame();
        }
        // float i = 0.0f;
        // float rate = 1.0f / time;
        // while (i < 1.0f) {
        //     i += Time.deltaTime * rate;
        //     this.transform.position = Vector3.Lerp(this.transform.position, destination, i);
        //     yield return null;
        // }
    }

    
}
