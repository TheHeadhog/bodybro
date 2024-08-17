using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DebugBodyStats : MonoBehaviour
{
    [SerializeField]
    private BodyPart head;
    [SerializeField]
    private BodyPart core;
    [SerializeField]
    private BodyPart leftBicep;
    [SerializeField]
    private BodyPart rightBicep;
    [SerializeField]
    private BodyPart leftForearm;
    [SerializeField]
    private BodyPart rightForearm;
    [SerializeField]
    private BodyPart leftQuad;
    [SerializeField]
    private BodyPart rightQuad;
    [SerializeField]
    private BodyPart leftCalf;
    [SerializeField]
    private BodyPart rightCalf;

    [SerializeField]
    private TMP_Text headT;

    [SerializeField]
    private TMP_Text coreT;

    [SerializeField]
    private TMP_Text leftBicepT;

    [SerializeField]
    private TMP_Text rightBicepT;

    [SerializeField]
    private TMP_Text leftForearmT;

    [SerializeField]
    private TMP_Text rightForearmT;

    [SerializeField]
    private TMP_Text leftQuadT;

    [SerializeField]
    private TMP_Text rightQuadT;

    [SerializeField]
    private TMP_Text leftCalfT;

    [SerializeField]
    private TMP_Text rightCalfT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        headT.text = head.growthStat.ToString("F1");
        coreT.text = core.growthStat.ToString("F1");
        leftBicepT.text = leftBicep.growthStat.ToString("F1");
        leftForearmT.text = leftForearm.growthStat.ToString("F1");
        leftQuadT.text = leftQuad.growthStat.ToString("F1");
        leftCalfT.text = leftCalf.growthStat.ToString("F1");
        rightBicepT.text = rightBicep.growthStat.ToString("F1");
        rightForearmT.text = rightForearm.growthStat.ToString("F1");
        rightQuadT.text = rightQuad.growthStat.ToString("F1");
        rightCalfT.text = rightCalf.growthStat.ToString("F1");
    }
}
