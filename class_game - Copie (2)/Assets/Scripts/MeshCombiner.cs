using UnityEngine;

public class MeshCombiner : MonoBehaviour
{
    void Start()
    {
        MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();
        Mesh finalMesh = new Mesh();

        CombineInstance[] combine = new CombineInstance[meshFilters.Length - 1];
        for (int i = 1; i < meshFilters.Length; i++)
        {
            combine[i - 1].mesh = meshFilters[i].sharedMesh;
            combine[i - 1].transform = meshFilters[i].transform.localToWorldMatrix;
            meshFilters[i].gameObject.SetActive(false);
        }

        finalMesh.CombineMeshes(combine, true, true);

        // Appliquer le maillage combiné à l'objet parent
        MeshFilter parentMeshFilter = GetComponent<MeshFilter>();
        if (parentMeshFilter == null)
            parentMeshFilter = gameObject.AddComponent<MeshFilter>();
        parentMeshFilter.sharedMesh = finalMesh;

        // Réinitialiser les objets enfants
        foreach (MeshFilter meshFilter in meshFilters)
        {
            meshFilter.transform.SetParent(transform);
            meshFilter.gameObject.SetActive(true);
        }
    }
}
