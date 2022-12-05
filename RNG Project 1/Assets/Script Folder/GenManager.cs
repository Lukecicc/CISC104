using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenManager : MonoBehaviour
{
    private GenCode genCode;

    public GameObject numberObject;
    private TextMeshProUGUI numberText;


    public GameObject clicksObject;
    private TextMeshProUGUI clicksText;

    // Start is called before the first frame update
    void Start()
    {
        genCode = new GenCode();
        numberText = numberObject.GetComponent<TextMeshProUGUI>();
        clicksText = clicksObject.GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        numberText.text = "Your Number: " + genCode.number;
        clicksText.text = "Times Clicked: " + genCode.clicks;


    }
    public void Button()
    {
        genCode.Generator();
    }

    public void Reset()
    {
        genCode.Reset();
    }
    
}
