using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //CTRL + R+R  YAPARSANIZ B�R DE���KEN�N ADINI DE���T�RECE��N�Z ZAMAN B�R�N� DE���T�RSEN�Z AYNI  ADLARIN HEPS� DE����R ...
    [SerializeField] private int power;
    [SerializeField] private float mousepower;


    private float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   //Fareyi ekran�n ortas�na sabitleme
    }

    
    void Update()
    {

        Walk();
        MousePosition();
    }
    
 
    void Walk()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 go = new Vector3(horizontal, 0, vertical);

        transform.Translate(power * Time.deltaTime * go);
        
    }

  private void MousePosition()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousepower * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousepower * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -45f, 45f);

        // Karakterin yatay (y ekseni etraf�nda) d�n���n� yap
        transform.Rotate(Vector3.up * mouseX);

        // Kameran�n dikey (x ekseni etraf�nda) d�n���n� yap
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }

}

