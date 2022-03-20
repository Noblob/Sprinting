using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintScript : MonoBehaviour
{

    public bool isMoving = false;
    public float movementSpeed = 125;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("w"))
        {
            isMoving = true;
        }

        if(Input.GetKeyUp("w"))
        {
            isMoving = false;
        }

        if(Input.GetKey(KeyCode.LeftShift) & isMoving == true)
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }
    }
}
