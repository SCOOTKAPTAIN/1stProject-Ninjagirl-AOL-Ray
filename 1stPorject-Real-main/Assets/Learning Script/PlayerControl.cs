using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    // Deklarasi variabel untuk mengatur kontrol pemain
    public KeyCode moveUp = KeyCode.W;     // Tombol untuk bergerak ke atas
    public KeyCode moveDown = KeyCode.S;   // Tombol untuk bergerak ke bawah
    public float speed = 10.0f;             // Kecepatan gerakan pemain
    public float boundY = 2.25f;            // Batas atas dan bawah dari pergerakan pemain
    private Rigidbody2D rb2d;               // Komponen Rigidbody2D dari pemain

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();   // Mendapatkan komponen Rigidbody2D pada objek ini
    }

    void Update()
    {
        var vel = rb2d.velocity;    // Mendapatkan kecepatan (velocity) dari Rigidbody2D

        // Memeriksa input dari pemain untuk bergerak ke atas atau ke bawah
        if (Input.GetKey(moveUp))
        {
            vel.y = speed;    // Atur kecepatan ke atas sesuai dengan kecepatas yang telah ditentukan
        }
        else if (Input.GetKey(moveDown))
        {
            vel.y = -speed;   // Atur kecepatan ke bawah sesuai dengan kecepatas yang telah ditentukan
        }
        else
        {
            vel.y = 0;        // Jika tidak ada input, kecepatan diatur menjadi 0 (tidak bergerak)
        }
        rb2d.velocity = vel;   // Menetapkan kembali kecepatan pada Rigidbody2D

        var pos = transform.position;   // Mendapatkan posisi dari objek ini

        // Memeriksa jika objek melewati batas atas atau batas bawah yang telah ditentukan
        if (pos.y > boundY)
        {
            pos.y = boundY;    // Jika posisi melewati batas atas, atur posisi kembali ke batas atas
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;   // Jika posisi melewati batas bawah, atur posisi kembali ke batas bawah
        }
        transform.position = pos;   // Menetapkan kembali posisi objek setelah diperiksa batasnya
    }
}
