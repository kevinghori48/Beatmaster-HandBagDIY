using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewCounter : MonoBehaviour
{
    private float _interval;
    private int _counter;
    private Text _thisText;

    // Start is called before the first frame update
    void Start()
    {
        _thisText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_counter >= 1000)
            return;

        _interval += Time.deltaTime;
        if(_interval >= 0.1f)
		{
            _interval = 0f;
            _counter += Random.Range(2, 5);
            _thisText.text = _counter + " Likes";
		}
    }
}
