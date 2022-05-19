using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintOnTouch : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Animator printingAnimator, printingProgressAnimator;
    private bool boolOnce = false;
    public AudioSource Source;
    // Start is called before the first frame update
    void Start()
    {
        printingAnimator.speed = 0f;
        printingProgressAnimator.speed = 0f;
    }

    public void Print()
	{
        if (!boolOnce)
        {
            Source.Play();
            GetComponent<AudioSource>().Play();
            printingAnimator.speed = 0.5f;
            printingProgressAnimator.speed = 0.5f;
            boolOnce = true;
        }
    }

}
