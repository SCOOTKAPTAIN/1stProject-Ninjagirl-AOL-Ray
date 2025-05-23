using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationhandler : MonoBehaviour
{
    private Animator m_animator; // Animator untuk mengontrol animasi karakter

    void Start()
    {
        m_animator = GetComponent<Animator>(); // Mendapatkan komponen Animator dari game object ini
    }

    // Method ini dipanggil dari luar untuk memulai animasi serangan karakter
    public void PlayerAttack()
    {
        m_animator.SetTrigger("goAttack"); // Mengatur trigger "goAttack" untuk memulai animasi serangan
    }

    void Update()
    {
        // Memeriksa jika tombol spasi ditekan
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_animator.SetTrigger("goAttack"); // Mengatur trigger "goAttack" saat tombol spasi ditekan untuk memulai animasi serangan
        }
    }
}
