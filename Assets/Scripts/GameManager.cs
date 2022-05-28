using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private Mokemon enemyMokemon;
    private Mokemon playerMokemon;

    public int enemyMokeNumber;
    public int playerMokeNumber;
    private GameObject enemy;
    private GameObject player;
    private TMP_Text enemyNameText;
    private TMP_Text enemyHPText;
    private TMP_Text playerNameText;
    private TMP_Text playerHPText;
    // Start is called before the first frame update
    void Start()
    {
        InitPlayer(playerMokeNumber);
        InitEnemy(enemyMokeNumber);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void InitEnemy(int mokeNumber)
    {
        enemyMokemon = new Mokemon();
        enemyMokemon.Init(mokeNumber);
        enemy = GameObject.Find("Enemy");
        enemyNameText = enemy.transform.Find("Name").gameObject.GetComponentInChildren<TMP_Text>();
        enemyNameText.text = enemyMokemon.mokeName;
        enemyNameText = enemy.transform.Find("HP").gameObject.GetComponentInChildren<TMP_Text>();
        enemyNameText.text = enemyMokemon.hp.ToString() + "/" + enemyMokemon.baseHP.ToString();
    }
    void InitPlayer(int mokeNumber)
    {
        playerMokemon = new Mokemon();
        playerMokemon.Init(mokeNumber);
        player = GameObject.Find("Player");
        playerNameText = player.transform.Find("Name").gameObject.GetComponentInChildren<TMP_Text>();
        playerNameText.text = playerMokemon.mokeName;
        playerNameText = player.transform.Find("HP").gameObject.GetComponentInChildren<TMP_Text>();
        playerNameText.text = playerMokemon.hp.ToString() + "/" + playerMokemon.baseHP.ToString();
    }
    // void InitMokemon(GameObject player, int number)
    // {
    //     enemyMokemon = new Mokemon();
    //     enemyMokemon.Init(mokeNumber);
    //     enemy = GameObject.Find("Enemy");
    //     enemyNameText = enemy.transform.Find("Name").gameObject.GetComponentInChildren<TMP_Text>();
    //     enemyNameText.text = enemyMokemon.mokeName;
    //     enemyNameText = enemy.transform.Find("HP").gameObject.GetComponentInChildren<TMP_Text>();
    //     enemyNameText.text = enemyMokemon.hp.ToString() + "/" + enemyMokemon.baseHP.ToString();
    // }
}
