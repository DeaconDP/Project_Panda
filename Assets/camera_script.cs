using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour
{
    public int playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButton("fire1"))
        { 
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
        
    }
}
