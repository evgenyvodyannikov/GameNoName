using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //������ � ������������
using UnityEngine.SceneManagement; //������ �� �������
using UnityEngine.Audio; //������ � �����
public class Menu : MonoBehaviour
{

    public bool isOpened = false; //������� �� ����
    public float volume = 0; //���������
    public int quality = 0; //��������
    public bool isFullscreen = false; //������������� �����
    public AudioMixer audioMixer; //��������� ���������
    public Dropdown resolutionDropdown; //������ � ������������ ��� ����
    private Resolution[] resolutions; //������ ��������� ����������
    private int currResolutionIndex = 0; //������� ����������

    public void ShowHideMenu()
    {
        isOpened = !isOpened;
        GetComponent<Canvas>().enabled = isOpened; //��������� ��� ���������� Canvas. ��� ��� ����� ������������ ����� SetActive()
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            ShowHideMenu();
        }
    }

    public void ChangeVolume(float val) //��������� �����
    {
        volume = val;
    }

    public void ChangeResolution(int index) //��������� ����������
    {
        currResolutionIndex = index;
    }

    public void ChangeFullscreenMode(bool val) //��������� ��� ���������� �������������� ������
    {
        isFullscreen = val;
    }

    public void ChangeQuality(int index) //��������� ��������
    {
        quality = index;
    }

    public void GoToSettings()
    {
        Application.Quit();
    }

    public void SaveSettings()
    {
        audioMixer.SetFloat("MasterVolume", volume); //��������� ������ ���������
        QualitySettings.SetQualityLevel(quality); //��������� ��������
        Screen.fullScreen = isFullscreen; //��������� ��� ���������� �������������� ������
        Screen.SetResolution(Screen.resolutions[currResolutionIndex].width, Screen.resolutions[currResolutionIndex].height, isFullscreen); //��������� ����������
    }

}
