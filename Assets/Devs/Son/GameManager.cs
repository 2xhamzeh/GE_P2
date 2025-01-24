using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour, IGameContext
{
    [SerializeField] private Transform spawn1;
    [SerializeField] private Transform spawn2;
    [SerializeField] private Player player1;
    [SerializeField] private Player player2;
    [SerializeField] private float timerDuration = 30f;
    [SerializeField] private float roundDelay = 3f;
    [SerializeField] private float endRoundDelay = 3f; 
    [SerializeField] private InGameUI gameUI;

    public float CurrentTime { get; private set; }
    public int Player1Lives { get; private set; }
    public int Player2Lives { get; private set; }

    private bool isRoundActive;
    private bool isPaused;

    public bool IsPaused
    {
        get => isPaused;
        private set
        {
            isPaused = value;
            Time.timeScale = value ? 0f : 1f;
            if (!value && isRoundActive) 
            {
                SetPlayerControlsEnabled(true);
            }
            else if (value) 
            {
                SetPlayerControlsEnabled(false);
            }
        }
    }

    private void Start()
    {
        InitializeGame();
    }

    private void InitializeGame()
    {
        Player1Lives = 3;
        Player2Lives = 3;
        StartRound();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            IsPaused = !IsPaused;
        }
    }

    private void StartRound()
    {
        StartCoroutine(StartRoundRoutine());
    }

    private IEnumerator StartRoundRoutine()
    {
        SetPlayerControlsEnabled(false);
        player1.Controller.ResetToIdle();
        player2.Controller.ResetToIdle();
        PlacePlayersAtSpawns();
       

        if (gameUI != null)
        {
            gameUI.ShowRoundStartCountdown(roundDelay);
        }

        yield return new WaitForSeconds(roundDelay);

        // Start the round
        isRoundActive = true;
        SetPlayerControlsEnabled(true);
        AssignBomb();
        ResetTimer();
        StartCoroutine(StartTimer());
    }

    private void SetPlayerControlsEnabled(bool isEnabled)
    {
        player1.Controller.enabled = isEnabled;
        player2.Controller.enabled = isEnabled;
    }

    private void PlacePlayersAtSpawns()
    {
        player1.transform.position = spawn1.position;
        player1.transform.rotation = spawn1.rotation;
        player2.transform.position = spawn2.position;
        player2.transform.rotation = spawn2.rotation;
    }

    private void AssignBomb()
    {
        bool player1HasBomb = Random.Range(0, 2) == 0;
        player1.Attributes.HasBomb = player1HasBomb;
        player2.Attributes.HasBomb = !player1HasBomb;
    }

    private void ResetTimer()
    {
        CurrentTime = timerDuration;
    }

    private IEnumerator EndRoundRoutine()
    {
        yield return null;
        isRoundActive = false;
        SetPlayerControlsEnabled(false);

        // Determine winner and loser
        Player winner = player2.Attributes.HasBomb ? player1 : player2;
        Player loser = winner == player1 ? player2 : player1;

        // Trigger respective animations
        winner.Controller.TriggerWinAnimation();
        loser.Controller.TriggerExplosionAnimation();
        SoundManager.instance.PlaySFX(SoundManager.instance.explode);

        yield return new WaitForSeconds(endRoundDelay);

        if(winner == player1 && loser == player2){
            Player2Lives--;
        }
        else{
            Player1Lives--;
        }

        if (Player1Lives == 0 || Player2Lives == 0)
        {
            EndGame();
        }
        else
        {
            StartRound();
        }
    }

    private void EndRound()
    {
        StartCoroutine(EndRoundRoutine());
    }

/*     private void UpdateLives()
    {
        if (player1.Attributes.HasBomb)
        {
            Player1Lives--;
        }
        else
        {
            Player2Lives--;
        }
    }  */

    private void EndGame()
    {
        PlacePlayersAtSpawns();
        string winner = Player1Lives == 0 ? "Player2" : "Player1";
        PlayerPrefs.SetString("Winner", winner);
        MySceneManager.Instance.LoadEndScreen();
    }

    private IEnumerator StartTimer()
    {
        while (CurrentTime > 0 && isRoundActive)
        {
            if (!IsPaused)
            {
                yield return new WaitForSeconds(1f);
                CurrentTime--;

                // Play ticking sound when there are 10 seconds left
                if (CurrentTime <= 10 && CurrentTime > 0)
                {
                    SoundManager.instance.PlaySFX(SoundManager.instance.tick);
                }

                if (CurrentTime <= 0)
                {
                    CurrentTime = 0;  // Ensure timer is exactly 0
                    yield return new WaitForEndOfFrame();  // Wait for UI to update
                    EndRound();
                }
            }
            else
            {
                yield return null;
            }
        }
    }

    // IGameContext implementation
    public float GetBombTimer() => CurrentTime;
    public void SetBombTimer(float time) => CurrentTime = time;
    public Player[] GetPlayers() => new Player[] { player1, player2 };
    public bool IsGameActive() => isRoundActive;
}