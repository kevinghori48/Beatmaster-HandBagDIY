using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag : MonoBehaviour
{ 
    public List<GameObject> TopVariation = new List<GameObject>();
    public List<GameObject> Ornaments= new List<GameObject>();

    public List<Material> ColorVariation = new List<Material>();
    public List<MeshRenderer> BagMesh = new List<MeshRenderer>();
    public List<MeshRenderer> BagMeshTwomat = new List<MeshRenderer>();

    private GameManager _manager;


    // Start is called before the first frame update
    void Start()
    {
        _manager = GameManager.Instance;
        if(_manager.SelectedTopVariation != 0)
            TopVariation[_manager.SelectedTopVariation -1].SetActive(true);

        if(_manager.SelectedOrnaments != 0)
        Ornaments[_manager.SelectedOrnaments - 1].SetActive(true);

        GetComponent<MeshRenderer>().material = ColorVariation[_manager.SelectedColor];
        foreach (MeshRenderer renderer in BagMesh)
            renderer.material = ColorVariation[_manager.SelectedColor];
        foreach (MeshRenderer renderer in BagMeshTwomat)
            renderer.materials = new Material[]{ ColorVariation[_manager.SelectedColor],
                 ColorVariation[_manager.SelectedColor] };
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
