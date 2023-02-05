using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlller2D : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cam;
    bool atEdge;
    bool moving;
    string dir;
    public float movementValueX = 0.1f;
    public float moveSpeed = 5f;

    void Start()
    {
        atEdge = false;
        moving = false;
        dir = "right";



    }

    // Update is called once per frame
    void Update()
    {
       if (!atEdge)
        {
            if (moving)
            {
                Move();
            }
        } 
    }
    void Move()
    {
        if (dir == "left")
        {
            cam.Translate(new Vector2(-0.02f ,0f));
        }
        else
        {
            cam.Translate(new Vector2(0.03f, 0f));
        }

    
    
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "left")
        {
            moving = true;
            dir = "left";
        }
        else if(other.tag == "right")
        {
            moving = true;
            dir = "right";
        }
        else if (other.tag == "boundary")
        {
            atEdge = true;
        }
    
    
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "left")
        {
            moving = false;
            dir = "left";
        }
        else if (other.tag == "right")
        {
            moving = false;
            dir = "right";
        }
        else if (other.tag == "boundary")
        {
            atEdge = false;
        }


    }

}
