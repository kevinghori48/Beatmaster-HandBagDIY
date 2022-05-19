using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaysManager : MonoBehaviour
{
    private Text _text;

    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        if(_text != null)
            _text.text = "Day " + GameManager.Instance.DAYS;
        if (name == "NextPhase")
            GameManager.Instance.DAYS += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
