using UnityEngine;
using TMPro;

public class KinematicsLevel : MonoBehaviour
{
    public TextMeshProUGUI initialSpeedText;
    public TextMeshProUGUI angleText;
    public TextMeshProUGUI distanceText;

    public ArrowGenerator ballArrow;

    public ArrowGenerator SourceDistanceArrow;
    public ArrowGenerator TargetDistanceArrow;

    public Transform sourcePlatform;
    public Transform targetPlatform;

    public Transform sourceRoot, targetRoot;

    public Transform ARCamera;

    [HideInInspector] public int initialSpeed, angle;
    [HideInInspector] public float distance;

    private int[] initialSpeedValues = { 5, 6, 7, 8, 9, 10, 11, 12 };
    private int[] angleValues = { 15, 30, 45, 60, 75 };
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        int randomSpeed = initialSpeedValues[Random.Range(0, initialSpeedValues.Length)];
        int randomAngle = angleValues[Random.Range(0, angleValues.Length)];

        initialSpeedText.text = "Initial Speed (u): " + randomSpeed.ToString() + " m/s";
        angleText.text = "Angle (theta): " + randomAngle.ToString() + " degrees";

        initialSpeed = randomSpeed;
        angle = randomAngle;

        ballArrow.stemLength = initialSpeed;
        ballArrow.transform.localEulerAngles = new Vector3(ballArrow.transform.localEulerAngles.x, ballArrow.transform.localEulerAngles.y, angle);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Mathf.Round(Vector3.Distance(sourcePlatform.position, targetPlatform.position) * 100f) / 100f;

        float arrowDistance = Vector3.Distance(SourceDistanceArrow.transform.position, TargetDistanceArrow.transform.position);
        if (distance > 7) {
            SourceDistanceArrow.stemLength = arrowDistance * 0.33f;
            TargetDistanceArrow.stemLength = arrowDistance * 0.33f;
        } else {
            SourceDistanceArrow.stemLength = arrowDistance * 0.25f;
            TargetDistanceArrow.stemLength = arrowDistance * 0.25f;
        }

        distanceText.text = distance + "m";
        distanceText.rectTransform.position = (sourcePlatform.position + targetPlatform.position) / 2;
        distanceText.transform.LookAt(distanceText.transform.position - ARCamera.position);

        sourceRoot.LookAt(targetRoot);
        targetRoot.LookAt(sourceRoot);
    }
}
