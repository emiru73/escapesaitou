using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    private bool touchingDoor = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            touchingDoor = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            touchingDoor = false;
        }
    }

    private void Update()
    {
        if (touchingDoor && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(OpenDoorAndSwitchScene());
        }
    }

    private IEnumerator OpenDoorAndSwitchScene()
    {
        // SEの再生
        GetComponent<AudioSource>().Play();
        Debug.Log("ドアが開きます...");

        // ここでドアが開くアニメーションを再生する
        yield return new WaitForSeconds(2f); // 例: アニメーションの再生時間が2秒と仮定

        Debug.Log("ドアが開きました。新しいシーンに切り替えます。");

        // 新しいシーンに切り替える
        SceneManager.LoadScene("HouseScene");
    }
}
