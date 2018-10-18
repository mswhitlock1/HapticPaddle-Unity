
using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Globalization;

public class RotateMe : MonoBehaviour
{
    public string COM = "10";
    public int baudrate = 57600;

    private SerialPort stream;
    void Start()
    {
        stream = new SerialPort("\\\\.\\COM" + COM, 57600); //Set the port and the baud rate
        stream.Open(); //Open the Serial Stream.
    }

    // Update is called once per frame
    void Update()
    {
        float value = float.Parse(stream.ReadLine(), CultureInfo.InvariantCulture.NumberFormat); //Read the information
        if (Mathf.Abs(value) < 200) return; // Deadzone [-200,200]

        // Note my serial output values were generally between -3000 and 3000
        transform.localEulerAngles += new Vector3(0, 0, -value / 500f);
    }
}
