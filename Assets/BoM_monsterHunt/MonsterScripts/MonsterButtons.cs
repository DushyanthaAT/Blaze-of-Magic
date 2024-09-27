using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterButtons : MonoBehaviour
{
   public void ReplayMonster()
    {
        monsterplayer.points = 0;
        SceneManager.LoadScene("MonsterTask");
    }
    public void ExitMonster()
    {
       
        SceneManager.LoadScene("BoM_Map");
    }
}
