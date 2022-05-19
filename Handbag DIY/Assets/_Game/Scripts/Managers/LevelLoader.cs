using PaintIn3D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public MeshRenderer StickerRenderers;
    public SkinnedMeshRenderer StickerSkinRenderers;
    public List<SkinnedMeshRenderer> StickerSkinRenderersTwomats = new List<SkinnedMeshRenderer>();
    public P3dMask StickerMask;
    public List<Sprite> StickerMasks = new List<Sprite>();

    public List<Material> Sticker1Mats = new List<Material>();
    public List<Material> Sticker2Mats = new List<Material>();
    public List<Material> Sticker3Mats = new List<Material>();
    public List<Material> Sticker4Mats = new List<Material>();

    [Space]
    [Space]
    [Space]
    public Image Order;
    public List<Sprite> OrderImages = new List<Sprite>();

    // Start is called before the first frame update
    void Start()
    {
        int index = GameManager.Instance.SelectedSticker;
        SetStickerData(index);
        GetComponent<ColorManager>().SetcolorPellet(index);
    }

    public void SetStickerData(int index)
	{
        List<Material> mats = new List<Material>();
        switch(index)
		{
            case 0:
                mats = Sticker1Mats;
                break;
            case 1:
                mats = Sticker2Mats;
                break;
            case 2:
                mats = Sticker3Mats;
                break;
            case 3:
                mats = Sticker4Mats;
                break;
        }
        StickerRenderers.material = mats[0];
        StickerSkinRenderers.material = mats[0];
        foreach(SkinnedMeshRenderer renderer in StickerSkinRenderersTwomats)
		{
            renderer.materials = new Material[]
            {
                mats[1],
                mats[0]
            };
		}
        Order.sprite = OrderImages[index];
        StickerMask.Texture = StickerMasks[index].texture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
