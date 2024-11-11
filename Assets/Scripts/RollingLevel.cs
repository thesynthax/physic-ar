using UnityEngine;
using TMPro;

public class RollingLevel : MonoBehaviour
{
    public TextMeshProUGUI u1Text;
    public TextMeshProUGUI m1Text;
    public TextMeshProUGUI u2Text;
    public TextMeshProUGUI m2Text;

    [HideInInspector] public float u1, m1;

    //private int[] u1Values = { 5, 6, 7, 8, 9, 10, 11, 12 };
    //private int[] m1Values = { 15, 30, 45, 60, 75 };
    
    void Awake()
    {
        u1 = 5;
        m1 = 10;
    }

    public void UpdateValues(float _u1, float _m1, float _u2, float _m2)
    {
        u1Text.text = "u1 = " + _u1 + "m/s";
        m1Text.text = "m1 = " + _m1 + "kg";
        u2Text.text = "u2 = " + _u2 + "m/s";
        m2Text.text = "m2 = " + _m2 + "kg";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
