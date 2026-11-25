using UnityEngine;                                      //engine yang digunakan untuk membuat game
using UnityEngine.InputSystem;                          //engine yang digunakan untuk mengatur input dari keyboard

public class Driver : MonoBehaviour                     //nama script file driver yang digunakan untuk mengatur pergerakan mobil
{
    [SerializeField] float steerSpeed = 70f;         //kecepatan mobil saat berbelok
    [SerializeField] float moveSpeed = 30f;          //kecepatan mobil saat bergerak maju atau mundur

    // Update is called once per frame
    void Update()
    {
        float move = 0f;                             //variabel untuk mengatur pergerakan maju atau mundur
        float steer = 0f;                           //variabel untuk mengatur pergerakan belok kiri atau kanan
        
        if (Keyboard.current.wKey.isPressed)        //jika tombol w ditekan maka mobil akan bergerak maju
        {
            move = 0.1f;                            //nilai move untuk bergerak maju
            
        }
        else if (Keyboard.current.sKey.isPressed)    //jika tombol s ditekan maka mobil akan bergerak mundur   
        {
            move = -0.1f;                           //nilai move untuk bergerak mundur
        }
         if (Keyboard.current.aKey.isPressed)       //jika tombol a ditekan maka mobil akan berbelok ke kiri
        {
            steer = 1f;                             //nilai steer untuk berbelok ke kiri 
        }
         else if (Keyboard.current.dKey.isPressed) //jika tombol d ditekan maka mobil akan berbelok ke kanan
        {
            steer = -1f;                            //nilai steer untuk berbelok ke kanan
        }
     
        float steerAmount = steer * steerSpeed * Time.deltaTime; //mengatur keseragaman fps saat berbelok
        float moveAmount = move * moveSpeed * Time.deltaTime;   //mengatur keseragaman fps saat bergerak maju atau mundur

        transform.Rotate(0, 0, steerAmount);                    //mengatur pergerakan belok mobil
        transform.Translate(0, moveAmount, 0);                  //mengatur pergerakan maju atau mundur mobil
    }
}
