using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalinput;
    public float Speed = 12.0f;
    public float Xrange = 12.0f;

    public GameObject projectilePrefab;
    void Start()
    {
        
    }
    void Update()
    {
        if(transform.position.x < -Xrange)
        {
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > Xrange)
        {
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        }
        horizontalinput = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * Speed);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
