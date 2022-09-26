using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField] private RawImage _image;
    private Material _fade;
    private bool _lock;

    private void Awake()
    {
        _fade = _image.material;
    }
    private System.Collections.IEnumerator Start()
    {
        float time = 0;
        while (time < 2)
        {
            yield return null;
            time += Time.deltaTime;
            _fade.SetFloat("_size", time);
        }
    }
    private System.Collections.IEnumerator FadeIn(string name)
    {
        float time = 2;
        while (time > 0)
        {
            yield return null;
            time -= Time.deltaTime;
            _fade.SetFloat("_size", time);
        }

        SceneManager.LoadScene(name);
    }
    public void ChangeScene(string name)
    {
        if (_lock) return;
        StartCoroutine(FadeIn(name));
        _lock = true;
    }
}