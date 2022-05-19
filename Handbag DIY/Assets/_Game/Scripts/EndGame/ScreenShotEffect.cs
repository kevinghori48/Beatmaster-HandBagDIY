using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenShotEffect : MonoBehaviour
{
    public AudioClip ScreenShotSfx;
    public GameObject ScCanvas;
    public GameObject TapText;
    public AudioSource Source;
    private bool _tapTrack;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ScreenShot());
    }

    IEnumerator ScreenShot()
	{
        yield return new WaitForSeconds(1f);

        GetComponent<AudioSource>().PlayOneShot(ScreenShotSfx);
        ScCanvas.SetActive(true);

        yield return new WaitForSeconds(1f);
        _tapTrack = true;
        TapText.SetActive(true);
    }

	private void Update()
	{
        if (!_tapTrack)
            return;

        if(Input.GetMouseButtonDown(0))
		{
            Source.Play();
            SceneManager.LoadScene(0);
		}
	}
}
