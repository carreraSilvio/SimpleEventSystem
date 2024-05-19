# SimpleEventSystem
A simple global event system in unity 

## Usage

## Examples
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

void Awake()
{
    
    SimpleEventManager.AddListener(MyEventNames.PlayerHealed, HandlePlayerDied);
    SimpleEventManager.Invoke(MyEventNames.PlayerHealed);
}

private void HandlePlayerDied()
{
  Debug.Log("player died handler called");
}

```
