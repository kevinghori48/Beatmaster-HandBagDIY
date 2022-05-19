using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeelingOff : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Animator peelOffAnim;
    [SerializeField] private GameObject finishPoint;
    private bool peelingInitialized = false;

    public void Play()
	{
        peelOffAnim.Play("PeelOffFixed");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(!peelingInitialized)
			{
               
                peelingInitialized = true;
			}
        }
    }
}
