using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKekka : MonoBehaviour {
    public Text resultText;

    // Use this for initialization
    void Start () {
        int num = PlayerPrefs.GetInt("SCORE");
        resultText = GameObject.Find("ScoreKekka").GetComponent<Text>();
        resultText.text = num.ToString();
    }
	
	// Update is called once per frame
	void Update () {

	}
}
