using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class studentHall : MonoBehaviour
{
    public void ButtonClicked()
    {
        SceneManager.LoadScene("sHall");
    }
}
