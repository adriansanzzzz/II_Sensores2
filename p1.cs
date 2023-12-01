using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class p1 : MonoBehaviour
{

    public TMP_Text info;

    void Start(){
        Input.location.Start();
        Input.gyro.enabled = true;
        Input.compass.enabled=true;
    }
    void Update()
    {
        info.text = $" Velocidad: {Input.gyro.rotationRate}\n Aceleración: {Input.acceleration}\nLatitud: {Input.location.lastData.latitude}\n" +
        $"Longitud: {Input.location.lastData.longitude}\nAltitud: { Input.location.lastData.altitude}\ntrueh: { Input.compass.trueHeading}\n";

        transform.rotation = Quaternion.Slerp(transform.rotation, 
        Quaternion.Euler(0, -Input.compass.trueHeading, 0), 0.5f);
    }
}
