using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class TrianglePrimitive2 : MonoBehaviour
{
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(0, 0, 0), // 0  /A
            //new Vector3(3, 0, 0),  //B
            new Vector3(1.5f, 0, 2.6f),    //C
            new Vector3(1.5f, 2.45f, 0.87f),  //G
        };

        mesh.vertices = vertices;

        int[] triangles = {
           // 1, 0, 2, //C,B,G
           0, 1, 2  // A,C,G
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        uvs[0] = new Vector2(0.29f, 0.79f);  // A
        uvs[1] = new Vector2(0.51f, 0.78f);  // C  (0.41f, 0.95f
        uvs[2] = new Vector2(0.41f, 0.62f); // G


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;

    }
}
