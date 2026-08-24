using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance; // Vi laver en reference, sådan at alle andre scripts kan tilgå AudioManager.Instance.
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        if(Instance != null && Instance != this) //Hvis der er mere end to AudioManagers i scenen, ødelægger vi den, der ikke er opsat som global reference
        {
            Destroy(gameObject);
            return;
        }
        Instance = this; //Vi sætter dette script til at være vores eneste Instance
        DontDestroyOnLoad(gameObject); //Vi sørger for, at gameObjectet som scriptet sidder på, ikke bliver ødelagt når der loades en ny scene
    }
    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
