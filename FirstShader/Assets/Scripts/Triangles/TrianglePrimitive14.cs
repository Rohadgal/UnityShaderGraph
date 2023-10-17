using UnityEngine;

public class TrianglePrimitive14 : MonoBehaviour {
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(0, 0, 0), // 0  /A
            new Vector3(1.5f, 2.45f, 0.87f), //6   /G
            new Vector3(-1.5f, 2.45f, 0.87f), //7    /H
        };

        mesh.vertices = vertices;

        int[] triangles = {
            2, 1, 0, //H,G,A
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];


        uvs[0] = new Vector2(0.66f, 0.95f); // H
        uvs[1] = new Vector2(0.42f, 0.95f);  // A
        uvs[2] = new Vector2(0.53f, 0.79f);  // G


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;

    }
}
