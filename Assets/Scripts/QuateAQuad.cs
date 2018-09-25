using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuateAQuad : MonoBehaviour {

    public float size;
    public float red, blue, green, alpha;

    void Start()
    {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();
        filter.mesh = mesh;

        // Vertices
        // locations of vertices
        var verts = new Vector3[4];

        verts[0] = new Vector3(-size, -size, 0);
        verts[1] = new Vector3(size, -size, 0);
        verts[2] = new Vector3(-size, size, 0);
        verts[3] = new Vector3(size, size, 0);
        mesh.vertices = verts;

        // Indices
        // determines which vertices make up an individual triangle
        var indices = new int[6];

        indices[0] = 0;
        indices[1] = 2;
        indices[2] = 1;
        indices[3] = 3;
        indices[4] = 1;
        indices[5] = 2;

        mesh.triangles = indices;

        // Normals
        // describes how light bounces off the surface (at the vertex level)
        //var norms = new Vector3[3];

        //norms[0] = -Vector3.forward;
        //norms[1] = -Vector3.forward;
        //norms[2] = -Vector3.forward;

        //mesh.normals = norms;

        // UVs, STs
        // defines how textures are mapped onto the surface
        var UVs = new Vector2[4];

        UVs[0] = new Vector2(0, 0);
        UVs[1] = new Vector2(1, 0);
        UVs[2] = new Vector2(0, 1);
        UVs[3] = new Vector2(1, 1);

        mesh.uv = UVs;


        Material m_Material = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        
    }
}
