using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    private float timer;
    public Text timeText;

    // Use this for initialization
    void Start () {
        timer = 10.0f;
        timeText = GameObject.Find("Timer").GetComponent<Text>();
        timeText.text = timer.ToString("F2");

    }
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (0.0f > timer)
        {
            timer = 0.0f;
            var num = GameObject.Find("Score").GetComponent<Score>().score;
            PlayerPrefs.SetInt("SCORE", num);
            if (num > 10)
            {
                SceneManager.LoadScene("ClearScene");
            }
            else
            {
                SceneManager.LoadScene("MissScene");
            }
        }

        timeText.text = timer.ToString("F2");
    }
}
