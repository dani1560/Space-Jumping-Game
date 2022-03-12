using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endScreen : MonoBehaviour
{
    GameObject gameObj;

    // Start is called before the first frame update
    void Start()
    {
        gameObj = GameObject.Find("Capsule");
    }

    // Update is called once per frame

    void Update()
    {
        if(gameObj.transform.position.y <= -5)
        {
            SceneManager.LoadScene("EndScreen");
            Debug.Log("Game Over");
        }
    }
}
