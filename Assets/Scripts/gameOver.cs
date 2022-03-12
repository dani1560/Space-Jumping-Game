using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public float timeStart = 120;
    public Text timer;
    Text title;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Counter", 119f);
        
        GameObject timerObj = GameObject.Find("timer");
        GameObject titleObj = GameObject.Find("title");
        
        timer = timerObj.GetComponent<Text>();
        timer.text = timeStart.ToString();

        title = titleObj.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        timer.text = Mathf.Round(timeStart).ToString();
    }

    void Counter()
    {
        if (Collision.score >= 15 && title.text == "Level 1")
        {
            SceneManager.LoadScene("level3");
        }
        else
        {
            SceneManager.LoadScene("EndScreen");
        }

    }
}
