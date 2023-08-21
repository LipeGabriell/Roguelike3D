
using UnityEngine;
using Random = UnityEngine.Random;

public class MeshRandomizer : MonoBehaviour
{
    private MeshFilter _meshFilter;
    [SerializeField] private Mesh[] possibleMeshes;


    private void Awake()
    {
        TryGetComponent(out _meshFilter);
    }

    private void Start()
    {
        if (Random.Range(1, 6) == 5) ChangeMesh();
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)) ChangeMesh();
    }

    private void ChangeMesh()
    {
        var wichMesh = Random.Range(0, possibleMeshes.Length);
        _meshFilter.mesh = possibleMeshes[wichMesh];
    }
}