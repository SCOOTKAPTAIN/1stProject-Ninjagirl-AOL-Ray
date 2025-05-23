using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Skor pemain kiri dan kanan
    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    // UI Text untuk menampilkan skor
    public TMP_Text txtPlayerScoreL;  // UI Text untuk skor pemain kiri
    public TMP_Text txtPlayerScoreR;  // UI Text untuk skor pemain kanan
    
    // Instance singleton GameManager
    public static GameManager instance;

    // Method yang dipanggil saat objek ini dibuat
    public void Awake()
    {
        // Membuat singleton instance GameManager
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);  // Hancurkan objek jika instance sudah ada
        }
    }

    // Method yang dipanggil saat objek ini dimulai
    void Start()
    {
        // Menginisialisasi UI Text dengan skor awal
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }

    // Method untuk menambah skor pemain berdasarkan wallID
    public void Score(string wallID)
    {
        if (wallID == "Line L")
        {
            PlayerScoreR += 10;  // Menambah skor pemain kanan
            txtPlayerScoreR.text = PlayerScoreR.ToString();  // Memperbarui UI Text skor pemain kanan
            ScoreCheck();  // Memeriksa kondisi kemenangan
        }
        else
        {
            PlayerScoreL += 10;  // Menambah skor pemain kiri
            txtPlayerScoreL.text = PlayerScoreL.ToString();  // Memperbarui UI Text skor pemain kiri
            ScoreCheck();  // Memeriksa kondisi kemenangan
        }
    }

    // Method untuk memeriksa kondisi kemenangan
    public void ScoreCheck()
    {
        if (PlayerScoreL == 20)
        {
            Debug.Log("Player L wins");  // Debug log jika pemain kiri menang
            this.gameObject.SendMessage("ChangeScene", "MainMenu");  // Mengirim pesan untuk mengganti scene ke MainMenu
        }
        else if (PlayerScoreR == 20)
        {
            Debug.Log("Player R wins");  // Debug log jika pemain kanan menang
            this.gameObject.SendMessage("ChangeScene", "MainMenu");  // Mengirim pesan untuk mengganti scene ke MainMenu
        }
    }
}
    