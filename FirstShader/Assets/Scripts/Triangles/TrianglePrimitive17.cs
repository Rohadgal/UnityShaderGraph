using UnityEngine;

public class TrianglePrimitive17 : MonoBehaviour {
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(0, 0, 0), // 0  /A
            new Vector3(1.5f, 0, 2.6f), //2   /C
            new Vector3(-1.5f, 0, 2.6f), //4   /E
        };

        mesh.vertices = vertices;

        int[] triangles = {
            0, 1, 2, //A,C,E
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];


        uvs[0] = new Vector2(0.66f, 0.95f); // E
        uvs[1] = new Vector2(0.42f, 0.95f);  // H
        uvs[2] = new Vector2(0.53f, 0.79f);  // I


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;

    }
}
