using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CubeManager : MonoBehaviour
{
    private Cube myCube;

    public Slider heightSlider;
    public Slider widthSlider;
    public Slider lengthSlider;

    public GameObject heightTextObject;
    public GameObject widthTextObject;
    public GameObject sidelengthTextObject;
    public GameObject volumeTextObject;
    public GameObject lengthTextObject;

    private TextMeshProUGUI heightText { get; set; }
    private TextMeshProUGUI widthText { get; set; }
    private TextMeshProUGUI sidelengthText { get; set; }
    private TextMeshProUGUI volumeText { get; set; }
    private TextMeshProUGUI lengthText { get; set; }



// Start is called before the first frame update
void Start()
    {
        heightText = heightTextObject.GetComponent<TextMeshProUGUI>();
        widthText = widthTextObject.GetComponent<TextMeshProUGUI>();
        sidelengthText = sidelengthTextObject.GetComponent<TextMeshProUGUI>();
        volumeText = volumeTextObject.GetComponent<TextMeshProUGUI>();
        lengthText = lengthTextObject.GetComponent<TextMeshProUGUI>();

        // Calls basic constructor, but sets height and width to 0
        myCube = new Cube();

        GetValuesFromSliders();
    }

    // Update is called once per frame
   
void Update()
    {
        heightText.text = "Cube Height: " + myCube.GetHeight().ToString();
        widthText.text = "Cube Width: " + myCube.GetWidth().ToString();
        sidelengthText.text = "Cube SideLength: " + myCube.GetSideLength().ToString();
        volumeText.text = "Cube Volume: " + myCube.GetVolume().ToString();
        lengthText.text = "Cube Length: " + myCube.GetLength().ToString();
    }

    public void SliderChanged(float newValue)
    {
        GetValuesFromSliders();
    }

    private void GetValuesFromSliders()
    {
        myCube.SetHeight(heightSlider.value);
        myCube.SetWidth(widthSlider.value);
        myCube.SetLength(lengthSlider.value);
    }

}
