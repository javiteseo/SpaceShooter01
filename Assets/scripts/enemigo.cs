using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private GameObject disparoPrefab;
    [SerializeField] private GameObject spawnDisparo;
    //[SerializeField] private TextMeshProUGUI textoScore;

    private int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpanearDisparos());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * velocidad * Time.deltaTime);

    }
    IEnumerator SpanearDisparos()
    {
        while (true)
        {
            Instantiate(disparoPrefab, spawnDisparo.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
    private void OnTriggerEnter2D(Collider2D elOtro)
    {
        if (elOtro.gameObject.CompareTag("disparoplayer"))
        {
            score++;
            //textoScore.text = "Score: " + score;
            Destroy(elOtro.gameObject);
            Destroy(this.gameObject);
        }
    }

}
