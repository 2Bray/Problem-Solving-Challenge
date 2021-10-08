public class SceneControllerScript
{
    public static void openScene(int idx)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(idx);
    }

    public static void Exit() => UnityEngine.Application.Quit();
}