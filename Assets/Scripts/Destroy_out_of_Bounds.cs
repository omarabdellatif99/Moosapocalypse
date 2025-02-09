using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_out_of_Bounds : MonoBehaviour
{
    private float TopBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > TopBound)
        {
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
        }
        else if(transform.position.z < lowerBound)
        {
            if (gameObject != null)
            {
                Destroy(gameObject);
            }
        }
    }
}
