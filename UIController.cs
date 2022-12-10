using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Player pl;
    public DynamicJoystick dj;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: 0";
    }

    private void FixedUpdate()
    {
        pl.ChangeSpeed(dj.Horizontal);
        scoreText.text = $"Score: {pl.score}";
    }
}
