using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{   
    void Start(){

    }
    private void OnCollisionEnter2D(Collision2D other) {
        GameObject obj = other.gameObject;
        if (obj.tag == "Player") {
            Player.player.Die();
            Debug.Log("Collided with player");
        }

        else if (obj.tag == "Platform") {
            obj.SetActive(false);
            PlatformManager.platformManager.Spawner();
        }
        else if (obj.tag == "Float" || obj.tag == "Spike") {
            if (obj.tag == "Float"){
                GameObject ob = Instantiate(PlatformManager.platformManager.floatingPlatform);
                ob.SetActive(false);
                int index = PlatformManager.platformManager.floatingPlatformList.IndexOf(obj);
                PlatformManager.platformManager.floatingPlatformList[index] = ob;
                Destroy(obj);
                PlatformManager.platformManager.Spawner();
            }
            
            else if (obj.tag == "Spike"){
                GameObject ob = Instantiate(PlatformManager.platformManager.floatingSpike);
                ob.SetActive(false);
                int index = PlatformManager.platformManager.floatingSpikeList.IndexOf(obj);
                PlatformManager.platformManager.floatingSpikeList[index] = ob;
                Destroy(obj);
                PlatformManager.platformManager.Spawner();
            }

        }
        
    }
    
}
