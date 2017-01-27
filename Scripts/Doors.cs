using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    Animator animator;
    bool doorOpen;
    //public string OpenDoorKey;

    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            /*if (Input.GetKeyDown(OpenDoorKey))
            {
                doorOpen = true;
                DoorControl("Open"); Skal ind i en void Update
            }*/
            
            doorOpen = true;
            DoorControl("Open");
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (doorOpen)
        {
            doorOpen = false;
            DoorControl("Close");
        }
    }

    void DoorControl(string direction)
    {
        animator.SetTrigger(direction);
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
            print("It worked!");
    }
}
