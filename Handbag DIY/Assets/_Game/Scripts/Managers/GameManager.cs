using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private const string KEY_DAYS = "days";

	private void Awake()
	{
        if (Instance == null)
            Instance = this;
        else
            Destroy(Instance.gameObject);
        DontDestroyOnLoad(gameObject);

        if (!PlayerPrefs.HasKey(KEY_DAYS))
            PlayerPrefs.SetInt(KEY_DAYS, 1);

        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Application.targetFrameRate = 60;
	}

    public int SelectedTopVariation;
    public int SelectedColor;
    public int SelectedOrnaments;
    public int SelectedSticker;


    public int DAYS
	{
		get
		{
            if (!PlayerPrefs.HasKey(KEY_DAYS))
                PlayerPrefs.SetInt(KEY_DAYS, 1);

            return PlayerPrefs.GetInt(KEY_DAYS);
		}
		set
		{
            PlayerPrefs.SetInt(KEY_DAYS, PlayerPrefs.GetInt(KEY_DAYS) + 1);
		}
	}

    public void PlayBtn()
	{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
