using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowcontroller : MonoBehaviour
{
    Animator _dooranim;

    private void OnTriggerEnter(Collider other)
    {
        _dooranim.SetBool("isOpening", true);
    }

    private void OnTriggerExit(Collider other)
    {
        _dooranim.SetBool("isOpening", false);
    }

    // Start is called before the first frame update
    void Start()
    {
        _dooranim = this.transform.parent.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
