# SOArchitecture

SOArchitecture is a framework for creating project-wide ScriptableObject based variables and events.

Based on the [Unite talk by Ryan Hipple here](https://www.youtube.com/watch?v=raQ3iHhE_Kk)

## System Requirements

Unity 2020.1.x or later. SOArchitecture makes use of Unity's new serialization of generics and will not work on previous versions.

## Installation

Use the package manager to install with the URL:

```
https://github.com/qhenshaw/SOArchitecture.git?path=/Packages/SOArchitecture
```

## Usage

Use the Create menu to add GameVariable and GameEvent ScriptableObjects to your project. They can be connected using UnityEvents and the GameEventReceiver.

Additional types can be added by extending the SOArchitecture namespace classes:
```csharp
GameVariable<T>
GameEvent<T>
GameEventListener<T>
```

## License
[MIT](https://choosealicense.com/licenses/mit/)
