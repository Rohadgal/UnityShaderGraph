using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class CombinedTrianglePrimitives : MonoBehaviour {
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        // Llama a una función para crear los triángulos
        CreateTriangles();
    }

    void CreateTriangles() {
        Vector3[] vertices;
        int[] triangles;
        Vector2[] uvs;

        // Triángulo 1
        vertices = new Vector3[]
        {
            new Vector3(0, 0, 0), // A
            new Vector3(3, 0, 0), // B
            new Vector3(1.5f, 0, 2.6f), // C
            new Vector3(1.5f, 2.45f, 0.87f) // G
        };

        triangles = new int[]
        {
            0, 1, 2, // A, B, C
            0, 3, 1 // A, G, B
        };

        uvs = new Vector2[]
        {
            new Vector2(0.29f, 0.78f), // A
            new Vector2(0.41f, 0.95f), // B
            new Vector2(0.52f, 0.78f), // C
            new Vector2(0.16f, 0.95f) // G
        };

        // Combina los vértices, triángulos y UVs
        CombineMesh(vertices, triangles, uvs);

        // Triángulo 2
        vertices = new Vector3[]
        {
            new Vector3(3, 0, 0), // B
            new Vector3(1.5f, 0, 2.6f), // C
            new Vector3(1.5f, 2.45f, 0.87f) // G
        };

        triangles = new int[]
        {
            0, 1, 2 // B, C, G
        };

        uvs = new Vector2[]
        {
            new Vector2(0.42f, 0.95f), // B
            new Vector2(0.53f, 0.79f), // C
            new Vector2(0.66f, 0.95f) // G
        };

        // Combina los vértices, triángulos y UVs
        CombineMesh(vertices, triangles, uvs);

        // Triángulo 3
        vertices = new Vector3[]
        {
            new Vector3(0, 0, 0), // A
            new Vector3(1.5f, 0, 2.6f), // C
            new Vector3(1.5f, 2.45f, 0.87f) // G
        };

        triangles = new int[]
        {
            0, 1, 2 // A, C, G
        };

        uvs = new Vector2[]
        {
            new Vector2(0.29f, 0.79f), // A
            new Vector2(0.51f, 0.78f), // C
            new Vector2(0.41f, 0.62f) // G
        };

        // Combina los vértices, triángulos y UVs
        CombineMesh(vertices, triangles, uvs);
    }

    void CombineMesh(Vector3[] vertices, int[] triangles, Vector2[] uvs) {
        int vertexCount = mesh.vertexCount;
        Vector3[] currentVertices = mesh.vertices;
        int[] currentTriangles = mesh.triangles;
        Vector2[] currentUVs = mesh.uv;

        // Combina los vértices
        Vector3[] combinedVertices = new Vector3[vertexCount + vertices.Length];
        currentVertices.CopyTo(combinedVertices, 0);
        vertices.CopyTo(combinedVertices, vertexCount);

        // Combina los triángulos
        int[] combinedTriangles = new int[currentTriangles.Length + triangles.Length];
        currentTriangles.CopyTo(combinedTriangles, 0);
        for (int i = 0; i < triangles.Length; i++) {
            combinedTriangles[currentTriangles.Length + i] = triangles[i] + vertexCount;
        }

        // Combina los UVs
        Vector2[] combinedUVs = new Vector2[currentUVs.Length + uvs.Length];
        currentUVs.CopyTo(combinedUVs, 0);
        uvs.CopyTo(combinedUVs, currentUVs.Length);

        // Asigna los datos combinados a la malla
        mesh.vertices = combinedVertices;
        mesh.triangles = combinedTriangles;
        mesh.uv = combinedUVs;


    }
}