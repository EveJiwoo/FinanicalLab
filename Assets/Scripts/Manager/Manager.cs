using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    static public Manager Instance;

    //[Header("Ǯ �Ŵ���")]
    //public PoolManager kPoolManager;
    [Header("���̺� �Ŵ���")]
    public TableManager kTableManager;
    [Header("������ �Ŵ���")]
    public DataManager kDataManager;    
    [Header("�÷��� �Ŵ���")]
    public PlayManager kPlayManager;
    [Header("���� �Ŵ���")]
    public SoundManager kSoundManager;
    
    
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    IEnumerator Start()
    {
        ///////////////////////////////////////////////////////////////////////////////////////
        //�Ŵ��� �ʱ�ȭ

        GameObject go = Instantiate(kDataManager.gameObject);
        go.transform.parent = transform;
        go.name = "DataManager";
/*
        while (DataManager.Instance == null)
            yield return null;
*/
        go = Instantiate(kTableManager.gameObject);
        go.transform.parent = transform;
        go.name = "TableManager";

        while (TableManager.Instance == null)
            yield return null;

        go = Instantiate(kSoundManager.gameObject);
        go.transform.parent = transform;
        go.name = "SoundManager";

        while (SoundManager.Instance == null)
            yield return null;
/*
        go = Instantiate(kPoolManager.gameObject);
        go.transform.parent = transform;
        go.name = "PoolManager";

        while (PoolManager.Instance == null)
            yield return null;
*/
        go = Instantiate(kPlayManager.gameObject);
        go.transform.parent = transform;
        go.name = "PlayManager";

        while (PlayManager.Instance == null)
            yield return null;

        ///////////////////////////////////////////////////////////////////////////////////////
        //���� ����

        Mng.sound.PlayBgm("Sound/BGM");
    }
}
