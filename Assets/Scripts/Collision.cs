using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public static int score;
    Text scoreValue;
    Text title;
    string mat;
    string[] planes = new string[] { "Plane (1)", "Plane (2)", "Plane (3)", "Plane (4)", "Plane (5)",
                                     "Plane (11)", "Plane (12)", "Plane (13)", "Plane (14)", "Plane (15)",
                                     "Plane (21)", "Plane (22)", "Plane (23)", "Plane (24)", "Plane (25)",
                                     "Plane (31)", "Plane (32)", "Plane (33)", "Plane (34)", "Plane (35)",
                                     "Plane (41)", "Plane (42)", "Plane (43)", "Plane (44)", "Plane (45)",
                                     "Plane (51)", "Plane (52)", "Plane (53)", "Plane (54)", "Plane (55)",
                                     "Plane (61)", "Plane (62)", "Plane (63)", "Plane (64)", "Plane (65)",
                                     "Plane (71)", "Plane (72)", "Plane (73)", "Plane (74)", "Plane (75)",
                                     "Plane (57)", "Plane (38)", "Plane (47)", "Plane (57)", "Plane (69)" };

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        GameObject scoreObj = GameObject.Find("scoreValue");
        scoreValue = scoreObj.GetComponent<Text>();

        GameObject titleObj = GameObject.Find("title");
        title = titleObj.GetComponent<Text>();

        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        for (int i = 0; i < planes.Length; i++)
        {
            if (collision.gameObject.name == planes[i])
            {
                if (title.text == "Level 1")
                {
                    score++;
                    scoreValue.text = score.ToString();
                    Destroy(collision.gameObject);
                    
                }else if(title.text == "Level 2")
                {
                    mat = collision.gameObject.GetComponent<Renderer>().material.color.ToString();

                    if (mat == "RGBA(0.000, 1.000, 0.000, 0.376)")
                    {
                        score+=5;
                    }
                    else if (mat == "RGBA(0.915, 0.000, 0.000, 0.388)")
                    {
                        score += 10;
                    }
                    else if (mat == "RGBA(0.005, 0.594, 0.981, 0.467)")
                    {
                        score += 20;
                    }

                    Destroy(collision.gameObject);
                    scoreValue.text = score.ToString();
                }
            }
        }
    }
}
