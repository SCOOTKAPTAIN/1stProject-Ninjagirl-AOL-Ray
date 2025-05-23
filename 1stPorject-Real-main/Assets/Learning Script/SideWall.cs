using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWall : MonoBehaviour
{
    // Dipanggil saat objek lain masuk ke dalam collider dari objek ini
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        // Memeriksa apakah objek yang masuk memiliki nama "Ball"
        if (hitInfo.name == "Ball")
        {
            // Mendapatkan nama dari dinding samping (side wall)
            string wallName = transform.name;
            
            // Memanggil method Score() dari instance GameManager.cs dengan parameter wallName
            GameManager.instance.Score(wallName);
            
            // Memanggil method RestartGame() dari komponen BallControl.cs pada objek yang masuk collider
            hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
