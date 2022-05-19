using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSwap : MonoBehaviour
{
    public Sprite NewBg;

    private Image _thisImg;

    // Start is called before the first frame update
    void Start()
    {
        _thisImg = GetComponent<Image>();
      }

    public void Change()
	{
        _thisImg.sprite = NewBg;
	}
}
