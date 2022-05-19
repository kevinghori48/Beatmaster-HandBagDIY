using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public List<GameObject> Sticker1ColorUI = new List<GameObject>();
    public List<GameObject> Sticker2ColorUI = new List<GameObject>();
    public List<GameObject> Sticker3ColorUI = new List<GameObject>();
    public List<GameObject> Sticker4ColorUI = new List<GameObject>();

    public GameObject Defaultcolor1;
    public GameObject Defaultcolor2;
    public GameObject Defaultcolor3;
    public GameObject Defaultcolor4;

    public void SetcolorPellet(int index)
	{
        List<GameObject> colors = new List<GameObject>();
        GameObject defaultColor = Defaultcolor1;
        switch (index)
        {
            case 0:
                colors = Sticker1ColorUI;
                defaultColor = Defaultcolor1;
                break;
            case 1:
                colors = Sticker2ColorUI;
                defaultColor = Defaultcolor2;
                break;
            case 2:
                colors = Sticker3ColorUI;
                defaultColor = Defaultcolor3;
                break;
            case 3:
                colors = Sticker4ColorUI;
                defaultColor = Defaultcolor4;
                break;
        }
        foreach (GameObject go in colors)
            go.SetActive(true);
        defaultColor.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
