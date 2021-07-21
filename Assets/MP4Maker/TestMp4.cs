using Mp4Maker;
using UnityEngine;

public class TestMp4 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        string path = Application.dataPath + "/MP4Maker/testVideo.mp4";
        Mp4File mp4File = new Mp4File();
        mp4File.Open(path);
        Debug.Log(mp4File.Moov.MovieHeader.TimeLength);
    }

    // Update is called once per frame
    private void Update()
    {
    }
}