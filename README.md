# SimpleEventSystem
A simple global event system 

## Usage
```csharp

void Awake()
{
    SimpleEventManager.AddListener("Test", Handler);
    SimpleEventManager.AddListener("Test", Handler2);
    SimpleEventManager.Invoke("Test");
}

void Handler()
{
    Debug.Log("handler called");
}

void Handler2()
{
    Debug.Log("handler2 called");
}

```

```csharp
public enum MyEventNames
{
    PlayerTookDamage,
    PlayerHealed,
    PlayerDied
}

void Awake()
{
    SimpleEventManager.AddListener(MyEventNames.PlayerDied, HandlePlayerDied);
    SimpleEventManager.Invoke(MyEventNames.PlayerDied);
}

private void HandlePlayerDied()
{
    Debug.Log("player died handler called");
}

```

## Install

### Unity 2019.3
1. Open the package manager and point to the rep url

![Imgur](https://i.imgur.com/iYGgINz.png)
