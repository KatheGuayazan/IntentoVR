using UnityEngine;

public class CambioCancion : MonoBehaviour
{
    public AudioSource reproductor;

    public AudioClip[] canciones;

    public void CambiarCancion(int indice)
    {
        if (indice < 0 || indice >= canciones.Length)
            return;

        reproductor.Stop();

        reproductor.clip = canciones[indice];

        reproductor.Play();
    }
}
