using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonedaManager : MonoBehaviour
{
    [SerializeField]
    private Text Monedatext;
    private int Contador;
    void MonedaText()
    {
        Contador++;
        Monedatext.text = "Monedas:" + Contador;
    }
    private void OnEnable()
    {
        Moneda.monedaEvent += MonedaText;
    }
    private void OnDisable()
    {
        Moneda.monedaEvent -= MonedaText;
    }
}
