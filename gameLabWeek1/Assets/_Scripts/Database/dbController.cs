using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DbController : MonoBehaviour {

    private string _name;
    private int _score;
    private string db_url = "http://16072.hosts.ma-cloud.nl/gamelab/";
    public Text names;
    public Text scores;
    private string[] tempArr;

    void Start() {
        LoadScores();
    }

    public void SaveScores(string name, int score) {
        _name = name;
        _score = score;
        StartCoroutine(_SaveScores());
    }
    public void LoadScores() {
        names.text = "Loading...";
        scores.text = "Loading...";
        StartCoroutine(_LoadScores());
    }
    IEnumerator _SaveScores() {
        WWWForm form = new WWWForm();

        form.AddField("newName", _name);
        form.AddField("newScore", _score);

        WWW webRequest = new WWW(db_url + "SaveScore.php", form);

        yield return webRequest;
        LoadScores();
    }
    IEnumerator _LoadScores() {
        WWW webRequest = new WWW(db_url + "LoadScores.php");

        yield return webRequest;

        string temp = webRequest.text;
        tempArr = temp.Split(',');
        names.text = "";
        scores.text = "";
        for (int i = 0; i < tempArr.Length-1; i+=2) 
        {
            names.text += tempArr[i] + "\n";
            scores.text += tempArr[i+1] + "\n";
            
        }
    }
}
