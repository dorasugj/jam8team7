using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed = 2;
    Vector2 vec;

    void Update()
    {
        //　移動処理 
        if (Input.GetMouseButtonDown(0))
        {
            vec = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Debug.Log("x="+vec.x+" y="+vec.y); 
        }

        transform.position = Vector2.MoveTowards(transform.position, new Vector2(vec.x, vec.y), speed * Time.deltaTime);
    }
}
