using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class TrianglePrimitive : MonoBehaviour
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
            new Vector3(1.5f, 0, 2.6f), //2   /C
            new Vector3(1.5f, 2.45f, 0.87f), //6   /G

            //new Vector3(3, 0, 0),  //B
            //new Vector3(1.5f, 0, 2.6f),    //C
            //new Vector3(1.5f, 2.45f, 0.87f),  //G
        };

        mesh.vertices = vertices;

        int[] triangles = {
            0, 1, 2, //base  //A,B,C
           
            0, 3, 1, //A,G,B
           // 5, 4, 6
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        uvs[0] = new Vector2(0.29f, 0.78f);  // A
        uvs[1] = new Vector2(0.41f, 0.95f);  // B  (0.41f, 0.95f
        uvs[2] = new Vector2(0.52f, 0.78f); // C
        uvs[3] = new Vector2(0.16f, 0.95f); // g

        //uvs[4] = new Vector2(0.42f, 0.95f);  // B
        //uvs[5] = new Vector2(0.53f, 0.79f);  // C  (0.41f, 0.95f
        //uvs[6] = new Vector2(0.66f, 0.95f); // G

        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;
    }
}
