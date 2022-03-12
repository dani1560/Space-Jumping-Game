using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    public Text score;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreObj = GameObject.Find("scoreValue");
        score = scoreObj.GetComponent<Text>();

        player = GameObject.Find("Capsule");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
