using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : MonoBehaviour
{
	public Transform Popup;
	public List<GameObject> TopSelected = new List<GameObject>();
	public List<GameObject> ColorSelected = new List<GameObject>();
	public List<GameObject> OrnamentSelected = new List<GameObject>();
	public List<GameObject> StickerSelected = new List<GameObject>();
	[Space]
	[Space]
	[Space]
	public List<GameObject> TopVariants = new List<GameObject>();
	public List<GameObject> KeychainVariants = new List<GameObject>();
	public List<Material> ColorMats = new List<Material>();
	public List<MeshRenderer> BagMeshes = new List<MeshRenderer>();
	public List<MeshRenderer> BagMeshesTwomats = new List<MeshRenderer>();

	private GameManager _manager;
	private int _topindex = 0;
	private int _colorindex = 0;
	private int _ornaindex = 0;
	private int _stickerindex = 0;
	private AudioSource _audio;


	private void Start()
	{
		_manager = GameManager.Instance;
		_audio = GetComponent<AudioSource>();
	}

	public void Show()
	{
		Popup.DOScaleY(1f, 0.5f).SetEase(Ease.OutBounce);
	}

	public void Insert()
	{
		_manager.SelectedColor = _colorindex;
		_manager.SelectedOrnaments = _ornaindex;
		_manager.SelectedTopVariation = _topindex;
		_manager.SelectedSticker = _stickerindex;
	}

	public void SelectTopVariant(int index)
	{
		_audio.Play();
		if (TopVariants[_topindex] != null)
			TopVariants[_topindex].SetActive(false);

		TopSelected[_topindex].SetActive(false);
		
		if (TopVariants[index] != null)
			TopVariants[index].SetActive(true);
		
		TopSelected[index].SetActive(true);
		_topindex = index;
	}

	public void SelectColorVariant(int index)
	{
		_audio.Play();
		ColorSelected[_colorindex].SetActive(false);
		ColorSelected[index].SetActive(true);
		foreach (MeshRenderer renderer in BagMeshes)
			renderer.material = ColorMats[index];
		foreach (MeshRenderer renderer in BagMeshesTwomats)
			renderer.materials = new Material[] { ColorMats[index], ColorMats[index] };
		_colorindex = index;
	}

	public void SelectOrnaVariant(int index)
	{
		_audio.Play();
		if (KeychainVariants[_ornaindex] != null)
			KeychainVariants[_ornaindex].SetActive(false);

		OrnamentSelected[_ornaindex].SetActive(false);
		OrnamentSelected[index].SetActive(true);

		if (KeychainVariants[index] != null)
			KeychainVariants[index].SetActive(true);

		_ornaindex = index;
	}

	public void SelectStickerVariant(int index)
	{
		_audio.Play();
		StickerSelected[_stickerindex].SetActive(false);
		StickerSelected[index].SetActive(true);
		_stickerindex = index;
	}
}
