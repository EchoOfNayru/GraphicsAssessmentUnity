using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugVisuals : MonoBehaviour {

    MeshFilter filter;

    private void Start()
    {
        filter = GetComponent<MeshFilter>();
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;

        foreach (Vector3 vert in filter.mesh.vertices)
        {
            Gizmos.DrawWireSphere(transform.TransformPoint(vert), 0.05f);
        }
    }
}
