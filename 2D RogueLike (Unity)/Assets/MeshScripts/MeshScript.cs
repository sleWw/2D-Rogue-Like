using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProgrammingPractice
{
    [RequireComponent(typeof(MeshFilter))]
    public class MeshScript : MonoBehaviour
    {
        Mesh mesh;
        Vector3[] vertices;
        int[] triangles;

        void Start()
        {
            mesh = new Mesh();
            GetComponent<MeshFilter>().mesh = mesh;
            CreateShape();
            UpdateMesh();
        }

        void CreateShape(){
            vertices = new Vector3[]
            {
                new Vector3(0,0,0),
                new Vector3(0,0,1),
                new Vector3(1,0,0),
                new Vector3(1,0,1)
            };

            triangles = new int[]
            {
                0, 1, 2,
                1, 3 ,2

            };
        }

        void UpdateMesh(){
            mesh.Clear();
            mesh.vertices = vertices;
            mesh.triangles = triangles;
        }
    }
}