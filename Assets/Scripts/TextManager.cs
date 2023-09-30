using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    public static TextManager textManagerIntance;

    public TextMeshProUGUI actualScore;
    public TextMeshProUGUI recordScore;

    public int record;
    public int bestRecord;

    private void Awake()
    {
        if(textManagerIntance == null)
        {
            textManagerIntance = this;
        }
    }
    void Start()
    {
        record = 0;
        bestRecord = 0;
        actualScore = transform.Find("Canvas/ActualValue/ActScoreValue").GetComponent<TextMeshProUGUI>();
        recordScore = transform.Find("Canvas/RecordScore/RecordScoreValue").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sumarRecord()
    {
        record++;
        updateRecord();
    }

    public void updateRecord()
    {
        actualScore.text = record.ToString();
        updateBestRecord();
    }
    public void updateBestRecord()
    {
        if(bestRecord < record)
        {
            recordScore.text = record.ToString();
            bestRecord = record;
        }
    }
    public void resetScore()
    {
        record = 0;
        actualScore.text = 0.ToString();
    }
}
