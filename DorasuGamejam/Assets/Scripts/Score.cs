﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public int score;
    public Text scoreText;

    // Use this for initialization
    void Start () {
        scoreText =GetComponent<Text>();
        scoreText.text = score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        
        scoreText.text = score.ToString();

    }
}
