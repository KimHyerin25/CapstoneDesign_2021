using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windowopen : MonoBehaviour
{
    [SerializeField] private Animator animator = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    [SerializeField] private string doorOpen = "DoorOpen";
    [SerializeField] private string doorClose = "DoorClose";

    private void OnTriggerEnter (Collider other)
    {
        Debug.Log("안됨");
        if (!other.CompareTag("Player"))
        {
            animator.SetBool("isOpening",true);
            Debug.Log("첫번째 if문에 들어옴");
            //return;
        }
        if (openTrigger)
        {
            Debug.Log("두번째 if문에 들어옴");

            animator.Play(doorOpen, 0, 0.0f);
            gameObject.SetActive(false);
        }

        else if (closeTrigger)
        {
            Debug.Log("else if 문에 들어옴");

            animator.Play(doorClose, 0, 0.0f);
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerExit (Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            animator.SetBool("isOpening", false);
            Debug.Log("OnTriggerExit첫번째 if문에 들어옴");
            //return;
        }
    }

}
