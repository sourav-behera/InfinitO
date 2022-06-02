using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{   
    
    public GameObject platform;
    public GameObject floatingPlatform;
    public GameObject spikePlatform;
    public GameObject fragilePlatform;
    public GameObject floatingSpike;


    List<GameObject> platformList = new List<GameObject>();
    List<GameObject> spikePlatformList = new List<GameObject>();
    List<GameObject> fragilePlatformList = new List<GameObject>();
    public List<GameObject> floatingPlatformList = new List<GameObject>();
    public List<GameObject> floatingSpikeList = new List<GameObject>();
    
    int size = 50;
    float y = -10f;
    bool wasPrevPlatform = false;
    public static PlatformManager platformManager; 
    
    private void Start() {
        if (platformManager == null ) platformManager = this;
        platformList = FillList(platformList, platform);
        floatingPlatformList = FillList(floatingPlatformList, floatingPlatform);
        spikePlatformList = FillList(spikePlatformList, spikePlatform);
        fragilePlatformList = FillList(fragilePlatformList, fragilePlatform);
        floatingSpikeList = FillList(floatingSpikeList, floatingSpike);
        for (int i = 0 ; i < 50 ; i++) Spawner();

    }
    private void Update() {
       
    }
    List<GameObject> FillList(List<GameObject> list, GameObject obj){
        GameObject ob;
        for (int i = 0 ; i < size; i++){
            ob = Instantiate(obj);
            ob.SetActive(false);
            list.Add(ob);
        }
        return list;
    }
    public void Spawner(){
        float randX = Random.Range(-2.0f, 2.0f);
        GameObject obj = GetPlatform();
        obj.SetActive(true);
        obj.transform.position = new Vector2(randX, y);
        y ++;    
    }
    GameObject GetPlatform(){
        List<GameObject> list = new List<GameObject>();
        int n = Random.Range(1,6);
        if (n == 1) {
        list = platformList;
        wasPrevPlatform = false;
        }
            
        if (n == 2){
        list = floatingPlatformList;
        wasPrevPlatform = false;
        }
            
        if (n == 3){
        list = fragilePlatformList;
        wasPrevPlatform = false;
        } 
            
        if (n == 4 || n == 5) {
            if (!wasPrevPlatform){
                int temp = Random.Range(0,2);
                if (temp == 0 ) list = spikePlatformList;
                if (temp == 1 ) list = floatingSpikeList;
                wasPrevPlatform = true;
            }else{
                list = floatingPlatformList;
                wasPrevPlatform = false;
            }
            
        }
        for (int i = 0 ; i < list.Count; i ++){
            if (!list[i].activeInHierarchy){
                return list[i];
            }
        }
        // GameObject obj = Instantiate(platform);
        // return obj;
        return null;
    }
    
    
        
    
}
