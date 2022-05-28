using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private Mokemon enemyMokemon;

    public int mokeNumber;
    private GameObject enemy;
    private TMP_Text enemyNameText;
    private TMP_Text enemyHPText;

    // Start is called before the first frame update
    void Start()
    {
        enemyMokemon = new Mokemon();
        enemyMokemon.Init(mokeNumber);
        enemy = GameObject.Find("Enemy");
        enemyNameText = enemy.transform.Find("Name").gameObject.GetComponentInChildren<TMP_Text>();
        enemyNameText.text = enemyMokemon.mokeName;
        enemyNameText = enemy.transform.Find("HP").gameObject.GetComponentInChildren<TMP_Text>();
        enemyNameText.text = enemyMokemon.hp.ToString() + "/" + enemyMokemon.baseHP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
