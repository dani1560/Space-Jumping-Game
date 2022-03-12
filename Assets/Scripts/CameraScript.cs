using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{/*
     GameObject playerObj;
     public Vector3 offset;*/

    /* public Transform target;
     private float speedMod = 10.0f;
     private Vector3 point;
 */
    // Start is called before the first frame update

    public Transform cameraTarget;
    public Transform lookTarget;

    void Start()
    {
     //   playerObj = GameObject.Find("Capsule");
       /* point = target.transform.position;
        transform.LookAt(point);*/

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*Vector3 desiredPosition = cameraTarget.position;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime);

        transform.position = smoothPosition;*/
        transform.LookAt(lookTarget.position);


        //Rotation Work here
        /*
                if (Input.GetKey(KeyCode.RightArrow)) {
                    transform.RotateAround(point, new Vector3(0.0f, 1.0f, 0.0f), 15 * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.RotateAround(point, new Vector3(0.0f, -1.0f, 0.0f), 15 * Time.deltaTime);
                }
        */

        /* Vector3 desiredPos = cameraTarget.position + new Vector3(0, 2, -4);
         Vector3 smoothPos = Vector3.Lerp(transform.position, desiredPos, 30 * Time.deltaTime);
         transform.position = smoothPos;
         transform.LookAt(lookTarget.position);*/


       

}
}
