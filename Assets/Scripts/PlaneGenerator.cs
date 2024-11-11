using UnityEngine;

public class PlaneGenerator : MonoBehaviour
{
    public Transform source, target;

    GameObject go;
    MeshFilter mf;
    MeshRenderer mr;
    Mesh m;
    MeshCollider c;
    public Material mat;
    public PhysicsMaterial pMat;

    private void Start()
    {
        go = new GameObject("Plane");
        mf = go.AddComponent(typeof(MeshFilter)) as MeshFilter;
        mr = go.AddComponent(typeof(MeshRenderer)) as MeshRenderer;
        c = go.AddComponent(typeof(MeshCollider)) as MeshCollider;

        m = new Mesh();
        mr.material = mat;
        c.material = pMat;
    }

    private void Update()
    {
        /*m.vertices = new Vector3[] {
            source.position + new Vector3(source.GetComponent<Collider>().bounds.extents.x, source.GetComponent<Collider>().bounds.extents.y, -source.GetComponent<Collider>().bounds.extents.z), 
            target.position + new Vector3(-target.GetComponent<Collider>().bounds.extents.x, source.GetComponent<Collider>().bounds.extents.y, -source.GetComponent<Collider>().bounds.extents.z),
            target.position + new Vector3(-target.GetComponent<Collider>().bounds.extents.x, source.GetComponent<Collider>().bounds.extents.y, source.GetComponent<Collider>().bounds.extents.z),
            source.position + new Vector3(source.GetComponent<Collider>().bounds.extents.x, source.GetComponent<Collider>().bounds.extents.y, source.GetComponent<Collider>().bounds.extents.z) 
        };*/

        m.vertices = new Vector3[] {
            source.position + source.up * source.localScale.y - source.forward * source.localScale.z - source.right * source.localScale.x,
            target.position + target.up * target.localScale.y + target.forward * target.localScale.z - target.right * target.localScale.x,
            target.position + target.up * target.localScale.y - target.forward * target.localScale.z - target.right * target.localScale.x,
            source.position + source.up * source.localScale.y + source.forward * source.localScale.z - source.right * source.localScale.x
        };

        m.uv = new Vector2[] {
            new Vector2(0,0),
            new Vector2(0,1),
            new Vector2(1,1),
            new Vector2(1,0)
        };

        m.triangles = new int[] {0, 1, 2, 0, 2, 3};

        mf.mesh = m;
        c.sharedMesh = m;

        m.RecalculateBounds();
        m.RecalculateNormals();

    }
}
