using Naninovel;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private GameObject Naninovel;

    void Start()
    {
        Naninovel = GameObject.Find("Naninovel<Runtime>");
        Naninovel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Naninovel.SetActive(true);
        loadLvl();
        var varManager = Engine.GetService<ICustomVariableManager>();
        var HaveACat = varManager.GetVariableValue("HaveACat");
        HaveACat = "true";
        varManager.SetVariableValue("HaveACat", HaveACat);

        SceneManager.LoadScene("New Scene");
    }

    private async void loadLvl()
    {
        var player = Engine.GetService<IScriptPlayer>();
        await player.PreloadAndPlayAsync("lvl_1");
    }
}
