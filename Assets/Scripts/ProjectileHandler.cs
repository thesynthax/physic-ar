using UnityEngine;

public class ProjectileHandler : MonoBehaviour
{
    Rigidbody rb;
    float speed;
    float angle;
    public KinematicsLevel kinematics;
    Vector3 originalPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        originalPos = transform.position;

        speed = kinematics.initialSpeed;
        angle = kinematics.angle;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        float angleRad = Mathf.Deg2Rad * angle;
        float xVel = speed * Mathf.Cos(angleRad);
        float yVel = speed * Mathf.Sin(angleRad);

        Debug.Log(xVel);

        rb.linearVelocity = new Vector3(xVel, yVel, 0);

        kinematics.ballArrow.gameObject.SetActive(false);
    }

    public void Reset()
    {
        transform.position = originalPos;
        transform.localEulerAngles = Vector3.zero;
        rb.linearVelocity = Vector3.zero;

        kinematics.ballArrow.gameObject.SetActive(true);
    }

}
