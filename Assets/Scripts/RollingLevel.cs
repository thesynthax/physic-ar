using UnityEngine;
using TMPro;

public class RollingLevel : MonoBehaviour
{
    public Transform sourceRoot;
    public Transform targetRoot;

    public Transform sourceMarker, targetMarker;
    public Transform heightTextRoot;
    public Transform ARCamera;
    public TextMeshProUGUI heightText;

    public ArrowGenerator arrow;

    private float yDist;
    // Update is called once per frame
    void Update()
    {
        yDist = Vector3.Distance(sourceMarker.position, targetMarker.position) / 2f;
        yDist = Mathf.Clamp(yDist, 2f, 6f);
        sourceRoot.position = targetRoot.position + targetRoot.forward * 10f + targetRoot.up * yDist;

        sourceRoot.LookAt(new Vector3(targetRoot.position.x, sourceRoot.position.y, targetRoot.position.z));

        heightText.text = (Mathf.Round(yDist * 100f)/100f).ToString() + "m";
        heightText.rectTransform.position = sourceRoot.position - sourceRoot.up * yDist * 0.7f;
        heightTextRoot.LookAt(heightTextRoot.position + ARCamera.rotation * Vector3.forward, ARCamera.rotation * Vector3.up);

        arrow.stemLength = yDist * 0.5f;

        //targetRoot.LookAt(sourceRoot, Vector3.up);
    }
}
