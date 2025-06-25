using UnityEngine;
using UnityEngine.SceneManagement;

public class 按鈕的動作 : MonoBehaviour
{
    public void 首頁()
    {
        SceneManager.LoadScene("00_Homepage");
    }
    public void 如何採茶()
    {
        SceneManager.LoadScene("01_如何採茶");
    }
    public void 第三頁()
    {
        SceneManager.LoadScene("02");
    }
    public void 第四頁()
    {
        SceneManager.LoadScene("03");
    }
    public void 第五頁()
    {
        SceneManager.LoadScene("04");
    }
}
