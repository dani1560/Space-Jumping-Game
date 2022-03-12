using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomColors : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    public float time;
    public float timeDelay;

    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<Renderer>();

        //time watch

        time = 0f;
        timeDelay = 3f;

    }

    // Update is called once per frame
    void Update()
    {
        time = time + 1f * Time.deltaTime;

        if(time >= timeDelay)
        {
            time = 0f;
            RandomColors();
        }
        
        
    }
    void RandomColors()
    {
        rend.material = material[Random.Range(0, material.Length)];
    }
}
