using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyS : MonoBehaviour
{


    float radius = 1.0f;


    List<Vector3> points;

    List<int> angleindex;
    void Start()
    {

        points = new List<Vector3>();

        angleindex = new List<int>();
       
       
        Mesh mesh = GetComponent<MeshFilter>().mesh;

        mesh.Clear();

        print("basladı");
        Vector3 ca0 = new Vector3(0, 0, 0);
        Vector3 ca1 = new Vector3(radius * Mathf.Cos(Mathf.Deg2Rad * 0), radius * Mathf.Sin(Mathf.Deg2Rad * 0), 0);
        points.Add(ca0);
        points.Add(ca1);
        for (int i=0;i<361;i++)
        {
            Vector3 ca2 = new Vector3(radius * Mathf.Cos(Mathf.Deg2Rad * -i), radius * Mathf.Sin(Mathf.Deg2Rad * -i), 0);

            points.Add(ca2);

            angleindex.Add(0);
            angleindex.Add(i+1);
            angleindex.Add(i+2);

        }

        print("bitti");
        mesh.vertices = points.ToArray();
       
        mesh.triangles= angleindex.ToArray();

        print("cok bııtıt");
    }

}
