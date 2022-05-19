
using UnityEngine;

public class CameraTransitions : MonoBehaviour
{
    public Transform[] views;

    [SerializeField] private float _transitionSpeed;
    private Transform _currentView;
    // Start is called before the first frame update
    void Start()
    {
        _currentView = transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,_currentView.position,Time.deltaTime*_transitionSpeed);

        Vector3 currentAngle = new Vector3(
            Mathf.LerpAngle(transform.rotation.eulerAngles.x, _currentView.rotation.eulerAngles.x, Time.deltaTime * _transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.y, _currentView.rotation.eulerAngles.y, Time.deltaTime * _transitionSpeed),
            Mathf.LerpAngle(transform.rotation.eulerAngles.z, _currentView.rotation.eulerAngles.z, Time.deltaTime * _transitionSpeed)
            );
        transform.eulerAngles = currentAngle;
    }

    public bool CameraReachedDestination()
    {
        return Vector3.Distance(transform.position, _currentView.position)<0.5f;
    }

    public void TransitionCameraToPhase(int i)
    {
        if (i < 2) return;  

        _currentView = views[i-2];
    }
}
