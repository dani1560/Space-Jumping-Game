using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger is enter");
        //GameObject.Find("Audioplay").GetComponent<AudioSource>().Play();

        AudioSource[] audObj = GameObject.Find("Audioplay").GetComponents<AudioSource>();
        audObj[0].Play();
    }
}
