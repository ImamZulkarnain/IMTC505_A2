using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DoorScript doorScript;
    public KeySocketInteraction ksi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ksi.keyInPlace)
        {
            doorScript.OpenDoor();
        }
        else
        {
            doorScript.CloseDoor();
        }
    }

    


}
