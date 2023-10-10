using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formulas {



    public float Distance(Vector3 a, Vector3 b) {
        float x = Mathf.Pow((b.x - a.x), 2); // Restar x_b - x_a y elevarlo al cuadrado
        float y = Mathf.Pow((b.y - a.y), 2); // Restar y_b - y_a y elevarlo al cuadrado
        float z = Mathf.Pow((b.z - a.z), 2); // Restar z_b - z_a y elevarlo al cuadrado

        return Mathf.Sqrt(x + y + z);
    }

    public float Magnitud(Vector3 a) {
        float x = Mathf.Pow(a.x, 2);
        float y = Mathf.Pow(a.y, 2);
        float z = Mathf.Pow(a.z, 2);

        return Mathf.Sqrt(x + y + z);
    }

    public Vector3 Normalizar(Vector3 a) {
        float mag = Magnitud(a);

        return a / mag;
    }

    public float ProductoPunto(Vector3 a, Vector3 b) {
        float result;
        Vector3 producto;
        producto = new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);

        return result = producto.x + producto.y + producto.z;
    }

    public Vector3 ProductoCruz(Vector3 a, Vector3 b) {
        Vector3 resultado;

        resultado.x = (a.y * b.z) - (b.y * a.z);
        resultado.y = (-1) * ((a.x * b.z) - (b.x * a.z));
        resultado.z = (a.x * b.y) - (b.x * a.y);

        return resultado;
    }

    public Vector3 MovimientoDeMatriz(Vector3 ubicacion, Vector3 delta) {
        Vector3 ubicacionActualizada = ubicacion + delta;

        return ubicacionActualizada;
    }

    public Vector3 MovimientoDeMatrices(Vector3 ubicacion, Vector3 delta) {
        Vector3 ubicacionActualizada;
        Vector4 x = new Vector4(1, 0, 0, 0);
        Vector4 y = new Vector4(0, 1, 0, 0);
        Vector4 z = new Vector4(0, 0, 1, 0);
        Vector4 VectorDelta = new Vector4(delta.x, delta.y, delta.z, 1);
        Vector4 vectorUbicacion = new Vector4(ubicacion.x, ubicacion.y, ubicacion.z, 1);

        Matrix4x4 matrizUbicacion = new Matrix4x4(x, y, z, delta);
        ubicacionActualizada = matrizUbicacion * vectorUbicacion;

        return ubicacionActualizada;
    }

    public Vector3 RotacionDeMatrizX(Vector3 ubicacionActual, float angle) {
        Vector3 ubicacionActualizada;

        Vector4 x = new Vector4(1, 0, 0, 0);
        Vector4 y = new Vector4(0, Mathf.Cos(angle), (-1) * Mathf.Sin(angle), 0);
        Vector4 z = new Vector4(0, Mathf.Sin(angle), Mathf.Cos(angle), 0);
        Vector4 VectorAgregado = new Vector4(0, 0, 0, 1);
        Vector4 vectorUbicacion = new Vector4(ubicacionActual.x, ubicacionActual.y, ubicacionActual.z, 1);
        Matrix4x4 MatrizBase = new Matrix4x4(x, y, z, VectorAgregado);

        ubicacionActualizada = MatrizBase * vectorUbicacion;

        return ubicacionActualizada;
    }

    public Vector3 RotacionDeMatrizY(Vector3 ubicacionActual, float angle) {
        Vector3 ubicacionActualizada;

        Vector4 x = new Vector4(Mathf.Cos(angle), 0, Mathf.Sin(angle), 0);
        Vector4 y = new Vector4(0, 1, 0, 0);
        Vector4 z = new Vector4((-1) * Mathf.Sin(angle), 0, Mathf.Cos(angle), 0);
        Vector4 VectorAgregado = new Vector4(0, 0, 0, 1);
        Vector4 vectorUbicacion = new Vector4(ubicacionActual.x, ubicacionActual.y, ubicacionActual.z, 1);
        Matrix4x4 MatrizBase = new Matrix4x4(x, y, z, VectorAgregado);

        ubicacionActualizada = MatrizBase * vectorUbicacion;

        return ubicacionActualizada;
    }

    public Vector3 RotacionDeMatrizZ(Vector3 ubicacionActual, float angle) {
        Vector3 ubicacionActualizada;

        Vector4 x = new Vector4(Mathf.Cos(angle), (-1) * Mathf.Sin(angle), 0, 0);
        Vector4 y = new Vector4(Mathf.Sin(angle), Mathf.Cos(angle), 0, 0);
        Vector4 z = new Vector4(0, 0, 1, 0);

        Vector4 VectorAgregado = new Vector4(0, 0, 0, 1);
        Vector4 vectorUbicacion = new Vector4(ubicacionActual.x, ubicacionActual.y, ubicacionActual.z, 1);
        Matrix4x4 MatrizBase = new Matrix4x4(x, y, z, VectorAgregado);

        ubicacionActualizada = MatrizBase * vectorUbicacion;

        return ubicacionActualizada;
    }



    //public Transform originalPos; 

    public Vector3 rotationZ(Vector3 pos, float angle) {

        Matrix4x4 matrix = Matrix4x4.identity;
        angle = angle * Mathf.Deg2Rad;

        matrix.m00 = Mathf.Cos(angle);
        matrix.m01 = -Mathf.Sin(angle);
        matrix.m10 = Mathf.Sin(angle);
        matrix.m11 = Mathf.Cos(angle);

        //Vector4 temp = new Vector4(pos.x, pos.y, pos.z, 1);

        Vector3 result = matrix * pos;

        return result;

    }

    public Vector3 newRotation(Vector3 originalPosition, float angle, Vector3 centerOfCube) {
        Matrix4x4 matrix = Matrix4x4.identity;

        angle = angle * Mathf.Deg2Rad;

        matrix.m00 = Mathf.Cos(angle);
        matrix.m01 = -Mathf.Sin(angle);
        matrix.m10 = Mathf.Sin(angle);
        matrix.m11 = Mathf.Cos(angle);

        //Vector3 newPosition = centerOfCube + matrix.MultiplyPoint3x4(originalPosition - centerOfCube);

        Vector3 newPosition = new Vector4(centerOfCube.x, centerOfCube.y, centerOfCube.z, 1) + (matrix * new Vector4(originalPosition.x - centerOfCube.x,
        originalPosition.y - centerOfCube.y, originalPosition.z - centerOfCube.z, 1));

        return newPosition;
    }

    public Vector3 Quaternion(Vector4 q, Vector3 pos) {
        float angle = q.w * Mathf.Deg2Rad;

        float w = Mathf.Cos(angle / 2);

        Vector3 v = new Vector3(q.x, q.y, q.z);

        Vector3 v_normal = Normalizar(v);

        v.x = v_normal.x * Mathf.Sin(angle / 2);
        v.y = v_normal.y * Mathf.Sin(angle / 2);
        v.z = v_normal.z * Mathf.Sin(angle / 2);

        Matrix4x4 matrix = Matrix4x4.identity;

        matrix.m00 = 1 - 2 + Mathf.Pow(v.y, 2) - 2 * Mathf.Pow(v.z, 2);
        matrix.m01 = 2 * v.x * v.y - 2 * w * v.z;
        matrix.m02 = 2 * v.x * v.z + 2 * w * v.y;

        matrix.m10 = 2 * v.x * v.y + 2 * w * v.z;
        matrix.m11 = 1 - 2 * Mathf.Pow(v.x, 2) - 2 * Mathf.Pow(v.z, 2);
        matrix.m12 = 2 * v.y * v.z - 2 * w * v.x;

        matrix.m20 = 2 * v.x * v.z - 2 * w * v.y;
        matrix.m21 = 2 * v.y * v.z + 2 * w * v.x;
        matrix.m22 = 1 - 2 * Mathf.Pow(v.x, 2) - 2 * Mathf.Pow(v.y, 2);

        // Vector3 resultado = new Vector4(rotationPivot.x, rotationPivot.y, rotationPivot.z) + (matrix * new Vector4(pos.x - rotationPivot.x, 
        // pos.y - rotationPivot.y, pos.z - rotationPivot.z, 1));

        Vector3 resultado = matrix * new Vector4(pos.x, pos.y, pos.z, 1);

        //Vector3 newPosition = new Vector4(centerOfCube.x, centerOfCube.y, centerOfCube.z, 1) + (matrix* new Vector4(originalPosition.x - centerOfCube.x,
        //originalPosition.y - centerOfCube.y, originalPosition.z - centerOfCube.z, 1));

        return resultado;
    }
}
