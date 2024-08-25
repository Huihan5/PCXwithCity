using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = transform.position;

        if (Input.GetKeyDown(KeyCode.W))
        {
            newpos.x += 1;
        }

        transform.position = newpos;
    }
}
