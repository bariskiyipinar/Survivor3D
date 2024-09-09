using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //CTRL + R+R  YAPARSANIZ BÝR DEÐÝÞKENÝN ADINI DEÐÝÞTÝRECEÐÝNÝZ ZAMAN BÝRÝNÝ DEÐÝÞTÝRSENÝZ AYNI  ADLARIN HEPSÝ DEÐÝÞÝR ...
    [SerializeField] private int power;
    [SerializeField] private float mousepower;


    private float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   //Fareyi ekranýn ortasýna sabitleme
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

        // Karakterin yatay (y ekseni etrafýnda) dönüþünü yap
        transform.Rotate(Vector3.up * mouseX);

        // Kameranýn dikey (x ekseni etrafýnda) dönüþünü yap
        Camera.main.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }

}

