using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonActions : MonoBehaviour
{
    //按鈕動作
    
    public void 首頁按鈕()
    {
        SceneManager.LoadScene("00_Homepage");
    }
    public void 第一頁按鈕()
    {
        SceneManager.LoadScene("01");
    }
    public void 第二頁按鈕()
    {
        SceneManager.LoadScene("02");
    }
    public void 第三頁按鈕()
    {
        SceneManager.LoadScene("03");
    }
    public void 第四頁按鈕()
    {
        SceneManager.LoadScene("04");
    }
}
