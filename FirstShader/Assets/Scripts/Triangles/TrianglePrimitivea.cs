using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class TrianglePrimitivea : MonoBehaviour
{
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        makeTriangles();
    }

    void makeTriangles() {

        Vector3[] vertices = {
            new Vector3(0, 0, 0), // 0  /A
           new Vector3(3, 0, 0), //1  /B
           new Vector3(1.5f, 2.45f, 0.87f), //6   /G
        };

        mesh.vertices = vertices;

        int[] triangles = {
            0, 2, 1, //base  //A,g,b
           
          //  0, 3, 1, //A,G,B
           // 5, 4, 6
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        uvs[0] = new Vector2(0.41f, 0.95f);  // a
        uvs[1] = new Vector2(0.29f, 0.78f); // b
        uvs[2] = new Vector2(0.16f, 0.95f);  // c


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;
    }
}
