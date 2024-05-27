using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogInManager : MonoBehaviour
{
    string rightPassword = "sprinfil";
    public InputField inputField;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkLogIn(string password, string input)
    {
        if (input == password)
        {
            Debug.Log("Acceso concedido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }

    public void buttonClick()
    {
        checkLogIn(rightPassword, inputField.text);
    }
}
