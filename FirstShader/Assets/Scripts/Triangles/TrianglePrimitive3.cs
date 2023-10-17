using UnityEngine;

public class TrianglePrimitive3 : MonoBehaviour {
    public Material mat;

    Mesh mesh;
    MeshRenderer meshRenderer;

    void Start() {
        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();

        Vector3[] vertices = {
            new Vector3(0, 0, 0), // 0  /A
            new Vector3(-3F, 0f, 0f),  //D
            new Vector3(-1.5f, 0, 2.6f),    //E
            new Vector3(-1.5f, 2.45f, 0.87f)   //H
        };

        mesh.vertices = vertices;

        int[] triangles = {
           0, 2, 1,  // A, E, D
           1, 2, 3, //D,E,H
             //0, 1, 3 //A,D,H
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        uvs[0] = new Vector2(0.26f, 0.42f);  // a
        uvs[1] = new Vector2(0.14f, 0.74f);  // e
        uvs[2] = new Vector2(0.38f, 0.59f); // d
        uvs[3] = new Vector2(0.26f, 0.76f);  // h

        //uvs[0] = new Vector2(0.29f, 0.78f);  // A
        //uvs[1] = new Vector2(0.41f, 0.95f);  // B  (0.41f, 0.95f
        //uvs[2] = new Vector2(0.52f, 0.78f); // C
        //uvs[3] = new Vector2(0.16f, 0.95f); // g

        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;
    }
}