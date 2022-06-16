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
    private GameObject playerSkills;

    private TMP_Text enemyNameText;
    private TMP_Text enemyHPText;
    private TMP_Text playerNameText;
    private TMP_Text playerHPText;

    private static TMP_Text skill1;
    private static TMP_Text skill2;
    private static TMP_Text skill3;
    private static TMP_Text skill4;

    List<TMP_Text>skillList = new List<TMP_Text>{skill1, skill2, skill3, skill4};

    // Start is called before the first frame update
    void Start()
    {
        InitPlayer(playerMokeNumber);
        InitEnemy(enemyMokeNumber);
        InitPlayerMokemonSkills();
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

    void InitPlayerMokemonSkills()
    {
        playerSkills = GameObject.Find("SkillsL");
        for (int sk_index=0; sk_index<4; sk_index++)
        {
            TMP_Text skill = skillList[sk_index];
            string skillName = Mokemon.skillNameList[sk_index];
            skill = playerSkills.transform.Find("Skill"+(sk_index+1)).gameObject.GetComponentInChildren<TMP_Text>();
            skill.text = skillName;
        }
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
