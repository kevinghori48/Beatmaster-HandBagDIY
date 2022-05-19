using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagMover : MonoBehaviour
{
    public MeshRenderer Sticker;
    public MeshRenderer NewSticker;

    public void CopyMats()
	{
        NewSticker.material = Sticker.material;
	}
}
