using UnityEngine;

public class TrianglePrimitive6 : MonoBehaviour
{
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(-1.5f, 0, 2.6f),   //E
            new Vector3(1.5f, 0, 2.6f), //C
            new Vector3(0, 0, 5.2f), //F
        };

        mesh.vertices = vertices;

        int[] triangles = {
            0, 1, 2, // base  //E,C,F
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        uvs[0] = new Vector2(0.41f, 0.95f);  // e
        uvs[1] = new Vector2(0.29f, 0.78f);// c
        uvs[2] = new Vector2(0.16f, 0.95f);   // f


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;

    }
}
