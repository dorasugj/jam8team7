using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instance : MonoBehaviour {
    //public Transform Obj;
    //private Vector3[] aricRegion =
    //{   new Vector3(7.51f,-2.37f,0),new Vector3(7.16f,-2.14f,0),new Vector3(7.33f,-2.8f,0),
    //    new Vector3(6.98f,-3.0f,0),new Vector3(7.13f,-3.25f,0),new Vector3(6.8f,-3.27f,0),
    //    new Vector3(6.98f,-3.58f,0),new Vector3(6.63f,-3.32f,0),new Vector3(6.53f,-3.75f,0),
    //    new Vector3(6.12f,-3.65f,0),new Vector3(6.22f,-3.98f,0),new Vector3(5.76f,-4.01f,0),
    //    new Vector3(5.74f,-4.41f,0)
    //};
    public GameObject []appearanceObj = new GameObject[13];
    public GameObject[] coll = new GameObject[13];
    private int appearanceTimer = 0;
    private bool [] flag = new bool [13];
    private Random r = new Random();
    // Use this for initialization
    private int i = 0;
    void Start () {
        //Instantiate(Obj, new Vector3(5, -3, 0), Quaternion.identity);
        for(int i =0; i<13; i++)
        {
            flag[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
            appearanceTimer++;
        if (appearanceTimer >= 30)
        {

            int romdomPos = Random.Range(0, 13);
           // if (flag[romdomPos] == false)
                appearanceObj[romdomPos].SetActive(true);
            coll[romdomPos].SetActive(true);
            //Instantiate(Obj, aricRegion[romdomPos], Quaternion.identity);
            flag[romdomPos] = true;
            appearanceTimer = 0;
        }
    }
}
