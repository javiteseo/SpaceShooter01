using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemigospawner;
    [SerializeField] private TextMeshProUGUI textoOleadas;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnearEnemigos());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator SpawnearEnemigos()
    {
        for (int i = 0; i < 5; i++) //niveles
        {
            for (int j = 0; j < 3; j++) //oleadas
            {
            textoOleadas.text = "nivel " + (i+1) + " oleada " + (j+1);
                yield return new WaitForSeconds(3f);
                textoOleadas.text = "";
                for (int k = 0; k < 10; k++) //enemigos
                {
                    Vector3 puntoAleatorio= new Vector3(transform.position.x, Random.Range(-4.5f, 4.5f), transform.position.z);
                    Instantiate(enemigospawner, puntoAleatorio, Quaternion.identity);
                    yield return new WaitForSeconds(0.5f);
                }
                yield return new WaitForSeconds(2f);
            }
            yield return new WaitForSeconds(3f);

        }
    }
}
