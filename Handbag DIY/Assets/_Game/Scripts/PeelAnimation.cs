using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeelAnimation : MonoBehaviour
{
    public bool start;
    private bool once;
    public AudioSource Source;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!start)
            return;

        if (Input.GetMouseButtonDown(0))
		{
            if(!once)
			{
                Source.Play();
                GetComponent<AudioSource>().Play();
                once = true;
                GetComponent<Animator>().speed = 1f;
                GetComponent<Animator>().Play("PeelOffFixedForSticking");
			}
		}
    }
}
