using UnityEngine;

public class TrianglePrimitive4 : MonoBehaviour
{
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(0, 0, 0), //A
            new Vector3(-3, 0, 0), //D
            new Vector3(-1.5f, 2.45f, 0.87f), //H
        };

        mesh.vertices = vertices;

        int[] triangles = {
              0, 1, 2, //A,D,H
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        //uvs[0] = new Vector2(0.29f, 0.79f);  // A
        //uvs[1] = new Vector2(0.51f, 0.78f);  // C  (0.41f, 0.95f
        //uvs[2] = new Vector2(0.41f, 0.62f); // G


        uvs[0] = new Vector2(0.22f, 0.42f);  // C  (0.41f, 0.95f
        uvs[1] = new Vector2(0.13f, 0.59f); // G
        uvs[2] = new Vector2(0.01f, 0.42f);  // A


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;

    }
}
