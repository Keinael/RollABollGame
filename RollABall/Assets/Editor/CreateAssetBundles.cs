using UnityEditor;


public class CreateAssetBundles
{
    [MenuItem("Assets/AssetBundles/Build")]
    static void BuildAllAssetBundles()
    {
        string path = EditorUtility.SaveFolderPanel("Save Bundle", "", "");
        if (path.Length != 0)
        {
            BuildPipeline.BuildAssetBundles("AssetBundles", BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows);
        }
        
    }
}