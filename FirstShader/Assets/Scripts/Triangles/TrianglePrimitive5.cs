using UnityEngine;

public class TrianglePrimitive5 : MonoBehaviour
{
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(0, 0, 0), //A
            new Vector3(-1.5f, 0, 2.6f), //4   /E
            new Vector3(-1.5f, 2.45f, 0.87f), //H
        };

        mesh.vertices = vertices;

        int[] triangles = {
            1, 0, 2, //E,A,H
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        //uvs[0] = new Vector2(0.29f, 0.79f);  // A
        //uvs[1] = new Vector2(0.51f, 0.78f);  // C  (0.41f, 0.95f
        //uvs[2] = new Vector2(0.41f, 0.62f); // G


        uvs[0] = new Vector2(0.26f, 0.42f);  // C  (0.41f, 0.95f
        uvs[1] = new Vector2(0.38f, 0.59f); // G
        uvs[2] = new Vector2(0.51f, 0.42f);  // A


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;

    }
}
