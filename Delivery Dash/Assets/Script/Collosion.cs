using UnityEngine;

public class Collosion : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)      //mendeteksi mobil menabrak objek 
    {
        Debug.Log("Tabrakan!"); //menampilkan pesan tabrakan di console
    }

    void OnTriggerEnter2D(Collider2D collider) //mendeteksi mobil menabrak objek 
    {
        Debug.Log("lewat"); //menampilkan pesan tabrakan di console
    }
}
