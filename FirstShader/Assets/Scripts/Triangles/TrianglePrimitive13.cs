using UnityEngine;

public class TrianglePrimitive13 : MonoBehaviour {
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(-1.5f, 2.45f, 0.87f), //7    /H
            new Vector3(0, 2.45f, 3.47f), //8   /I
            new Vector3(0, 4.9f, 1.74f) //9   /J
        };

        mesh.vertices = vertices;

        int[] triangles = {
            0, 1, 2, //H,I,J
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];


        uvs[0] = new Vector2(0.42f, 0.95f);  // G
        uvs[1] = new Vector2(0.53f, 0.79f);  // J
        uvs[2] = new Vector2(0.66f, 0.95f); // I


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;

    }
}
