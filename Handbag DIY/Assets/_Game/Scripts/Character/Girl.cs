using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    public Transform Target;
    public float Speed;
    public GameObject Bag;
    public GameObject BagInHand;
    public GameObject Play;

    private bool _stopWalking;
    private Animator _animator;


    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_stopWalking)
            return;

        transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);

        float dist = Vector3.Distance(transform.position, Target.position);
        if(dist <= 0.1f)
		{
            _stopWalking = true;
            Bag.SetActive(true);
            BagInHand.SetActive(false);
            _animator.Play("Idle");
            Play.SetActive(true);
        }
    }
}
