using UnityEngine;

public class TrianglePrimitive10 : MonoBehaviour {
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(1.5f, 2.45f, 0.87f), //G
            new Vector3(-1.5f, 2.45f, 0.87f), //H
            new Vector3(0, 2.45f, 3.47f), //I
        };

        mesh.vertices = vertices;

        int[] triangles = {
            1, 0, 2, // base  /H,G,I
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        uvs[0] = new Vector2(0.49f, 0.20f);  // G
        uvs[1] = new Vector2(0.72f, 0.20f);  // H
        uvs[2] = new Vector2(0.60f, 0.40f); // I


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;

    }
}
