using UnityEngine;

public class TrianglePrimitive15 : MonoBehaviour {
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(1.5f, 0, 2.6f), //2   /C
            new Vector3(1.5f, 2.45f, 0.87f), //6   /G
            new Vector3(0, 2.45f, 3.47f), //8   /I
        };

        mesh.vertices = vertices;

        int[] triangles = {
            0, 1, 2 //C, G, I
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];


        uvs[0] = new Vector2(0.66f, 0.95f); // C
        uvs[1] = new Vector2(0.42f, 0.95f);  // G
        uvs[2] = new Vector2(0.53f, 0.79f);  // I


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;

    }
}
