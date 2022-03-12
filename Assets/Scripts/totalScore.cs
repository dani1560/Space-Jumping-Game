using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class totalScore : MonoBehaviour
{
    Text total;
    Text title;
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("totalScore");
        GameObject titleobj = GameObject.Find("Title");

        total = obj.GetComponent<Text>();
        total.text = Collision.score.ToString();
        title = titleobj.GetComponent<Text>();

        if (Collision.score >= 200)
        {
            title.text = "You Win";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
