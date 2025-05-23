using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d; // Rigidbody2D untuk mengontrol fisika bola

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // Mengambil komponen Rigidbody2D dari objek ini
        Invoke("GoBall", 2); // Memanggil fungsi GoBall setelah 2 detik
    } 

    void GoBall()
    {
        float rand = Random.Range(0, 2); // Menghasilkan nilai acak antara 0 dan 1
        if (rand < 1)
        { 
            rb2d.AddForce(new Vector2(20, -15)); // Memberikan gaya pada bola ke kanan bawah
        }
        else
        {
            rb2d.AddForce(new Vector2(-20, -15)); // Memberikan gaya pada bola ke kiri bawah
        }
    }

    void ResetBall() // Mengatur posisi dan kecepatan bola menjadi 0
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void RestartGame()
    {
        ResetBall(); // Memanggil fungsi ResetBall
        Invoke("GoBall", 1); // Memanggil fungsi GoBall setelah 1 detik
    }

    [SerializeField] private int wallCollisionCount; // Jumlah tabrakan dengan dinding

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "King") // Jika bola bertabrakan dengan objek "King"
        {
            rb2d.AddForce(new Vector2(20, -15)); // Dorong bola ke kanan bawah
            wallCollisionCount = 0; // Reset jumlah tabrakan dengan dinding
        }
        else if (coll.gameObject.name == "Pig") // Jika bola bertabrakan dengan objek "Pig"
        {
            rb2d.AddForce(new Vector2(-20, -15)); // Dorong bola ke kiri bawah
            wallCollisionCount = 0; // Reset jumlah tabrakan dengan dinding
        }
        else // Jika bola bertabrakan dengan dinding
        {
            wallCollisionCount++; // Tambahkan jumlah tabrakan dengan dinding
            Debug.Log("Wall Collision! = " + wallCollisionCount); // Cetak pesan bahwa terjadi tabrakan dengan dinding
            if (wallCollisionCount > 6) GoBall(); // Jika jumlah tabrakan lebih dari 6, panggil fungsi GoBall
        }
    }
}
