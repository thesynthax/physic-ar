using TMPro;
using UnityEngine;

public class ProblemLogs : MonoBehaviour
{

    public TextMeshProUGUI problem;
    public TextMeshProUGUI problemDescription;
    public string[] problemsArr= { "Place the target marker at the correct distance so that the ball launched from the source marker lands precisely on it. Can you calculate and adjust the placement to ensure a successful landing?" ,
                                     " Calculate the mass of the second object after analyzing both collisions.Choose the correct marker (5 kg, 10 kg, or 15 kg) to represent the mass of the second object",
                                    "Calculate the height of the source platform from which a ball rolls down a ramp and lands on the target with the given final velocity. Adjust the height of the source platform using the marker to match your calculation."};
    public string[] problemsDescritionArr;
    public string[] hintArr = { "R = v^2 sin(2x)/g , ( x is angle of launch)",
                                 "m1v1 + m2v2 = m1v1' + m2v2'",
                                  "v = ((2gh)^(½)) / (1+I/(mR^2))\r\nI = (⅖)mR^2\r\n"};


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateProblemSt(int data,int lvl)
    {
        problem.text = problemsArr[data] + " : " + lvl.ToString();
        problemDescription.text = problemsDescritionArr[data];
    }
}
