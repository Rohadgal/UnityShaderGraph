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
            new Vector3(-3f, 0f, 0f),  //D
            new Vector3(-1.5f, 0, 2.6f),    //E
            //new Vector3(-1.5f, 2.45f, 0.87f)   //H
        };

        mesh.vertices = vertices;

        int[] triangles = {
           0, 2, 1,  // A, E, D
          // 1, 2, 3, //D,E,H   ---------
             //0, 1, 3 //A,D,H
        };

        Vector2[] uvs = new Vector2[mesh.vertices.Length];

        uvs[0] = new Vector2(0.49f, 0.20f);  // a
        uvs[1] = new Vector2(0.72f, 0.20f);  // e
        uvs[2] = new Vector2(0.60f, 0.40f); // d
        //uvs[3] = new Vector2(0.26f, 0.76f);  // h


        mesh.triangles = triangles;
        mesh.uv = uvs;
        meshRenderer.material = mat;
    }
}