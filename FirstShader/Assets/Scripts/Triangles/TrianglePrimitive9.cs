using UnityEngine;

public class TrianglePrimitive9 : MonoBehaviour {
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(-1.5f, 0, 2.6f), //4   /E
            new Vector3(0, 0, 5.2f), //5  /F
            new Vector3(0, 2.45f, 3.47f), //8   /I
        };

        mesh.vertices = vertices;

        int[] triangles = {
            0, 1, 2, //E,F,I
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        uvs[0] = new Vector2(0.41f, 0.95f);  // I
        uvs[1] = new Vector2(0.29f, 0.78f);  // E
        uvs[2] = new Vector2(0.16f, 0.95f); // F


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;

    }
}
