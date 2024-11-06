using UnityEngine;
using TMPro;

public class Kinematics : MonoBehaviour
{
    public TextMeshProUGUI initialSpeedText;
    public TextMeshProUGUI angleText;
    public TextMeshProUGUI distanceText;

    public ArrowGenerator ballArrow;

    public ArrowGenerator SourceDistanceArrow;
    public ArrowGenerator TargetDistanceArrow;

    public Transform sourcePlatform;
    public Transform targetPlatform;

    [HideInInspector] public int initialSpeed, angle;
    [HideInInspector] public float distance;

    private int[] initialSpeedValues = { 5, 6, 7, 8, 9, 10, 11, 12 };
    private int[] angleValues = { 15, 30, 45, 60, 75 };
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
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
        SourceDistanceArrow.stemLength = arrowDistance * 0.3f;
        TargetDistanceArrow.stemLength = arrowDistance * 0.3f;

        distanceText.text = distance + "m";
        distanceText.rectTransform.position = (sourcePlatform.position + targetPlatform.position) / 2;
        distanceText.rectTransform.position += new Vector3(0, 0.1f, 0);
    }
}
