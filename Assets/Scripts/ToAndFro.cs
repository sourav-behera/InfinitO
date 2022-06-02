using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToAndFro : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 pointB;
    public float t=5.0f;
    public IEnumerator Start() {
        while (true) {
            if (transform.position.x > 0f){
                Vector3 pointA = transform.position;
                pointB = new Vector3(-2.0f,this.transform.position.y, 0);
                yield return StartCoroutine(MoveObject(transform, pointA, pointB, t));
            }
            else{
                Vector3 pointA = transform.position;
                pointB = new Vector3(2.0f,this.transform.position.y, 0);
                yield return StartCoroutine(MoveObject(transform, pointA, pointB, t));
            }
        }
    }
   
    IEnumerator MoveObject (Transform thisTransform, Vector3 startPos, Vector3 endPos, float time) {
        float i = 0.0f;
        float rate = 1.0f / time;
        while (i < 1.0f) {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }
    
}
