using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RendereColourController : MonoBehaviour
{
    public List<GameObject> allRenderer;
    public List<GameObject> allChildList1;
    public List<GameObject> allChildList2;


    // Start is called before the first frame update
    void Start()
    {
      /*  for (int i = 0; i < transform.childCount; i++)
        {
            allRenderer.Add(gameObject.transform.GetChild(i).gameObject);
        }
*/

        // using foreach
        foreach (Transform child in transform)
        {
            allChildList1.Add(child.gameObject);
        }

        //using getcomponentsinchildren
       /* Transform[] children = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            children[i] = transform.GetChild(i);
        }*/


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
