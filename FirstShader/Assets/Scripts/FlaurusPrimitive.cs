using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class FlaurusPrimitive : MonoBehaviour {
    public Material mat;
    Formulas formulas = new Formulas();

    Mesh mesh;
    MeshRenderer meshRenderer;

    //Vector3[] verticesRotadosEnX;
    //Vector3[] verticesRotadosEnZ;


    private void Start() {
        Vector3[] vertices =
    {
            new Vector3(0, 0, 0), // 0  /A
            new Vector3(3, 0, 0), //1  /B
            new Vector3(1.5f, 0, 2.6f), //2   /C
            new Vector3(-3, 0, 0), //3   /D
            new Vector3(-1.5f, 0, 2.6f), //4   /E
            new Vector3(0, 0, 5.2f), //5  /F
            new Vector3(1.5f, 2.45f, 0.87f), //6   /G
            new Vector3(-1.5f, 2.45f, 0.87f), //7    /H
            new Vector3(0, 2.45f, 3.47f), //8   /I
            new Vector3(0, 4.9f, 1.74f), //9   /J
        };

        for (int i = 0; i < vertices.Length; i++) {
            vertices[i] = formulas.RotacionDeMatrizX(vertices[i], 45f);
            vertices[i] = formulas.MovimientoDeMatrices(vertices[i], new Vector3(3, 4, 5));
        }

        for (int i = 0; i < vertices.Length; i++) {
            vertices[i] = formulas.RotacionDeMatrizZ(vertices[i], 23);
        }

        for (int i = 0; i < vertices.Length; i++) {
            vertices[i] = formulas.RotacionDeMatrizY(vertices[i], 62);
        }

        int[] triangles =
        {
            0, 1, 2, //base  //A,B,C
            0, 6, 1, //A,G,B
            2, 1, 6, //C,B,G
            0, 2, 6, //A,C,G
            0, 4, 3, //base  //A,E,D
            0, 3, 7, //A,D,H
            3, 4, 7, //D,E,H
            4, 0, 7, //E,A,H
            4, 2, 5, // base  //E,C,F
            2, 4, 8, //C,E,I
            4, 5, 8, //E,F,I
            5, 2, 8, //F,C,I
            7, 6, 8, // base  /H,G,I
            6, 7, 9, //G,H,J
            7, 8, 9, //H,I,J
            8, 6, 9, //I,G,J
        };

        mesh = GetComponent<MeshFilter>().mesh;
        meshRenderer = GetComponent<MeshRenderer>();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        meshRenderer.material = mat;
    }
}