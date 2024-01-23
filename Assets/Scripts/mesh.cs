using UnityEngine;

public class CenterAdjustment : MonoBehaviour
{
    void Start()
    {
        // Asegúrate de tener un componente MeshFilter en tu objeto
        MeshFilter meshFilter = GetComponent<MeshFilter>();

        if (meshFilter != null)
        {
            // Accede al Mesh del MeshFilter
            Mesh mesh = meshFilter.mesh;

            // Calcula el nuevo centro del Mesh
            Vector3[] vertices = mesh.vertices;
            Vector3 center = Vector3.zero;

            foreach (Vector3 vertex in vertices)
            {
                center += vertex;
            }

            center /= vertices.Length;

            // Mueve los vértices para que el centro sea (0, 0, 0)
            for (int i = 0; i < vertices.Length; i++)
            {
                vertices[i] -= center;
            }

            // Asigna los vértices modificados al Mesh
            mesh.vertices = vertices;

            // Actualiza el MeshCollider si lo tienes
            MeshCollider meshCollider = GetComponent<MeshCollider>();
            if (meshCollider != null)
            {
                meshCollider.sharedMesh = mesh;
            }

            // Asegúrate de recalcular las normales y actualizar el collider
            mesh.RecalculateNormals();
            mesh.RecalculateBounds();
        }
        else
        {
            Debug.LogWarning("Este objeto no tiene un componente MeshFilter.");
        }
    }
}
