using System.Collections; // Mengimpor namespace System.Collections yang berisi antarmuka dan kelas-kelas untuk koleksi objek.
using System.Collections.Generic; // Mengimpor namespace System.Collections.Generic yang menyediakan koleksi generik.
using UnityEngine; // Mengimpor namespace UnityEngine yang berisi kelas-kelas untuk berinteraksi dengan mesin game Unity.
using UnityEngine.SceneManagement; // Mengimpor namespace UnityEngine.SceneManagement yang menyediakan kelas-kelas untuk manajemen scene.

public class SceneLoader : MonoBehaviour // Mendeklarasikan kelas publik bernama 'SceneLoader' yang mewarisi dari 'MonoBehaviour'.
{
    // Fungsi untuk mengganti scene dengan menggunakan nama scene sebagai parameter
    public void ChangeScene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName); // Memuat scene yang ditentukan oleh 'sceneName'.
    }

    // Fungsi untuk keluar dari aplikasi
    public void QuitApp()
    {
        Application.Quit(); // Keluar dari aplikasi.
    }
}
