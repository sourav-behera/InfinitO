using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FragilePlatform : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem destruct;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player"){
            StartCoroutine(Destruct());
            this.gameObject.SetActive(false);
        }
    }
    IEnumerator Destruct(){
        Destroy(Instantiate(destruct.gameObject, this.transform.position, Quaternion.identity), 0.5f);
        yield return new WaitForSeconds(0.5f);
    }
}
