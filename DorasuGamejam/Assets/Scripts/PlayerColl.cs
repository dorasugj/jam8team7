using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerColl : MonoBehaviour {
    public GameObject hoge;

    
    void OnTriggerEnter2D()
    {
        hoge.SetActive(false);
        gameObject.SetActive(false);
        GameObject.Find("Score").GetComponent<Score>().score ++;
        //Debug.Log("hit");
        
    }
}
