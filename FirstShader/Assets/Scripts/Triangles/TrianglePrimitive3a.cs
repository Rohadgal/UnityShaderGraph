using UnityEngine;

public class TrianglePrimitive3a : MonoBehaviour {
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
          //  new Vector3(0, 0, 0), // 0  /A
            new Vector3(-3f, 0f, 0f),  //D
            new Vector3(-1.5f, 0, 2.6f),    //E
            new Vector3(-1.5f, 2.45f, 0.87f)   //H
        };

        mesh.vertices = vertices;

        int[] triangles = {
         //  0, 2, 1,  // A, E, D
           0, 1, 2, //D,E,H   ---------
             //0, 1, 3 //A,D,H
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        // uvs[0] = new Vector2(0.29f, 0.78f);  // a
        uvs[0] = new Vector2(0.26f, 0.42f);    // e
        uvs[1] = new Vector2(0.38f, 0.59f); // d
        uvs[2] = new Vector2(0.51f, 0.42f);   // h

        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;
    }
}