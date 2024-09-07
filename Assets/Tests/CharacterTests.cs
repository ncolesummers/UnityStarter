using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CharacterTests : InputTestFixture
{
    private GameObject character = Resources.Load<GameObject>("Character");
    private Keyboard keyboard;
    
    public override void Setup()
    {
        SceneManager.LoadScene("Scenes/SimpleTesting");
        base.Setup();
        keyboard = InputSystem.AddDevice<Keyboard>();
        
        var mouse = InputSystem.AddDevice<Mouse>();
        Press(mouse.rightButton);
        Release(mouse.rightButton);
    }

    [Test]
    public void TestPlayerInstantiation()
    {
        GameObject characterInstance = Object.Instantiate(character, Vector3.zero, Quaternion.identity);
        Assert.That(characterInstance, Is.Not.Null);
    }
}
