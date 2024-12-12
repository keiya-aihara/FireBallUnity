using UnityEngine;
using UnityEngine.Advertisements;

public class AdsInitializer : MonoBehaviour
{
    [SerializeField] private string androidGameId = "5733997";
    [SerializeField] private string iosGameId = "5733996";
    [SerializeField] private bool testMode = true;
    private string gameId;

    public PlayerStatusDataBase playerStatusDataBase;
    void Start()
    {
        // プラットフォームごとに適切なゲームIDを設定
        gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
            ? iosGameId
            : androidGameId;

        // Unity Adsの初期化
        Advertisement.Initialize(gameId, testMode);
    }

    public void ShowAd()
    {
        if (Advertisement.IsReady("Rewarded_Android")) // 適切な広告ユニットIDを指定
        {
            Advertisement.Show("Rewarded_Android", new ShowOptions
            {
                resultCallback = HandleAdResult
            });
        }
        else
        {
            Debug.Log("広告が準備できていません。");
        }
    }

    private void HandleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("広告が正常に再生されました。報酬を与えます。");
                GrantReward();
                break;
            case ShowResult.Skipped:
                Debug.Log("広告がスキップされました。報酬は与えません。");
                break;
            case ShowResult.Failed:
                Debug.LogWarning("広告の再生に失敗しました。");
                break;
        }
    }
    private void GrantReward()
    {
        // ユーザーに報酬を付与する処理
        Debug.Log("ユーザーに報酬を付与しました。");
        playerStatusDataBase.nomalDropRitu += 50;
        playerStatusDataBase.reaDropRitu += 50;
        playerStatusDataBase.superReaDropRitu += 50;
        playerStatusDataBase.epikReaDropRitu += 50;
        playerStatusDataBase.legendaryReaDropRitu += 50;
        playerStatusDataBase.godReaDropRitu += 50;
    }





    public void ShowAdZidouSyuukai()
    {
        if (Advertisement.IsReady("Rewarded_Android")) // 適切な広告ユニットIDを指定
        {
            Advertisement.Show("Rewarded_Android", new ShowOptions
            {
                resultCallback = HandleAdResultZidouSyuukai
            });
        }
        else
        {
            Debug.Log("広告が準備できていません。");
        }
    }
    private void HandleAdResultZidouSyuukai(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("広告が正常に再生されました。報酬を与えます。");
                GrantRewardZidouSyuukai();
                break;
            case ShowResult.Skipped:
                Debug.Log("広告がスキップされました。報酬は与えません。");
                break;
            case ShowResult.Failed:
                Debug.LogWarning("広告の再生に失敗しました。");
                break;
        }
    }
    private void GrantRewardZidouSyuukai()
    {
        // ユーザーに報酬を付与する処理
        Debug.Log("ユーザーに報酬を付与しました。");
        GameObject.Find("冒険するButton (Legacy)").GetComponent<StageChange>().Zidousyuukai();
    }
}

