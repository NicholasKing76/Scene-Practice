using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputScript : MonoBehaviour
{
    public InputField PlaceName;
    public Text InputName;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {

    }

    public void DisplayName()
    {
        InputName.text = PlaceName.text;
    }
}
