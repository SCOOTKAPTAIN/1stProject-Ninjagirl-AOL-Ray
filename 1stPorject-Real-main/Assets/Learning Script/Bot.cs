using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public Transform ball;  // Variabel untuk menyimpan transformasi bola
    public Transform enemy; // Variabel untuk menyimpan transformasi musuh
    public float speed = 1f; // Kecepatan gerakan bot

    private Vector2 destination; // Titik tujuan gerakan bot

    // Metode untuk menggerakkan bot menuju bola
    public void MoveToBall()
    {
        // Menetapkan titik tujuan ke posisi musuh (pada sumbu X) dan posisi bola (pada sumbu Y)
        destination = new Vector2(enemy.transform.position.x, ball.position.y);

        // Menggerakkan posisi bot menggunakan Lerp untuk pergerakan halus
        transform.position = Vector2.Lerp(enemy.transform.position, destination, speed * Time.deltaTime);
    }

    // Metode yang dipanggil setiap frame
    void Update()
    {
        // Memanggil fungsi MoveToBall untuk menjalankan gerakan bot
        MoveToBall();
    }
}
