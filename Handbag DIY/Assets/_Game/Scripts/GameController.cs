using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject phase1UI, phase2Tutorial, phase2UI, phase3Tutorial, phase4Tutorial, phase3UI, phase4UI, phase5UI;

    [SerializeField] private GameObject phase1DoneButton, phase2DoneButton, phase3DoneButton, phase4DoneButton;

    [SerializeField] private GameObject paintedSticker, stickerInPrinter, stickerForPeeling, stickerForStickingOn, phoneCase, phoneCaseForShowing, stickerForRipping1=null, stickerForRipping2 = null;  

    [SerializeField] private CameraTransitions cameraTransitions;

    [SerializeField] private Animator stickerToPeelAnimator;
    [SerializeField] private RuntimeAnimatorController stickingOnAnimator;

    private bool isGoToPhase4Active = false;
    private Vector3 phoneCaseDestination;
    [SerializeField] private float phoneCaseTransitionSpeed;

    [SerializeField] private GameObject triggerForPhoneShowing, backgroundCanvas=null;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isGoToPhase4Active)
        {
            phoneCase.transform.position = Vector3.Lerp(phoneCase.transform.position, phoneCaseDestination , Time.deltaTime * phoneCaseTransitionSpeed);
        }
        //if goToPhase4 is activated
    }

    public void goToPhase2()
    {
        phase1UI.SetActive(false);

        if (backgroundCanvas != null)
        {
            backgroundCanvas.SetActive(false);
        }

        cameraTransitions.TransitionCameraToPhase(2);

        //copy materials from phase1 to all the other stickers in other phases
        Material phase1Material = paintedSticker.transform.GetChild(0).GetComponent<Renderer>().material;       //sticker is the child at index 0, paintedSticker is the EmptyObject parent
                                                                                                                
        Material[] matArray = stickerForPeeling.GetComponent<Renderer>().materials;
        matArray[1] = phase1Material;
        stickerForPeeling.GetComponent<Renderer>().materials = matArray;



        stickerInPrinter.GetComponent<Renderer>().material = phase1Material;

        matArray = stickerForStickingOn.GetComponent<Renderer>().materials;
        matArray[1] = phase1Material;
        stickerForStickingOn.GetComponent<Renderer>().materials = matArray;

        phoneCaseForShowing.GetComponent<Renderer>().material = phase1Material;

        //ripping part

        if (stickerForRipping1 != null)
        {
            stickerForRipping1.GetComponent<Renderer>().material = phase1Material;
        }

        if (stickerForRipping2 != null)
        {
            matArray = stickerForRipping2.GetComponent<Renderer>().materials;
            matArray[1] = phase1Material;
            stickerForRipping2.GetComponent<Renderer>().materials = matArray;
        }


            //activate step 1 done
            phase1DoneButton.SetActive(true);

        //enable tutorial
        phase2Tutorial.SetActive(true);
    }

    public void enablePhase2UI()
    {
        //phase2UI.SetActive(true);

        phase2Tutorial.SetActive(false); //disable phase 2 tutorial
    }

    public void enablePhase3UI()
    {
        phase3UI.SetActive(true);

    }

    public void enablePhase4UI()
    {
        phase4Tutorial.SetActive(false);
        phase4UI.SetActive(true);
        //disable phase 3 tutorial
        phase3Tutorial.SetActive(false);
    }

    public void enablePhase5UI()
    {
        phase5UI.SetActive(true);

        phase4Tutorial.SetActive(false);
    }

    public void goToPhase3()
    {
        phase2UI.SetActive(false);
        cameraTransitions.TransitionCameraToPhase(3);

        //activate step 2 done
        phase2DoneButton.SetActive(true);

        //activate fall on ground animation
        stickerToPeelAnimator.SetTrigger("StickerFall");

        //tutorial here
        phase3Tutorial.SetActive(true);
    }

    public void goToPhase4()
    {
        phase3UI.SetActive(false);

        phase4Tutorial.SetActive(true);

        //activate step 3 done
        phase3DoneButton.SetActive(true);

        phoneCaseDestination =new Vector3(stickerForPeeling.transform.position.x, phoneCase.transform.position.y, phoneCase.transform.position.z);
        Transform parentPeeling= stickerForPeeling.transform.parent, parentSticking= stickerForStickingOn.transform.parent;
        
       
        parentPeeling.GetComponent<Animator>().runtimeAnimatorController = stickingOnAnimator;
        parentPeeling.GetComponent<PeelAnimation>().start  = true;
        parentPeeling.GetComponent<Animator>().speed = 0;
        isGoToPhase4Active = true;

        //tutorial disable here
        phase3Tutorial.SetActive(false);
    }

    public void goToPhase5()
    {
        triggerForPhoneShowing.SetActive(true); //trigger is set visible only here, because in phase 1 it is visible
        phase4UI.SetActive(false);
        cameraTransitions.TransitionCameraToPhase(5);

        phase4Tutorial.SetActive(false);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
