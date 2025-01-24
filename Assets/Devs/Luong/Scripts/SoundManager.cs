using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [Header("---------- Audio Source ------------")]
   [SerializeField] AudioSource MusicSource;
   [SerializeField] AudioSource SFXSource;

    [Header("---------- Audio Clip ------------")]
    public AudioClip BigMap_background;
    public AudioClip MediumMap_background;
    public AudioClip SmallMap_background;
    public AudioClip Main_menu_background;
    public AudioClip Select_map_background;
    public AudioClip End_game_background;

    

    public AudioClip tick;
    public AudioClip explode;
    public AudioClip pickUp;
    public AudioClip bumpInto;
    public AudioClip swap;
    public AudioClip rocket;
    public AudioClip reverse;
    public AudioClip trap;
    public AudioClip trap_spawn;


    void Awake()
    {
        // If there's no existing instance, set this one and make it persist across scenes
        if (instance == null) 
        {
            instance = this; 
            DontDestroyOnLoad(gameObject); // Keep the SoundManager across scene transitions
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances 
        }
    }

    void Start() {
        MusicSource.clip = Main_menu_background;
        MusicSource.loop = true;
        MusicSource.Play();
    }

   public void PlayMusic(AudioClip clip){
        if (MusicSource.isPlaying) 
        {
            MusicSource.Stop(); // Stop the current music if it's playing
        }
        MusicSource.clip = clip;
        MusicSource.Play();
    }

    public void PlaySFX(AudioClip clip){
        SFXSource.PlayOneShot(clip);
    }
    

    public void PlayBackgroundMusic(int sceneIndex)
    {
        switch (sceneIndex)
        {
            case 0:
                PlayMusic(Main_menu_background); // Main Menu
                break;
            case 1:
                PlayMusic(SmallMap_background); // Small Map
                break;
            case 2:
                PlayMusic(MediumMap_background); // Medium Map
                break;
            case 3:
                PlayMusic(BigMap_background); // Big Map
                break;
            case 4:
                PlayMusic(Select_map_background); // Map Select
                break;
            case 5:
                PlayMusic(End_game_background); // End Game
                break;
            default:
                break; // No music for other scenes
        }
    }


}
