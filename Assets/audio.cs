using UnityEngine;
using UnityEngine.UI;

public class ControlAudio : MonoBehaviour
{
    public Slider sliderVolumen;
    public AudioSource audioSource;

    void Start()
    {
        // Inicializa el slider con el volumen actual
        sliderVolumen.value = audioSource.volume;
        sliderVolumen.onValueChanged.AddListener(CambiarVolumen);
    }

    void CambiarVolumen(float valor)
    {
        audioSource.volume = valor;
    }
}


public class SoundPlayer : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        // Reproduce el sonido
        audioSource.Play();
    }

    // O podés hacer un método para reproducir cuando quieras:
    public void PlaySound()
    {
        audioSource.Play();
    }
}
