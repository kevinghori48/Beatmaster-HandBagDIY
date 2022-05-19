using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventController : MonoBehaviour
{
    [SerializeField] private GameController _gameController;
    public ImageSwap Swap;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    public void enablePhase2UI()
    {
        _gameController.goToPhase3();
        _gameController.enablePhase2UI();
        Swap.Change();
    }

    public void enablePhase3UI()   
    {
        // gameController.enablePhase3UI();
        _gameController.goToPhase4();
    }

    public void enablePhase4UI()
    {
        _gameController.enablePhase4UI();
    }

    public void enablePhase5UI()
    {
        _gameController.enablePhase5UI();
    }
}
