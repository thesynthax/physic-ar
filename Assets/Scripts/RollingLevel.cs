using UnityEngine;
using TMPro;

public class RollingLevel : MonoBehaviour
{
    public Transform sourceRoot;
    public Transform targetRoot;

    public Transform sourceMarker, targetMarker;

    private float yDist;
    // Update is called once per frame
    void Update()
    {
        yDist = Vector3.Distance(sourceMarker.position, targetMarker.position);
        //sourceRoot.position = targetRoot.position + targetRoot.forward * 10f + targetRoot.up * yDist;

        sourceRoot.LookAt(new Vector3(targetRoot.position.x, sourceRoot.position.y, targetRoot.position.z));
        //targetRoot.LookAt(sourceRoot, Vector3.up);
    }
}
