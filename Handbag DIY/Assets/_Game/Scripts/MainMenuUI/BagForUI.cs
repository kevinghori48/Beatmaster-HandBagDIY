using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagForUI : MonoBehaviour
{
    void OnEnable()
    {
        Vector3 target = transform.position;
        Vector3 from = target;
        from.y -= 5f;
        transform.position = from;
        transform.DOMove(target, 1f);

        Vector3 rot = transform.rotation.eulerAngles;
        rot.y += 720;
        transform.DORotate(rot, 1f,RotateMode.FastBeyond360);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
