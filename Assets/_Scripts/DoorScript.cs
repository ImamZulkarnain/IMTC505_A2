using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        anim.Play("DoorOpen");
    }

    public void CloseDoor()
    {
        anim.Play("DoorClose");
    }
}
